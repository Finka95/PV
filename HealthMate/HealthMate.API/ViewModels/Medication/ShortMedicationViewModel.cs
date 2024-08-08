using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Medication
{
    public class ShortMedicationViewModel : IBaseViewModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public string MedicationName { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
