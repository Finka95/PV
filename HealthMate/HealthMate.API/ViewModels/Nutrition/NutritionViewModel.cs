using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.FoodItem;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Nutrition
{
    public class NutritionViewModel : BaseViewModelWithNotesAndDate
    {
        public MealType MealType { get; set; } = MealType.Unselected;
        public int Calories { get; set; }
        public List<FoodItemViewModel>? FoodItems { get; set; } = new();
    }
}
