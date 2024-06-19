using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class MedicationEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public string MedicationName { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
