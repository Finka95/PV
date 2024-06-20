using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public abstract class BaseEntityWithNotesAndDate : BaseEntity
    {
        public DateOnly Date { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
