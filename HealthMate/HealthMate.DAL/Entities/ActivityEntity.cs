using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public ActivityTypeEntity? ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateOnly Date { get; set; }

        public List<NoteEntity> Notes { get; set; } = new();
    }
}
