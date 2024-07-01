using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class ModelWithNotesAndDateRepository<TEntity>(ApplicationDbContext context)
        : GenericRepository<TEntity>(context), IModelWithNotesAndDateRepository<TEntity>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate, IModelWithUserId
    {
        public new async Task<ICollection<TEntity>> GetAllAsync(CancellationToken token) =>
            await DbSet
                .Include(e => e.Notes)
                .AsNoTracking()
                .AsSplitQuery()
                .ToListAsync(token);

        public new async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken token) =>
            await DbSet
                .Where(t => t.Id.Equals(id))
                .Include(e => e.Notes)
                .AsNoTracking()
                .AsSplitQuery()
                .SingleOrDefaultAsync(token);

        public async Task<TEntity?> GetByDate(Guid userId,
            DateOnly data,
            CancellationToken token) =>
            await DbSet
                .Where(e => e.Date == data && e.UserId == userId)
                .Include(e => e.Notes)
                .SingleOrDefaultAsync(token);

        public async Task<ICollection<TEntity>> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token) =>
            await DbSet
                 .Where(e => e.Date > startDate && e.Date < finishDate && e.UserId == userId)
                 .Include(e => e.Notes)
                 .ToListAsync(token);
    }
}
