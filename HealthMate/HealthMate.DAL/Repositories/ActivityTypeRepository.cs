using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Repositories
{
    public class ActivityTypeRepository(ApplicationDbContext context)
        : GenericRepository<ActivityTypeEntity>(context), IActivityTypeRepository
    {
    }
}
