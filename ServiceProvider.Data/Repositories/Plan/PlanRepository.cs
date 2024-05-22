
// using System.Text.Json;
// using Microsoft.EntityFrameworkCore;
// using ServiceProvider.Core.Exceptions;
// using ServiceProvider.Core.Interfaces.Repositories;
// using ServiceProvider.Core.Models;
// using ServiceProvider.Data.Contexts;

// namespace ServiceProvider.Data.Repositories;

// public class PlanRepository(ServiceProviderContext context) 
//     : RepositoryBase(context), IPlanRepository
// {
//     //
//     public async Task<Plan?> GetByIdAsync(Guid id)
//     {
//         var entity = await Context.Plans.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
//         return entity;
//     }

//     public IQueryable<Plan> GetList() => from i in Context.Plans select i;

//     public async Task<Plan> AddAsync(Plan entity)
//     {
//         var jsonString = JsonSerializer.Serialize(entity);
//         var newentity = JsonSerializer.Deserialize<Plan>(jsonString) ??
//                         throw new AppException("Json conversion error for add Plan");
//          newentity.Id = Guid.NewGuid();
//          newentity.DateCreated = DateTime.UtcNow;
//          newentity.DateModified = DateTime.UtcNow;

//          Context.Plans.Add(newentity);
//          await Context.SaveChangesAsync();
//          return newentity;
//     }

//     public async Task<Plan> UpdateAsync(Plan entity)
//     {
//         if (entity.Id == Guid.Empty)
//             throw new AppException("Id missing for Plan update");
//         Context.Entry(entity).State = EntityState.Modified;
//         entity.DateModified = DateTime.UtcNow;
//         await Context.SaveChangesAsync();

//         return entity;
//     }

//     public async Task<int> DeleteAsync(Guid id)
//     {
//         var result = await Context.Plans.Where(x => x.Id == id).ExecuteDeleteAsync();
//         return result;
//     }
// }

