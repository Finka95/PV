using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Health : IBaseModel, IBaseModelWithNotesAndDate
    {
        public Guid Id { get; set; } 
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
        public DateTime Date { get; set; }
        public List<Note> Notes { get; set; } 
    }
}
