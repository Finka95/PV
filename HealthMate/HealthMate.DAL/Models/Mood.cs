using HealthMate.DAL.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate.DAL.Models
{
    public class Mood
    {
        public required Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required User User { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "int")]
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}
