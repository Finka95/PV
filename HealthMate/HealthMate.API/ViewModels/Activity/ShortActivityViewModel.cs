using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Activity
{
    public class ShortActivityViewModel(
        Guid UserId,
        Guid ActivityTypeId,
        TimeSpan Duration,
        int CaloriesBurned,
        ICollection<ShortNoteViewModel>? Notes
    );
}
