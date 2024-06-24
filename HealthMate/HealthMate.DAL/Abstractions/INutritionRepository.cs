using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface INutritionRepository : IModelWithNotesAndDateRepository<NutritionEntity>
    {
        Task<FoodItemEntity?> GetFoodItem(Guid id,
            CancellationToken token);
    }
}
