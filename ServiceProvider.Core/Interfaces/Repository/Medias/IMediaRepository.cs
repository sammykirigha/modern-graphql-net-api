
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Models.Medias;

namespace ServiceProvider.Core.Interfaces.Repository.Medias;
public interface IMediaRepository: IRepositoryBase
{
	IQueryable<Media> GetList();
	Task<Media> AddAsync(Media entity);
	Task<Media> UpdateAsync(Media entity);
	Task<int> DeleteAsync(Guid id);
}