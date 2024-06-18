using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMoodRepository : IGenericRepository<MoodEntity>
    {
        public Task<MoodEntity?> GetMoodByDate(DateTime data,
            CancellationToken token);
        public Task<ICollection<MoodEntity>> GetMoodsBetweenTwoDates(DateTime startDate,
            DateTime finishDate,
            CancellationToken token);
    }
}
