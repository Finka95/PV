using HealthMate.Domain.Enums;

namespace HealthMate.API.DTO.Models
{
    public class MoodDTO(
        Guid Id,
        DateTime Date,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<NoteDTO>? Notes
    );
}
