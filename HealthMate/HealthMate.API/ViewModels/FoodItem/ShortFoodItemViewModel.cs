namespace HealthMate.API.ViewModels.FoodItem
{
    public class ShortFoodItemViewModel 
    {
        public string Name { get; set; } = string.Empty;
        public double Quantity { get; set; }
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
    }
}
