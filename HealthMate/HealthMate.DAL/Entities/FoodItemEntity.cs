using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class FoodItemEntity : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public double Quantity { get; set; } // Quantity of product (e.g. in grams)
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public List<NoteEntity> Notes { get; set; } = new();
    }
}
