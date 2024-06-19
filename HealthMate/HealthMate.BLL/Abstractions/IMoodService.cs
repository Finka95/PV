using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IMoodService : IGenericService<Mood>
    {
        public Task<Mood?> GetMoodByDate(DateOnly date, CancellationToken token);
        public Task<ICollection<Mood>?> GetMoodsBetweenTwoDates(DateOnly startDate, DateOnly finishDate, CancellationToken token);
    }
}
