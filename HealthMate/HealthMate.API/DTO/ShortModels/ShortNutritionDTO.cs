using HealthMate.DAL.Enums;

namespace HealthMate.API.DTO.ShortModels
{
    public record ShortNutritionDTO(
        Guid UserId,
        MealType MealType,
        ICollection<ShortFoodItemDTO>? FoodItems,
        int Calories,
        ICollection<ShortNoteDTO>? Notes
    );
}
