namespace HealthMate.API.DTO.Models
{
    public record HealthDTO(
        Guid Id,
        DateTime Date,
        int SystolicBloodPressure,
        int DiastolicBloodPressure,
        int HeartRate,
        double BloodSugar,
        double Cholesterol,
        ICollection<NoteDTO>? Notes
    );
}
