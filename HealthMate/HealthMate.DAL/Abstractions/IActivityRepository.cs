using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IActivityRepository : IModelWithNotesAndDateRepository<ActivityEntity>
    {
    }
}
