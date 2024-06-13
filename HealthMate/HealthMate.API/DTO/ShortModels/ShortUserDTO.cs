namespace HealthMate.API.DTO.ShortModels
{
    public record ShortUserDTO(
        string Name,
        string UserName,
        string Email,
        DateTime DateOfBirth,
        Guid GenderId,
        double Height,
        double Weight
    );
}
