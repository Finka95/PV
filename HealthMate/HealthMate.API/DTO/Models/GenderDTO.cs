using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record GenderDTO(
        string Name
    ) : BaseDto;
}
