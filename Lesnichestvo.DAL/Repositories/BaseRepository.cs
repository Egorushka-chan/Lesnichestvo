using Lesnichestvo.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL.Repositories
{
    internal class BaseRepository<TEntity>(MainContext context) : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly MainContext _context = context;
        public async Task CreateAsync(TEntity entity, CancellationToken token)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync(token);
        }

        public async Task CreateRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            _context.Set<TEntity>().AddRange(entities);
            await _context.SaveChangesAsync(token);
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken token)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync(token);
        }

        public async Task DeleteRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            _context.Set<TEntity>().RemoveRange(entities);
            await _context.SaveChangesAsync(token);
        }

        public Task<List<TEntity>> GetAllAsync(CancellationToken token)
        {
            return _context.Set<TEntity>().ToListAsync(token);
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken token)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync(token);

        }

        public async Task UpdateRangeAsync(List<TEntity> entities, CancellationToken token)
        {
            _context.Set<TEntity>().UpdateRange(entities);
            await _context.SaveChangesAsync(token);
        }
    }
}
