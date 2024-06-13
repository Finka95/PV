using HealthMate.Domain.Enums;

namespace HealthMate.API.DTO.Models
{
    public record NutritionDTO(
         Guid Id,
         MealType MealType,
         ICollection<FoodItemDTO>? FoodItems,
         int Calories,
         DateTime Date,
         ICollection<NoteDTO>? Notes
    );
}
