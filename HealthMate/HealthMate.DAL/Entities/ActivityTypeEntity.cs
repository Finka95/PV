using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityTypeEntity : BaseEntity
    {
        [StringLength(255)]
        public required string Name { get; set; }

        public ICollection<ActivityEntity>? Activities { get; set; }
    }
}
