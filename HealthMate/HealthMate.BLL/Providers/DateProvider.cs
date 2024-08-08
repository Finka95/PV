using HealthMate.BLL.Abstractions;

namespace HealthMate.BLL.Providers
{
    public class DateProvider : IDateProvider
    {
        public DateTime ConvertToUtc(DateTime date)
        {
            return date.ToUniversalTime();
        }
    }
}
