using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class HealthEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public DateOnly Date { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
