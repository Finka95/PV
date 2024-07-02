using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class ActivityRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<ActivityEntity>(context), IActivityRepository
    {
        public new async Task<ICollection<ActivityEntity>> GetAllAsync(CancellationToken token) =>
            await DbSet
                .AsNoTracking()
                .Include(a => a.ActivityType)
                .Include(a => a.Notes)
                .ToListAsync(token);

        public new async Task<ActivityEntity?> GetByIdAsync(Guid id, CancellationToken token) =>
            await DbSet
                .AsNoTracking()
                .Include(a => a.ActivityType)
                .Include(a => a.Notes)
                .Where(a => a.Id == id)
                .SingleOrDefaultAsync(token);
    }
}
