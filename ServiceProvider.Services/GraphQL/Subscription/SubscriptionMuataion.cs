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
public static class SubscriptionMuatation
{
     public static async Task<Subscription> AddSubscription(SubscriptionMutationInput Subscription, EntityLogInfo logInfo, ISubscriptionService service)
    {
        try
        {
           Subscription.UserId.CheckRequired();
           Subscription.PlanId.CheckRequired();
           Subscription.Status.CheckRequired();

           var entity = PopulateEntity(new Subscription(), Subscription);
           entity = await service.AddAsync(entity, logInfo);

           return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    public static async Task<Subscription> UpdateSubscription(SubscriptionMutationInput input, EntityLogInfo log, ISubscriptionService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(Subscription)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Subscription>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteSubscription(Guid id, EntityLogInfo logInfo, ISubscriptionService service)
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
    private static Subscription PopulateEntity(Subscription entity, SubscriptionMutationInput input)
    {
        entity.UserId = input.UserId.CheckForValue(entity.UserId);
        entity.PlanId = input.PlanId.CheckForValue(entity.PlanId);
        entity.RenewalType = input.RenewalType.CheckForValue(entity.RenewalType);
        entity.Status = input.Status.CheckForValue(entity.Status);
        entity.StartDate = input.StartDate.CheckForValue(entity.StartDate);
        entity.EndDate = input.EndDate.CheckForValue(entity.EndDate);

        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}