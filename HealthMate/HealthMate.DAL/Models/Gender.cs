using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Models
{
    public class Gender : BaseEntity
    {
        [StringLength(32)]
        public required string Name { get; set; }
    }
}
