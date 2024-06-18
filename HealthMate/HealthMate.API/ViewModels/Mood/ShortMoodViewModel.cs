using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class ShortMoodViewModel(
        DateTime Date,
        Guid UserId,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<ShortNoteViewModel>? Notes
    );
}
