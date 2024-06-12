namespace HealthMate.API.DTO.ShortModels
{
    public class ShortMedicationDTO(
        Guid UserId,
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<ShortNoteDTO>? Notes
    );
}
