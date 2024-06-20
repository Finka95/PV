using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Activity;
using HealthMate.API.ViewModels.Gender;
using HealthMate.API.ViewModels.Health;
using HealthMate.API.ViewModels.Medication;
using HealthMate.API.ViewModels.Mood;
using HealthMate.API.ViewModels.Nutrition;

namespace HealthMate.API.ViewModels.User
{
    public class UserViewModel : BaseViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public GenderViewModel Gender { get; set; } = new();
        public double Height { get; set; }
        public double Weight { get; set; }

        public List<HealthViewModel>? HealthCollection { get; set; } = new();
        public List<ActivityViewModel>? ActivityCollection { get; set; } = new();
        public List<NutritionViewModel>? NutritionCollection { get; set; } = new();
        public List<MedicationViewModel>? MedicationsCollection { get; set; } = new();
        public List<MoodViewModel>? MoodsCollection { get; set; } = new();
    }
}
