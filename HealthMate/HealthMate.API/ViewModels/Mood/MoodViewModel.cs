using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class MoodViewModel : BaseViewModel
    {
        public DateOnly Date { get; set; }
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
        public List<NoteViewModel>? Notes { get; set; } = new();
    }
}
