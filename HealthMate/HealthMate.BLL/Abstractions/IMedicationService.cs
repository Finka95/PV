using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IMedicationService : IGenericService<Medication>
    {
        Task<ICollection<Medication>> GetByDate(DateOnly date, CancellationToken token);
    }
}
