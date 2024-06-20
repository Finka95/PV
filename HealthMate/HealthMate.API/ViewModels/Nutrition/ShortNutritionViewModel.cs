using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.FoodItem;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Nutrition
{
    public class ShortNutritionViewModel : BaseViewModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public MealType MealType { get; set; } = MealType.Unselected;
        public int Calories { get; set; }
        public List<ShortFoodItemViewModel>? FoodItems { get; set; } = new();
    }
}
