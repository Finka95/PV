using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class NoteEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
