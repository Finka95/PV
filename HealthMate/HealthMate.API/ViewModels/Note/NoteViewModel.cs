using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.Note
{
    public class NoteViewModel : IBaseViewModel
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
    }
}
