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
public static class SubscriptionPaymentsMuatation
{
     public static async Task<SubscriptionPayments> AddSubscriptionPayments(SubscriptionPaymentsMutationInput SubscriptionPayments, EntityLogInfo logInfo, ISubscriptionPaymentsService service)
    {
        try
        {
           SubscriptionPayments.SubscriptionId.CheckRequired();
           SubscriptionPayments.PaymentId.CheckRequired();
           SubscriptionPayments.PaymentAmount.CheckRequired();

           var entity = PopulateEntity(new SubscriptionPayments(), SubscriptionPayments);
           entity = await service.AddAsync(entity, logInfo);

           return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    public static async Task<SubscriptionPayments> UpdateSubscriptionPayments(SubscriptionPaymentsMutationInput input, EntityLogInfo log, ISubscriptionPaymentsService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(SubscriptionPayments)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<SubscriptionPayments>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteSubscriptionPayments(Guid id, EntityLogInfo logInfo, ISubscriptionPaymentsService service)
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
    private static SubscriptionPayments PopulateEntity(SubscriptionPayments entity, SubscriptionPaymentsMutationInput input)
    {
        entity.SubscriptionId = input.SubscriptionId.CheckForValue(entity.SubscriptionId);
        entity.PaymentId = input.PaymentId.CheckForValue(entity.PaymentId);

        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}