namespace HealthMate.API.DTO.Models
{
    public class MedicationDTO(
        Guid Id,
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<NoteDTO>? Notes
    );
}
