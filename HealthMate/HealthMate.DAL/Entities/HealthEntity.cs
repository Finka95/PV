using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class HealthEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public required Guid User { get; set; }
        public DateTime Date { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public int HeartRate { get; set; }
        public double BloodSugar { get; set; }
        public double Cholesterol { get; set; }
        public ICollection<NoteEntity>? Notes { get; set; }
    }
}
