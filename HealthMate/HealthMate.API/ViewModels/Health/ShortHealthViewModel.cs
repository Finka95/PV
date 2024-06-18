using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Health
{
    public class ShortHealthViewModel(
        Guid UserId,
        int SystolicBloodPressure,
        int DiastolicBloodPressure,
        int HeartRate,
        double BloodSugar,
        double Cholesterol,
        ICollection<ShortNoteViewModel>? Notes
    );
}
