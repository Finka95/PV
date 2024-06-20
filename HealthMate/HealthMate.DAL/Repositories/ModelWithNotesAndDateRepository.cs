using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class ModelWithNotesAndDateRepository<TEntity>(ApplicationDbContext context)
        : GenericRepository<TEntity>(context), IModelWithNotesAndDateRepository<TEntity>
        where TEntity : BaseEntityWithNotesAndDate
    {
        public async Task<TEntity?> GetByDate(DateOnly data,
            CancellationToken token) =>
            await DbSet
                .Where(e => e.Date == data)
                .Include(e => e.Notes)
                .SingleOrDefaultAsync(token);


        public async Task<ICollection<TEntity>> GetBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token) =>
            await DbSet
                .Where(e => e.Date > startDate && e.Date < finishDate)
                .Include(e => e.Notes)
                .ToListAsync(token);
    }
}
