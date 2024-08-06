namespace HealthMate.API.ViewModels.User
{
    public class ShortUserViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
