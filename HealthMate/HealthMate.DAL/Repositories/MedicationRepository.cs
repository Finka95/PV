using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class MedicationRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<MedicationEntity>(context), IMedicationRepository
    {
        public async Task<ICollection<MedicationEntity>> GetMedicationsByDateOfUse(Guid userId,
            DateTime date,
            CancellationToken token) =>
            await DbSet
                .Where(m => date >= m.StartDate &&
                date < m.EndDate && m.UserId == userId)
                .AsNoTracking()
                .Include(m => m.Notes)
                .ToListAsync(token);
    }
}
