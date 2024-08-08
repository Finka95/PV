namespace HealthMate.BLL.Abstractions
{
    public interface IDateProvider
    {
        DateTime ConvertToUtc(DateTime date);
    }
}
