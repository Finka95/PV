using System.ComponentModel.DataAnnotations;

namespace HealthMate.BLL.Models
{
    public class Gender 
    {
        public required Guid Id { get; set; }

        [StringLength(32)]
        public required string Name { get; set; }
    }
}
