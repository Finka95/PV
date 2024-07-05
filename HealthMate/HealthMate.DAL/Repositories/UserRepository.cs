using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class UserRepository(ApplicationDbContext context)
        : GenericRepository<UserEntity>(context), IUserRepository
    {
        public new async Task<ICollection<UserEntity>> GetAllAsync(CancellationToken token) =>
            await DbSet
                .AsNoTracking()
                .Include(u => u.Gender)
                .ToListAsync(token);

        public new async Task<UserEntity?> GetByIdAsync(Guid id, CancellationToken token) =>
            await DbSet
                .AsNoTracking()
                .Where(u => u.Id == id)
                .Include(u => u.Gender)
                .SingleOrDefaultAsync(token);
    }
}
