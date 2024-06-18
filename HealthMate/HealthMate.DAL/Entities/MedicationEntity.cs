using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class MedicationEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public required UserEntity User { get; set; }

        [StringLength(255)]
        public required string MedicationName { get; set; } //Name of the medication

        [StringLength(10)]
        public required string Dosage { get; set; }// The dosage of the medicine (e.g. 500 mg)

        [StringLength(255)]
        public required string Frequency { get; set; } // How often the medicine is taken (e.g. 2 times a day)
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<NoteEntity>? Notes { get; set; }
    }
}
