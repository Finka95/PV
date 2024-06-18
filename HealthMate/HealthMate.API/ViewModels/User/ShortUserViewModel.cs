namespace HealthMate.API.ViewModels.User
{
    public class ShortUserViewModel(
        string Name,
        string UserName,
        string Email,
        DateTime DateOfBirth,
        Guid GenderId,
        double Height,
        double Weight
    );
}
