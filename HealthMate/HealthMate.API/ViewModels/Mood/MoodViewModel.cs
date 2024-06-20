using HealthMate.API.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class MoodViewModel : BaseViewModelWithNotesAndDate
    {
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
    }
}
