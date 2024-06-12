namespace HealthMate.BLL.Models
{
    public class Activity
    {
        public required Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public required ActivityType ActivityType { get; set; }
        public TimeSpan Duration { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}
