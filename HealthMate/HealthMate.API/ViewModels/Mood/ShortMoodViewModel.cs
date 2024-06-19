using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class ShortMoodViewModel
    {
        public DateOnly Date { get; set; }
        public Guid UserId { get; set; }
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
        public List<ShortNoteViewModel>? Notes { get; set; } = new();
    }
}
