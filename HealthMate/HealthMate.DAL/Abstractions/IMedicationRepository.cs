using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IMedicationRepository : IGenericRepository<MedicationEntity>
    {
        Task<ICollection<MedicationEntity>> GetByDate(DateOnly date, CancellationToken token);
    }
}
