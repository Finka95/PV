using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMoodRepository : IGenericRepository<MoodEntity>
    {
        public Task<MoodEntity?> GetMoodByDate(DateOnly data,
            CancellationToken token);
        public Task<ICollection<MoodEntity>> GetMoodsBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
