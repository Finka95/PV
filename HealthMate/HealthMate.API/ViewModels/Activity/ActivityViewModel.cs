using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.ActivityType;

namespace HealthMate.API.ViewModels.Activity
{
    public class ActivityViewModel : BaseViewModelWithNotesAndDate
    {
        public ActivityTypeViewModel ActivityType { get; set; } = new();
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
    }
}
