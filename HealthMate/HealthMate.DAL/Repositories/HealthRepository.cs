using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Repositories
{
    public class HealthRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<HealthEntity>(context), IHealthRepository
    {
    }
}
