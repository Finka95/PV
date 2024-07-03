using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class ModelWithNotesAndDateRepository<TEntity>(ApplicationDbContext context)
        : GenericRepository<TEntity>(context), IModelWithNotesAndDateRepository<TEntity>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate, IModelWithUserId
    {
        public new async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token)
        {
            var noteIds = entity.Notes.Select(t => t.Id).ToList();
            
            await Context.Set<NoteEntity>()
                .Where(n => !noteIds.Contains(n.Id))
                .ExecuteDeleteAsync(token);

            Context.Update(entity);
            await Context.SaveChangesAsync(token);
            return entity;
        }

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

        public async Task<ICollection<TEntity>> GetByDate(Guid userId,
            DateOnly data,
            CancellationToken token) =>
            await DbSet
                .Where(e => e.Date == data && e.UserId == userId)
                .Include(e => e.Notes)
                .AsNoTracking()
                .ToListAsync(token);

        public async Task<ICollection<TEntity>> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token) =>
            await DbSet
                 .Where(e => e.Date > startDate && e.Date < finishDate && e.UserId == userId)
                 .Include(e => e.Notes)
                 .AsNoTracking()
                 .ToListAsync(token);
    }
}
