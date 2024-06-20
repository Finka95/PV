using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class NoteEntity : BaseEntity
    {
        public string Content { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
    }
}
