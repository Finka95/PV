namespace HealthMate.API.DTO.ShortModels
{
    public class ShortActivityDTO(
        Guid UserId,
        Guid ActivityTypeId,
        TimeSpan Duration,
        int CaloriesBurned,
        ICollection<ShortNoteDTO>? Notes
    );
}
