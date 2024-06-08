using HotChocolate.Authorization;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;
using System.Text.Json;

namespace ServiceProvider.Services.GraphQL;

[Authorize]
[MutationType]
public static class PaymentMuatation
{
     public static async Task<Payment> AddPayment(Guid planId,  EntityLogInfo logInfo, IPaymentService service)
    {
        try
        {
           var entity = await service.AddAsync( planId, logInfo);
           return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    public static async Task<Payment> UpdatePayment(PaymentMutationInput input, EntityLogInfo log, IPaymentService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(Payment)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Payment>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeletePayment(Guid id, EntityLogInfo logInfo, IPaymentService service)
    {
        try
        {
            var result = await service.DeleteAsync(id, logInfo);
            return result;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    [GraphQLIgnore]
    private static Payment PopulateEntity(Payment entity, PaymentMutationInput input)
    {
        entity.Amount = input.Amount.CheckForValue(entity.Amount);
        entity.TransactionCode = input.TransactionCode.CheckForValue(entity.TransactionCode);
        entity.PaymentMethod = input.PaymentMethod.CheckForValue(entity.PaymentMethod);
        entity.PaymentDate = input.PaymentDate.CheckForValue(entity.PaymentDate);
        entity.Currency = input.Currency.CheckForValue(entity.Currency);
        entity.Status = input.Status.CheckForValue(entity.Status);

        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}