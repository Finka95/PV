using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.ActivityType
{
    public class ActivityTypeViewModel : IBaseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
