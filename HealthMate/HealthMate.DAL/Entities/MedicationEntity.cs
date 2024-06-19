using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class MedicationEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public string MedicationName { get; set; } = string.Empty; //Name of the medication
        public string Dosage { get; set; } = string.Empty; // The dosage of the medicine (e.g. 500 mg)
        public string Frequency { get; set; } = string.Empty; // How often the medicine is taken (e.g. 2 times a day)
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
