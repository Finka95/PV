using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record ActivityTypeDTO(
        string Name
    ) : BaseDto;
}
