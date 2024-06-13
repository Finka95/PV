namespace HealthMate.API.DTO.Models
{
    public record NoteDTO(
        Guid Id,
        string Content,
        DateTime Date
    );
}
