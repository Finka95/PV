using HealthMate.API.Abstractions;

namespace HealthMate.API.ViewModels.Gender
{
    public class GenderViewModel : IBaseViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
