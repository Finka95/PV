using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken token) =>
            await _context.Set<TEntity>().Where(t => t.Id.Equals(id)).SingleOrDefaultAsync(token);

        public async Task<ICollection<TEntity>> GetAllAsync(CancellationToken token) =>
            await _context.Set<TEntity>().ToListAsync(token);

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync(token);
            return entity;
        }

        public async Task DeleteAsync(Guid id, CancellationToken token)
        {
            var entity = await _context
                .Set<TEntity>()
                .AsNoTracking()
                .Where(t => t.Id.Equals(id))
                .SingleOrDefaultAsync(token);

            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);

                await _context.SaveChangesAsync(token);
            }
        }

        public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken token)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync(token);
            return entity;
        }
    }
}
