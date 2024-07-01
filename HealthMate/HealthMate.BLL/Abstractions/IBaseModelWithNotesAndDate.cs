using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IBaseModelWithNotesAndDate
    {
        public DateOnly Date { get; set; }
        public List<Note> Notes { get; set; }
    }
}
