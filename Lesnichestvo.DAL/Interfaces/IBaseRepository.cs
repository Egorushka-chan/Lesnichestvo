namespace Lesnichestvo.DAL.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        Task<List<TEntity>> GetAllAsync(CancellationToken token);
        Task CreateAsync(TEntity entity, CancellationToken token);
        Task CreateRangeAsync(List<TEntity> entities, CancellationToken token);
        Task UpdateAsync(TEntity entity, CancellationToken token);
        Task UpdateRangeAsync(List<TEntity> entities, CancellationToken token);
        Task DeleteAsync(TEntity entity, CancellationToken token);
        Task DeleteRangeAsync(List<TEntity> entities, CancellationToken token);
    }
}
