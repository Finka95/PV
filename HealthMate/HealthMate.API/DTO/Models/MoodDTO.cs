using HealthMate.API.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.API.DTO.Models
{
    public record MoodDTO(
        DateTime Date,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<NoteDTO>? Notes
    ) : BaseDto;
}
