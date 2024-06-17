using HealthMate.API.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.API.DTO.Models
{
    public record NutritionDTO(
        MealType MealType,
        ICollection<FoodItemDTO>? FoodItems,
        int Calories,
        DateTime Date,
        ICollection<NoteDTO>? Notes
    ) : BaseDto;
}
