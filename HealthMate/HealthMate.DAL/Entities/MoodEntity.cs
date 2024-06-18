using HealthMate.DAL.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Entities
{
    public class MoodEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public required UserEntity User { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "int")]
        public MoodStatus MoodStatus { get; set; }
        public int StressLevel { get; set; }
        public ICollection<NoteEntity>? Notes { get; set; }
    }
}
