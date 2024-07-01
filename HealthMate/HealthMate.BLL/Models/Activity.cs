using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Activity : IBaseModel, IBaseModelWithNotesAndDate
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public ActivityType? ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateOnly Date { get; set; }
        public List<Note> Notes { get; set; }
    }
}
