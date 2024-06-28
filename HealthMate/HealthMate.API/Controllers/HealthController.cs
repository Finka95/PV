using AutoMapper;
using HealthMate.API.ViewModels.Health;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController
        (IHealthService healthService, IMapper mapper)
        : ModelWithNotesAndDateController<Health, HealthViewModel, ShortHealthViewModel>(healthService, mapper)
    {
    }
}
