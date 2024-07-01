using HealthMate.DAL.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;
using HealthMate.DAL.Enums;

namespace HealthMate.DAL.Entities
{
    public class NutritionEntity : IBaseEntity, IBaseEntityWithNotesAndDate, IModelWithUserId
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }

        [Column(TypeName = "int")]
        public MealType MealType { get; set; }
        public int Calories { get; set; }
        public List<FoodItemEntity> FoodItems { get; set; } = new();
        public DateOnly Date { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
