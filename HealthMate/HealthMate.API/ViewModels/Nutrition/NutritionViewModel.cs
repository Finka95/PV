using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.FoodItem;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Nutrition
{
    public class NutritionViewModel : IBaseViewModel, IBaseViewModelWithNotesAndDate
    {
        public Guid Id { get; set; }
        public MealType MealType { get; set; } = MealType.Unselected;
        public int Calories { get; set; }
        public List<FoodItemViewModel>? FoodItems { get; set; }
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
