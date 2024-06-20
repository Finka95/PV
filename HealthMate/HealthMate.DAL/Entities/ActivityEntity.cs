using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityEntity : BaseEntityWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public ActivityTypeEntity? ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
    }
}
