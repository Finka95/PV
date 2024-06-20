using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.ActivityType;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Activity
{
    public class ActivityViewModel : BaseViewModel
    {
        public ActivityTypeViewModel ActivityType { get; set; } = new();
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateOnly Date { get; set; }
        public List<NoteViewModel>? Notes { get; set; } = new();
    }
}
