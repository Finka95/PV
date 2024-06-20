using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.Activity
{
    public class ShortActivityViewModel : BaseViewModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public Guid ActivityTypeId { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
    }
}
