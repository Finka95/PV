using HealthMate.DAL.Enums;

namespace HealthMate.API.DTO.ShortModels
{
    public record ShortMoodDTO(
        DateTime Date,
        Guid UserId,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<ShortNoteDTO>? Notes
    );
}
