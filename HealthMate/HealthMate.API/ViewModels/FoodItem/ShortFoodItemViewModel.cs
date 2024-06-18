using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.FoodItem
{
    public class ShortFoodItemViewModel(
        string Name,
        double Quantity,
        int Calories,
        double Protein,
        double Fat,
        double Carbohydrates,
        ICollection<ShortNoteViewModel>? Notes
    );
}
