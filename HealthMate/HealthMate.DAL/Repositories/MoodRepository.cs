using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    internal class MoodRepository(ApplicationDbContext context)
        : GenericRepository<Mood>(context), IMoodRepository
    {
        public async Task<Mood?> GetMoodByDate(DateTime data,
            CancellationToken token) =>
            await context.Set<Mood>()
                .Where(m => m.Date == data)
                .Include(m => m.Notes)
                .SingleOrDefaultAsync(token);

        public async Task<ICollection<Mood>> GetMoodsBetweenTwoDates(DateTime startDate,
            DateTime finishDate,
            CancellationToken token) =>
            await context.Set<Mood>()
                .Where(m => m.Date > startDate && m.Date < finishDate)
                .Include(m => m.Notes)
                .ToListAsync(token);
    }
}
