using HealthMate.API.ViewModels.FoodItem;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Nutrition
{
    public class ShortNutritionViewModel
    {
        public Guid UserId { get; set; }
        public MealType MealType { get; set; } = MealType.Unselected;
        public int Calories { get; set; }
        public DateOnly Date { get; set; }
        public List<ShortFoodItemViewModel>? FoodItems { get; set; } = new();
        public List<ShortNoteViewModel>? Notes { get; set; } = new();
    }
}
