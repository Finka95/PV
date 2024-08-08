using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.Abstractions
{
    public interface IBaseViewModelWithNotesAndDate
    {
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
