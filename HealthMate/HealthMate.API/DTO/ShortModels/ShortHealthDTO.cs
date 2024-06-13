namespace HealthMate.API.DTO.ShortModels
{
    public record ShortHealthDTO(
        Guid UserId,
        int SystolicBloodPressure,
        int DiastolicBloodPressure,
        int HeartRate,
        double BloodSugar,
        double Cholesterol,
        ICollection<ShortNoteDTO>? Notes
    );
}
