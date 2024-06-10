using System.ComponentModel.DataAnnotations;

namespace HealthMate.DAL.Models
{
    public class ActivityType
    {
        public required Guid Id { get; set; }

        [StringLength(255)]
        public required string Name { get; set; }

        public ICollection<Activity>? Activities { get; set; }
    }
}
