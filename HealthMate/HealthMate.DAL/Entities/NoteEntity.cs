using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class NoteEntity : BaseEntity
    {
        [StringLength(2000)]
        public required string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
