using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class MedicationService(IMedicationRepository medicationRepository, IMapper mapper)
        : ModelWithNotesAndDateService<MedicationEntity, Medication>(medicationRepository, mapper), IMedicationService
    {
        public async Task<ICollection<Medication>> GetMedicationsByDateOfUse(Guid userId,
            DateOnly date,
            CancellationToken token)
        {
            var medicationCollection = await medicationRepository
                .GetMedicationsByDateOfUse(userId, date, token);

            return mapper.Map<ICollection<Medication>>(medicationCollection);
        }
    }
}
