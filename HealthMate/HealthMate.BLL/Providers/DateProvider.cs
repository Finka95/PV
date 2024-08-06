using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Providers
{
    public class DateProvider : IDateProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
