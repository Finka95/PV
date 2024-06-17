using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record NoteDTO(
        string Content,
        DateTime Date
    ) : BaseDto;
}
