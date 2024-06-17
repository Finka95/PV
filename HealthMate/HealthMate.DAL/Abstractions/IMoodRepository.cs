using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMoodRepository : IGenericRepository<Mood>
    {
        public Task<Mood?> GetMoodByDate(DateTime data,
            CancellationToken token);
        public Task<ICollection<Mood>> GetMoodsBetweenTwoDates(DateTime startDate,
            DateTime finishDate,
            CancellationToken token);
    }
}
