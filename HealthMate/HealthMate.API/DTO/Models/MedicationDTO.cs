namespace HealthMate.API.DTO.Models
{
    public record MedicationDTO(
        Guid Id,
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<NoteDTO>? Notes
    );
}
