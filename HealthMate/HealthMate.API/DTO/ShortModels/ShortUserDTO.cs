namespace HealthMate.API.DTO.ShortModels
{
    public class ShortUserDTO(
        string Name,
        string UserName,
        string Email,
        DateTime DateOfBirth,
        Guid GenderId,
        double Height,
        double Weight
    );
}
