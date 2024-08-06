using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;
using HealthMate.DAL.Enums;

namespace HealthMate.API.ViewModels.Mood
{
    public class MoodViewModel : IBaseViewModel, IBaseViewModelWithNotesAndDate
    {
        public Guid Id { get; set; }
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
        public DateTime Date { get; set; }
        public List<NoteViewModel> Notes { get; set; }
    }
}
