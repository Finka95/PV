using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Enums;

namespace HealthMate.BLL.Models
{
    public class Nutrition : IBaseModel, IBaseModelWithNotesAndDate
    {
        public Guid Id { get; set; } 
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public MealType MealType { get; set; }
        public int Calories { get; set; }
        public List<FoodItem> FoodItems { get; set; } 
        public DateTime Date { get; set; }
        public List<Note> Notes { get; set; } 
    }
}
