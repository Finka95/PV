using HealthMate.DAL.Enums;

namespace HealthMate.API.DTO.Models
{
    public record MoodDTO(
        Guid Id,
        DateTime Date,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<NoteDTO>? Notes
    );
}
