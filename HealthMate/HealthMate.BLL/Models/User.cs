using System.ComponentModel.DataAnnotations;

namespace HealthMate.BLL.Models
{
    public class User
    {
        public required Guid Id { get; set; }

        [StringLength(255)]
        public required string Name { get; set; }

        [StringLength(255)]
        public required string UserName { get; set; }

        [StringLength(255)]
        public required string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
        public Guid GenderId { get; set; }
        public required Gender Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public ICollection<Health>? HealthCollection { get; set; }
        public ICollection<Activity>? ActivityCollection { get; set; }
        public ICollection<Nutrition>? NutritionCollection { get; set; }
        public ICollection<Medication>? MedicationsCollection { get; set; }
        public ICollection<Mood>? MoodsCollection { get; set; }
    }
}
