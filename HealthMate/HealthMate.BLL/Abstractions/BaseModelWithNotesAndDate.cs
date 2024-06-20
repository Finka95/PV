using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public abstract class BaseModelWithNotesAndDate : BaseModel
    {
        public DateOnly Date { get; set; }
        public List<Note> Notes { get; set; } = new();
    }
}
