using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Interfaces;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using Stripe;
using Subscription = ServiceProvider.Core.Models.Subscription;
using paymentMethod = ServiceProvider.Core.Enums.PaymentMethod;

namespace ServiceProvider.Services;

public class PaymentService: IPaymentService
{
  private readonly IPaymentRepository _repository;
  private readonly ISubscriptionPaymentsRepository _subPaymentRepository;
  private readonly IPlanRepository _planRepository;
  private ISubscriptionRepository _subrepository;
  private readonly IStripeGateWayService<PaymentIntent> _stripe;
    private readonly IEntityLogService _log;

    public PaymentService(
        IPaymentRepository repository,
        IStripeGateWayService<PaymentIntent> stripeGateWay,
        ISubscriptionPaymentsRepository subPaymentRepository,
        IPlanRepository planRepository,
        ISubscriptionRepository subrepository,
        IEntityLogService log)
    {
        _repository = repository;
        _subrepository = subrepository;
        _log = log;
        _stripe = stripeGateWay;
        _planRepository = planRepository;
        _subPaymentRepository = subPaymentRepository;
    }

    // QUERIES
    public async Task<Payment?> GetByIdAsync(Guid id)
    {
        var entity = await _repository.GetByIdAsync(id);
        return entity;
    }

    public IQueryable<Payment> GetList()
    {
        return _repository.GetList().AsNoTracking();
    }

    public IQueryable<PaymentPaged> GetPagedList()
    {
        return (
            from u in _repository.GetList()
            select new PaymentPaged
            {
                Payment = u
            }
        ).AsNoTracking();
    }


    // MUTATIONS
    public async Task<Payment> AddAsync(Guid planId, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();
        var plan = await _planRepository.GetByIdAsync(planId); 
        PaymentIntent charge = await _stripe.CreatePaymentAsync(plan);

        if(charge.Status == "requires_payment_method")
        {
           throw new Exception("Payment Method Required");
        }
        
        var newPaymentRecod = new Payment 
        {
	        TransactionCode = charge.ClientSecret,
	        Amount = charge.Amount,
	        Currency = (Currency)Enum.Parse(typeof(Currency), charge.Currency.ToUpper(), ignoreCase: false),
	        PaymentDate = DateTime.UtcNow,
	        DateCreated = DateTime.UtcNow,
	        PaymentMethod = (paymentMethod)Enum.Parse(typeof(paymentMethod), charge.PaymentMethodTypes[0].ToUpper(), ignoreCase: false),
	        Status = (PaymentStatus)Enum.Parse(typeof(PaymentStatus), charge.Status.ToUpper(), ignoreCase: false),
	        UserId = new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3")
        };
        
        var newSubscripton = new Subscription 
        {
	        PlanId = planId,
	        UserId = new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"),
	        StartDate = DateTime.UtcNow,
	        EndDate = DateTime.UtcNow.AddMonths(plan!.Duration),
	        Status = charge.Status == "succeded" ? SubscriptionStatus.Active  :  SubscriptionStatus.Failed,
	        DateCreated = DateTime.UtcNow,
	        RenewalType = RenewalType.Manual,
        };
        var paymentEntity = await _repository.AddAsync(newPaymentRecod);
        var subEntity = await _subrepository.AddAsync(newSubscripton);
        await _log.LogAddAsync(logInfo, paymentEntity);
        await _log.LogAddAsync(logInfo, subEntity);


        var newSubPayment = new SubscriptionPayments
        {
	        SubscriptionId = subEntity.Id, 
	        PaymentId = paymentEntity.Id,
	        PaymentAmount = paymentEntity.Amount
        };
        var subPaymentEntity = await _subPaymentRepository.AddAsync(newSubPayment);
        await _log.LogAddAsync(logInfo, subPaymentEntity);
        await trans.CommitAsync();

        return paymentEntity;
    }

    public async Task<Payment> UpdateAsync(Payment input, EntityLogInfo logInfo, Payment? oldEntity = null)
    {
	    using var trans = await _repository.BeginTransactionAsync();

        oldEntity ??= await _repository.GetByIdAsync(input.Id)
                      ?? throw new AppException($"{nameof(Payment)} not found.", ValidationCode.MissingRequirementEntity);
        var entity = await _repository.UpdateAsync(input);
        await _log.LogUpdateAsync(logInfo, entity, oldEntity);

        await trans.CommitAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(Guid id, EntityLogInfo logInfo)
    {
        using var trans = await _repository.BeginTransactionAsync();

        var entity = await _repository.GetByIdAsync(id)
                     ?? throw new AppException($"{nameof(Payment)} not found.", ValidationCode.MissingRequirementEntity);
        var result = await _repository.DeleteAsync(id);
        await _log.LogDeleteAsync(logInfo, entity);

        await trans.CommitAsync();

        return result > 0;
    }
}