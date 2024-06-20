using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.BLL.Models
{
    public class Nutrition : BaseModel
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public MealType MealType { get; set; }
        public int Calories { get; set; }
        public DateOnly Date { get; set; }
        public List<FoodItem> FoodItems { get; set; } = new();
        public List<Note> Notes { get; set; } = new();
    }
}
