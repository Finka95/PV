using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Medication : BaseModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string MedicationName { get; set; } = string.Empty; //Name of the medication
        public string Dosage { get; set; } = string.Empty; // The dosage of the medicine (e.g. 500 mg)
        public string Frequency { get; set; } = string.Empty; // How often the medicine is taken (e.g. 2 times a day)
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public new DateOnly Date { get; set; }
    }
}
