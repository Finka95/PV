using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface INutritionService : IModelWithNotesAndDateService<Nutrition>
    {
        Task<Nutrition> AddFoodItem(Guid nutritionId,
            FoodItem foodItemModel,
            CancellationToken token);

        Task RemoveFoodItem(Guid nutritionId,
            Guid foodItemId,
            CancellationToken token);

        Task<Nutrition> UpdateFoodItem(Guid nutritionId,
            FoodItem foodItemModel,
            Guid foodItemId,
            CancellationToken token);
    }
}
