using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class UserEntity : BaseEntity
    {
        [StringLength(255)]
        public required string Name { get; set; }

        [StringLength(255)]
        public required string UserName { get; set; }

        [StringLength(255)]
        public required string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public required GenderEntity Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public ICollection<HealthEntity>? HealthCollection { get; set; }
        public ICollection<ActivityEntity>? ActivityCollection { get; set; }
        public ICollection<NutritionEntity>? NutritionCollection { get; set; }
        public ICollection<MedicationEntity>? MedicationsCollection { get; set; }
        public ICollection<MoodEntity>? MoodsCollection { get; set; }
    }
}
