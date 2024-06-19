using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class MoodRepository(ApplicationDbContext context)
        : GenericRepository<MoodEntity>(context), IMoodRepository
    {
        public async Task<MoodEntity?> GetMoodByDate(DateOnly data,
            CancellationToken token) =>
            await DbSet
                .Where(m => m.Date == data)
                .Include(m => m.Notes)
                .SingleOrDefaultAsync(token);

        public async Task<ICollection<MoodEntity>> GetMoodsBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token) =>
            await DbSet
                .Where(m => m.Date > startDate && m.Date < finishDate)
                .Include(m => m.Notes)
                .ToListAsync(token);
    }
}
