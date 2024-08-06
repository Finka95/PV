using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMedicationRepository : IModelWithNotesAndDateRepository<MedicationEntity>
    {
        Task<ICollection<MedicationEntity>> GetMedicationsByDateOfUse(Guid userId, DateTime date, CancellationToken token);
    }
}
