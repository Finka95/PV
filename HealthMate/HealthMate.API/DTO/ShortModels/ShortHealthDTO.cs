namespace HealthMate.API.DTO.ShortModels
{
    public class ShortHealthDTO(
        Guid UserId,
        int SystolicBloodPressure,
        int DiastolicBloodPressure,
        int HeartRate,
        double BloodSugar,
        double Cholesterol,
        ICollection<ShortNoteDTO>? Notes
    );
}
