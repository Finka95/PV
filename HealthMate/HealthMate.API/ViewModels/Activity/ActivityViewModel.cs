using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.ActivityType;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Activity
{
    public class ActivityViewModel(
        ActivityTypeViewModel ActivityType,
        TimeSpan Duration,
        int CaloriesBurned,
        DateTime Date,
        ICollection<NoteViewModel>? Notes
    ) : BaseDto;
}
