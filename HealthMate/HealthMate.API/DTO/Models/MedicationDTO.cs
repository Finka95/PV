using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record MedicationDTO(
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<NoteDTO>? Notes
    ) : BaseDto;
}
