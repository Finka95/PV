using HealthMate.DAL.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Entities
{
    public class Nutrition : BaseEntity
    {
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
