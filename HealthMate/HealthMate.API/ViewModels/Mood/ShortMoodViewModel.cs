using HealthMate.API.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class ShortMoodViewModel : BaseViewModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
    }
}
