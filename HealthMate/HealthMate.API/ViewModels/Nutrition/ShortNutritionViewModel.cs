using HealthMate.API.ViewModels.FoodItem;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Nutrition
{
    public class ShortNutritionViewModel(
        Guid UserId,
        MealType MealType,
        ICollection<ShortFoodItemViewModel>? FoodItems,
        int Calories,
        ICollection<ShortNoteViewModel>? Notes
    );
}
