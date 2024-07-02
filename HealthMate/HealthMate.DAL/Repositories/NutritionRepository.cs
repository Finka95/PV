using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class NutritionRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<NutritionEntity>(context), INutritionRepository
    {
        public new async Task<ICollection<NutritionEntity>> GetAllAsync(CancellationToken token) =>
            await DbSet
                .AsNoTracking()
                .Include(n => n.FoodItems)
                .Include(n => n.Notes)
                .ToListAsync(token);

        public new async Task<NutritionEntity?> GetByIdAsync(Guid id, CancellationToken token) =>
            await DbSet
                .AsNoTracking()
                .Include(n => n.FoodItems)
                .Include(n => n.Notes)
                .Where(n => n.Id == id)
                .SingleOrDefaultAsync(token);

        public new async Task<NutritionEntity> UpdateAsync(NutritionEntity entity, CancellationToken token)
        {
            var noteIds = entity.Notes.Select(t => t.Id).ToList();
            var foodItemIds = entity.FoodItems.Select(f => f.Id).ToList();
            
            await Context.Set<NoteEntity>()
                .Where(n => !noteIds.Contains(n.Id))
                .ExecuteDeleteAsync(token);

            await Context.Set<FoodItemEntity>()
                .Where(f => !foodItemIds.Contains(f.Id))
                .ExecuteDeleteAsync(token);

            Context.Update(entity);
            await Context.SaveChangesAsync(token);
            return entity;
        }
    }
}
