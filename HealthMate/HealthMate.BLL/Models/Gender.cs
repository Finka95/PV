using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Gender : IBaseModel
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } = string.Empty;
    }
}
