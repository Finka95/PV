using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.BLL.Models
{
    public class Mood : BaseModel
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public DateOnly Date { get; set; }
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
        public List<Note> Notes { get; set; } = new();
    }
}
