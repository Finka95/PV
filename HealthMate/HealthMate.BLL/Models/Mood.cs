using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.BLL.Models
{
    public class Mood : BaseModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
    }
}
