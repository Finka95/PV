using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.Health
{
    public class HealthViewModel : BaseViewModelWithNotesAndDate
    {
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
    }
}
