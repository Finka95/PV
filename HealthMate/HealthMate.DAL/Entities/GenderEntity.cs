using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class GenderEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
