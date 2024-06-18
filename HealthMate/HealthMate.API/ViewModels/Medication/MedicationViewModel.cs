using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Medication
{
    public class MedicationViewModel(
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<NoteViewModel>? Notes
    ) : BaseDto;
}
