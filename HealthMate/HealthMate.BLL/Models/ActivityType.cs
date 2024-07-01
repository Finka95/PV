using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class ActivityType : IBaseModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
