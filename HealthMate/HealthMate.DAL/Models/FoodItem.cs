using System.ComponentModel.DataAnnotations;

namespace HealthMate.DAL.Models
{
    public class FoodItem
    {
        public required Guid Id { get; set; }

        [StringLength(255)]
        public required string Name { get; set; }
        public double Quantity { get; set; } // Quantity of product (e.g. in grams)
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public ICollection<Note>? Notes { get; set; }

        public void CalculateNutrients(double quantity)
        {
            double ratio = quantity / Quantity;
            Calories = (int)(Calories * ratio);
            Protein *= ratio;
            Fat *= ratio;
            Carbohydrates *= ratio;
        }
    }
}
