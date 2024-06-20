using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Health
{
    public class ShortHealthViewModel
    {
        public Guid UserId { get; set; }
        public DateOnly Date { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
        public List<ShortNoteViewModel>? Note { get; set; } = new();
    }
}
