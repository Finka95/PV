using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.Note
{
    public class NoteViewModel : BaseViewModel
    {
        public string Content { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
    }
}
