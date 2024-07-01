using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IBaseEntityWithNotesAndDate
    {
        public DateOnly Date { get; set; }
        public List<NoteEntity> Notes { get; set; }
        public Guid UserId { get; set; }
    }
}
