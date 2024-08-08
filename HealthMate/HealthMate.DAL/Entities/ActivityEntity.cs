using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class ActivityEntity : IBaseEntity, IBaseEntityWithNotesAndDate, IModelWithUserId
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public ActivityTypeEntity? ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
