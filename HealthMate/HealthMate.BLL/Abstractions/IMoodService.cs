using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IMoodService : IGenericService<Mood>
    {
        public Task<Mood?> GetMoodByDate(DateTime date, CancellationToken token);
        public Task<ICollection<Mood>?> GetMoodsBetweenTwoDates(DateTime startDate, DateTime finishDate, CancellationToken token);
    }
}
