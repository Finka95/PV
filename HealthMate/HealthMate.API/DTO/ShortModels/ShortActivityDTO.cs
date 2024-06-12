namespace HealthMate.API.DTO.ShortModels
{
    public record ShortActivityDTO(
        Guid UserId,
        Guid ActivityTypeId,
        TimeSpan Duration,
        int CaloriesBurned,
        ICollection<ShortNoteDTO>? Notes
    );
}
