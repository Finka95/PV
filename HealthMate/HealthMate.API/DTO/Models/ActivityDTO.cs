namespace HealthMate.API.DTO.Models
{
    public record ActivityDTO(
       Guid Id,
       ActivityTypeDTO ActivityType,
       TimeSpan Duration,
       int CaloriesBurned,
       DateTime Date,
       ICollection<NoteDTO>? Notes
    );
}
