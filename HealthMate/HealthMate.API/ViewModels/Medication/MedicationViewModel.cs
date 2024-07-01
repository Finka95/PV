using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Medication
{
    public class MedicationViewModel : IBaseViewModel, IBaseViewModelWithNotesAndDate
    {
        public Guid Id { get; set; }
        public string MedicationName { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public DateOnly Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
