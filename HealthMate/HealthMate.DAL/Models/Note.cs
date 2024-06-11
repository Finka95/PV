using System.ComponentModel.DataAnnotations;

namespace HealthMate.DAL.Models
{
    public class Note
    {
        public required Guid Id { get; set; }

        [StringLength(2000)]
        public required string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
