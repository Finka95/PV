using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityTypeEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<ActivityEntity> Activities { get; set; } = new();
    }
}
