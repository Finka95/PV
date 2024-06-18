using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.FoodItem
{
    public class FoodItemViewModel(
        string Name,
        double Quantity,
        int Calories,
        double Protein,
        double Fat,
        double Carbohydrates,
        ICollection<NoteViewModel>? Notes
    ) : BaseViewModel;
}
