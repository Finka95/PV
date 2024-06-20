using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Repositories
{
    public class MoodRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<MoodEntity>(context), IMoodRepository
    {
    }
}
