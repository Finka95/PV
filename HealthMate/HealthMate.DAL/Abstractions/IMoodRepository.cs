using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMoodRepository : IGenericRepository<MoodEntity>
    {
        Task<MoodEntity?> GetMoodByDate(DateOnly data,
            CancellationToken token);
        Task<ICollection<MoodEntity>> GetMoodsBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
