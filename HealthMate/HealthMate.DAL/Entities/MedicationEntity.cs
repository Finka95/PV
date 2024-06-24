using System.ComponentModel.DataAnnotations.Schema;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class MedicationEntity : BaseEntityWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public string MedicationName { get; set; } = string.Empty;
        public string Dosage { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        [NotMapped]
        public new DateOnly Date { get; set; }
    }
}
