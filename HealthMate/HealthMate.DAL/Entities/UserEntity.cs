using HealthMate.DAL.Abstractions;

namespace HealthMate.DAL.Entities
{
    public class UserEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string UserName { get; set; } = string.Empty;
        public required string Email { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; } = new();
        public Guid GenderId { get; set; }
        public GenderEntity? Gender { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public List<HealthEntity> HealthCollection { get; set; } = new();
        public List<ActivityEntity> ActivityCollection { get; set; } = new();
        public List<NutritionEntity> NutritionCollection { get; set; } = new();
        public List<MedicationEntity> MedicationsCollection { get; set; } = new();
        public List<MoodEntity> MoodsCollection { get; set; } = new();
    }
}
