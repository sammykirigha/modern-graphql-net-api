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
public static class PlanMuatation
{
     public static async Task<Plan> AddPlan(PlanMutationInput Plan, EntityLogInfo logInfo, IPlanService service)
    {
        try
        {
           Plan.Name.CheckRequired();

           var entity = PopulateEntity(new Plan(), Plan);
           entity = await service.AddAsync(entity, logInfo);

           return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    public static async Task<Plan> UpdatePlan(PlanMutationInput input, EntityLogInfo log, IPlanService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(Plan)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Plan>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeletePlan(Guid id, EntityLogInfo logInfo, IPlanService service)
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
    private static Plan PopulateEntity(Plan entity, PlanMutationInput input)
    {
        entity.Name = input.Name.CheckForValue(entity.Name);

        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}