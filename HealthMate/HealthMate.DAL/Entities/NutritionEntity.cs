using HealthMate.DAL.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Entities
{
    public class NutritionEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public required UserEntity User { get; set; }

        [Column(TypeName = "int")]
        public MealType MealType { get; set; }
        public ICollection<FoodItemEntity>? FoodItems { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public ICollection<NoteEntity>? Notes { get; set; }
    }
}
