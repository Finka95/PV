using HealthMate.BLL.Models;

namespace HealthMate.API.Abstractions
{
    public abstract class BaseViewModelWithNotesAndDate : BaseViewModel
    {
        public DateOnly Date { get; set; }
        public List<Note> Notes { get; set; } = new();
    }
}
