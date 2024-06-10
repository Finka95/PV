using System.ComponentModel.DataAnnotations;

namespace HealthMate.DAL.Models
{
    public class Medication
    {
        public required Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required User User { get; set; }

        [StringLength(255)]
        public required string MedicationName { get; set; } //Name of the medication

        [StringLength(10)]
        public required string Dosage { get; set; }// The dosage of the medicine (e.g. 500 mg)

        [StringLength(255)]
        public required string Frequency { get; set; } // How often the medicine is taken (e.g. 2 times a day)
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}
