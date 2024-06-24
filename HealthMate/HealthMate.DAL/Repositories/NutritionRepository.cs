using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Repositories
{
    public class NutritionRepository(ApplicationDbContext context)
        : ModelWithNotesAndDateRepository<NutritionEntity>(context), INutritionRepository
    {
    }
}
