using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class MedicationRepository(ApplicationDbContext context)
        : GenericRepository<MedicationEntity>(context), IMedicationRepository
    {
        public async Task<ICollection<MedicationEntity>> GetByDate(DateOnly date, CancellationToken token) =>
            await DbSet.Where(m => date > m.StartDate && date < m.EndDate)
                .Include(m => m.Notes)
                .ToListAsync(token);
    }
}
