using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public required ActivityTypeEntity ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public ICollection<NoteEntity>? Notes { get; set; }
    }
}
