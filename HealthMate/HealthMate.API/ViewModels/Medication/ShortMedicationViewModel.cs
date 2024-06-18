using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Medication
{
    public class ShortMedicationViewModel(
        Guid UserId,
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<ShortNoteViewModel>? Notes
    );
}
