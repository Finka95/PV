using HealthMate.API.Abstractions;

namespace HealthMate.API.DTO.Models
{
    public record FoodItemDTO(
        string Name,
        double Quantity,
        int Calories,
        double Protein,
        double Fat,
        double Carbohydrates,
        ICollection<NoteDTO>? Notes
    ) : BaseDto;
}
