namespace HealthMate.API.DTO.Models
{
    public record FoodItemDTO(
        Guid Id,
        string Name,
        double Quantity,
        int Calories,
        double Protein,
        double Fat,
        double Carbohydrates,
        ICollection<NoteDTO>? Notes
    );
}
