using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.ActivityType;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Activity
{
    public class ActivityViewModel : IBaseViewModel, IBaseViewModelWithNotesAndDate
    {
        public Guid Id { get; set; }
        public ActivityTypeViewModel ActivityType { get; set; } = new();
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
