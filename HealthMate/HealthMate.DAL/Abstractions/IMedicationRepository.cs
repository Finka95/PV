using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMedicationRepository : IModelWithNotesAndDateRepository<MedicationEntity>
    {
    }
}
