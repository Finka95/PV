using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class MedicationService(IMedicationRepository medicationRepository, IMapper mapper)
        : GenericService<MedicationEntity, Medication>(medicationRepository, mapper), IMedicationService
    {
        public async Task<ICollection<Medication>> GetByDate(DateOnly date, CancellationToken token)
        {
            var medicationCollection = await medicationRepository.GetByDate(date, token);

            return mapper.Map<ICollection<Medication>>(medicationCollection);
        }
    }
}
