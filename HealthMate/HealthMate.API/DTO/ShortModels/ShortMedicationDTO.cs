namespace HealthMate.API.DTO.ShortModels
{
    public record ShortMedicationDTO(
        Guid UserId,
        string MedicationName,
        string Dosage,
        string Frequency,
        DateTime EndDate,
        ICollection<ShortNoteDTO>? Notes
    );
}
