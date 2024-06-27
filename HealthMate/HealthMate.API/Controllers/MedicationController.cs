using AutoMapper;
using HealthMate.API.ViewModels.Medication;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicationController(IMedicationService medicationService, IMapper mapper)
        : ModelWithNotesAndDateController<Medication, MedicationViewModel, ShortMedicationViewModel>(medicationService, mapper)
    {
        [HttpGet("between-start-and-end-dates")]
        public async Task<ICollection<MedicationViewModel>> GetMedicationsByDateOfUse([FromQuery] DateOnly date,
            CancellationToken token)
        {
            var medicationCollection = await medicationService
                .GetMedicationsByDateOfUse(date, token);

            return mapper.Map<ICollection<MedicationViewModel>>(medicationCollection);
        }
    }
}
