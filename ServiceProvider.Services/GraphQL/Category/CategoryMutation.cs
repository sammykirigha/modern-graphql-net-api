using System.Text.Json;
using HotChocolate.Authorization;
using ServiceProvider.Core.Classes;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

namespace Graphql.Services.GraphQL;

[Authorize]
[MutationType]
public static class CategoryMutation
{
    public static async Task<Category> AddCategory(CategoryMutationInput Category, EntityLogInfo logInfo, ICategoryService service)
    {
        try
        {
           Category.Name.CheckRequired();

           var entity = PopulateEntity(new Category(), Category);
           entity = await service.AddAsync(entity, logInfo);

           return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }

    public static async Task<Category> UpdateCategory(CategoryMutationInput input, EntityLogInfo log, ICategoryService service)
    {
        try
        {
            input.Id.CheckRequired();
            var entity = await service.GetByIdAsync(input.Id.Value)
                         ?? throw new AppException($"{nameof(Category)} not found.", ValidationCode.MissingRequirementEntity);
            var oldentity = JsonSerializer.Serialize(entity).Deserialize<Category>();
            PopulateEntity(entity, input);

            entity = await service.UpdateAsync(entity, log, oldentity);
            return entity;
        }
        catch (AppException ex)
        {
            throw new GraphQLException(new Error(ex.Message, ex.ValidationCode));
        }
    }
    
    public static async Task<bool> DeleteCategory(Guid id, EntityLogInfo logInfo, ICategoryService service)
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
    private static Category PopulateEntity(Category entity, CategoryMutationInput input)
    {
        entity.Name = input.Name.CheckForValue(entity.Name);

        entity.DateCreated = input.DateCreated.CheckForValue(entity.DateCreated);
        entity.DateModified = DateTime.UtcNow;

        return entity;
    }
}