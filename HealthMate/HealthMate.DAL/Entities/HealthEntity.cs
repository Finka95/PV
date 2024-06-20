using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class HealthEntity : BaseEntityWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
    }
}
