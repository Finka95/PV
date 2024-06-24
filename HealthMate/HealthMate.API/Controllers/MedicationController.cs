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
    }
}
