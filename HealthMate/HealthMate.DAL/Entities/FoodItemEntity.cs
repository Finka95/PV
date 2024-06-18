using System.ComponentModel.DataAnnotations;
using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class FoodItemEntity : BaseEntity
    {
        [StringLength(255)]
        public required string Name { get; set; }
        public double Quantity { get; set; } // Quantity of product (e.g. in grams)
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public ICollection<NoteEntity>? Notes { get; set; }
    }
}
