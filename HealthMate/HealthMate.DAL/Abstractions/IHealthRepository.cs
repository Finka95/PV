using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IHealthRepository : IModelWithNotesAndDateRepository<HealthEntity>
    {
    }
}
