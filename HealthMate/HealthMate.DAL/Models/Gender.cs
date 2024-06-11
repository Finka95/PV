using System.ComponentModel.DataAnnotations;

namespace HealthMate.DAL.Models
{
    public class Gender
    {
        public required Guid Id { get; set; }

        [StringLength(32)]
        public required string Name { get; set; }
    }
}
