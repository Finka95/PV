using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.ViewModels.Activity
{
    public class ShortActivityViewModel : IBaseViewModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public Guid ActivityTypeId { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
