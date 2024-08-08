using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class MedicationService(IMedicationRepository medicationRepository, IMapper mapper,
        IUserRepository userRepository, IDateProvider dateProvider)
        : ModelWithNotesAndDateService<MedicationEntity, Medication>(medicationRepository, userRepository,
            mapper, dateProvider), IMedicationService
    {
        public async Task<ICollection<Medication>> GetMedicationsByDateOfUse(Guid userId,
            DateTime date,
            CancellationToken token)
        {
            var timeZoneOffsetMinutes = await userRepository.GetTimeZoneOffsetMinutes(userId);

            date = date.Date.AddMinutes(timeZoneOffsetMinutes);

            var medicationCollection = await medicationRepository
                .GetMedicationsByDateOfUse(userId, date, token);

            foreach(var medication in medicationCollection)
            {
                medication.StartDate = medication.StartDate.AddMinutes(timeZoneOffsetMinutes);
                medication.EndDate = medication.EndDate.AddMinutes(timeZoneOffsetMinutes);
            }

            return mapper.Map<ICollection<Medication>>(medicationCollection);
        }
    }
}
