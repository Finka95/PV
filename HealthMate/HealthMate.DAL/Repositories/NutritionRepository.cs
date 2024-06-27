using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class NutritionRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<NutritionEntity>(context), INutritionRepository
    {
        public async Task<FoodItemEntity?> GetFoodItem(Guid id, CancellationToken token) =>
            await context.Set<FoodItemEntity>()
                .Where(f => f.Id == id)
                .SingleOrDefaultAsync(token);
    }
}
