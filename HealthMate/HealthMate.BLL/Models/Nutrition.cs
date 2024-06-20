using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.BLL.Models
{
    public class Nutrition : BaseModelWithNotesAndDate
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public MealType MealType { get; set; }
        public int Calories { get; set; }
        public List<FoodItem> FoodItems { get; set; } = new();
    }
}
