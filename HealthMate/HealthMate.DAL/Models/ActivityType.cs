using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Models
{
    public class ActivityType : BaseEntity
    {
        [StringLength(255)]
        public required string Name { get; set; }

        public ICollection<Activity>? Activities { get; set; }
    }
}
