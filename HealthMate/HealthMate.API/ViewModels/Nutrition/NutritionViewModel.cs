using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.FoodItem;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Nutrition
{
    public class NutritionViewModel(
        MealType MealType,
        ICollection<FoodItemViewModel>? FoodItems,
        int Calories,
        DateTime Date,
        ICollection<NoteViewModel>? Notes
    ) : BaseViewModel;
}
