using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class User : IBaseModel
    {
        public Guid Id { get; set; } 
        public required string Name { get; set; } = string.Empty;
        public required string UserName { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; } = new();
        public Guid GenderId { get; set; }
        public Gender? Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}
