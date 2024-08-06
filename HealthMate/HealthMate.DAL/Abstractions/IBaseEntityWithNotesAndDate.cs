using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IBaseEntityWithNotesAndDate
    {
        public DateTime Date { get; set; }
        public List<NoteEntity> Notes { get; set; }
    }
}
