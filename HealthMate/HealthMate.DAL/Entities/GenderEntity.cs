using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class GenderEntity : BaseEntity
    {
        [StringLength(32)]
        public required string Name { get; set; }
    }
}
