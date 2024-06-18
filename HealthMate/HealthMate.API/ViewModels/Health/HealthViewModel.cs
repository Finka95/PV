using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Health
{
    public class HealthViewModel(
        DateTime Date,
        int SystolicBloodPressure,
        int DiastolicBloodPressure,
        int HeartRate,
        double BloodSugar,
        double Cholesterol,
        ICollection<NoteViewModel>? Notes
    ) : BaseViewModel;
}
