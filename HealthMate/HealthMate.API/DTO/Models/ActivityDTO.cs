using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record ActivityDTO(
        ActivityTypeDTO ActivityType,
        TimeSpan Duration,
        int CaloriesBurned,
        DateTime Date,
        ICollection<NoteDTO>? Notes
    ) : BaseDto;
}
