using HealthMate.DAL.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthMate.DAL.Models
{
    public class Nutrition
    {
        public required Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required User User { get; set; }

        [Column(TypeName = "int")]
        public MealType MealType { get; set; }
        public ICollection<FoodItem>? FoodItems { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Note>? Notes { get; set; }
    }
}
