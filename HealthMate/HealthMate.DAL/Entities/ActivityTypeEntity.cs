using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityTypeEntity : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public List<ActivityEntity> Activities { get; set; } = new();
    }
}
