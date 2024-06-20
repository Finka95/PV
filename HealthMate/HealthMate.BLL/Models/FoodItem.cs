using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Models
{
    public class FoodItem : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public double Quantity { get; set; } // Quantity of product (e.g. in grams)
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public List<Note> Notes { get; set; } = new();
    }
}
