using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Gender;

namespace HealthMate.API.ViewModels.User
{
    public class UserViewModel : IBaseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public GenderViewModel Gender { get; set; } = new();
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
