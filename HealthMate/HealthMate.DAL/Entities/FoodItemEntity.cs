using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class FoodItemEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Quantity { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
    }
}
