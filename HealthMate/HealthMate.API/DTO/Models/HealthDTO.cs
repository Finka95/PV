using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record HealthDTO(
        DateTime Date,
        int SystolicBloodPressure,
        int DiastolicBloodPressure,
        int HeartRate,
        double BloodSugar,
        double Cholesterol,
        ICollection<NoteDTO>? Notes
    ) : BaseDto;
}
