using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class Activity : BaseModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public ActivityType? ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
    }
}
