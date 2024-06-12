namespace HealthMate.API.DTO.Models
{
    public record UserDTO(
        Guid Id,
        string Name,
        string UserName,
        string Email,
        DateTime DateOfBirth,
        GenderDTO Gender,
        double Height,
        double Weight,

        ICollection<HealthDTO>? HealthCollection,
        ICollection<ActivityDTO>? ActivityCollection,
        ICollection<NutritionDTO>? NutritionCollection,
        ICollection<MedicationDTO>? MedicationsCollection,
        ICollection<MoodDTO>? MoodsCollection
    );
}
