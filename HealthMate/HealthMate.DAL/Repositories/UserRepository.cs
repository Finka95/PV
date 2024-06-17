using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class UserRepository(ApplicationDbContext context)
        : GenericRepository<User>(context), IUserRepository
    {
        public new async Task<ICollection<User>> GetAllAsync(CancellationToken token) =>
            await DbSet
                .Include(u => u.Gender)
                .Include(u => u.HealthCollection)
                .Include(u => u.ActivityCollection)
                .Include(u => u.NutritionCollection)
                .Include(u => u.MedicationsCollection)
                .Include(u => u.MoodsCollection)
                .ToListAsync(token);

        public new async Task<User?> GetByIdAsync(Guid id, CancellationToken token) =>
            await DbSet
                .Where(u => u.Id == id)
                .Include(u => u.Gender)
                .Include(u => u.HealthCollection)
                .Include(u => u.ActivityCollection)
                .Include(u => u.NutritionCollection)
                .Include(u => u.MedicationsCollection)
                .Include(u => u.MoodsCollection)
                .SingleOrDefaultAsync(token);
    }
}
