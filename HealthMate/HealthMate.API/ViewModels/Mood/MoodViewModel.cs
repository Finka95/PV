using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class MoodViewModel(
        DateTime Date,
        MoodStatus MoodStatus,
        int StressLevel,
        ICollection<NoteViewModel>? Notes
    ) : BaseViewModel;
}
