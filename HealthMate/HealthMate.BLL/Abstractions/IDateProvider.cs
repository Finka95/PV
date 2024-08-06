namespace HealthMate.BLL.Abstractions
{
    public interface IDateProvider
    {
        DateTime UtcNow { get; }
    }
}
