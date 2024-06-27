using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IMedicationService : IModelWithNotesAndDateService<Medication>
    {
        Task<ICollection<Medication>> GetMedicationsByDateOfUse(DateOnly date, CancellationToken token);
    }
}
