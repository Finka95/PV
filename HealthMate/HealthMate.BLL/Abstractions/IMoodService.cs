using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IMoodService : IGenericService<Mood>
    {
        Task<Mood?> GetMoodByDate(DateOnly date, CancellationToken token);
        Task<ICollection<Mood>?> GetMoodsBetweenTwoDates(DateOnly startDate, DateOnly finishDate, CancellationToken token);
    }
}
