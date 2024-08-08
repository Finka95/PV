using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Health
{
    public class HealthViewModel : IBaseViewModel, IBaseViewModelWithNotesAndDate
    {
        public Guid Id { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
