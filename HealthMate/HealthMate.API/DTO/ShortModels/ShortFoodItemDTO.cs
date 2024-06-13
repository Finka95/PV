namespace HealthMate.API.DTO.ShortModels
{
    public record ShortFoodItemDTO(
        string Name,
        double Quantity,
        int Calories,
        double Protein,
        double Fat,
        double Carbohydrates,
        ICollection<ShortNoteDTO>? Notes
    );
}
