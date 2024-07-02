using AutoMapper;
using HealthMate.API.ViewModels.Gender;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController(IGenderService genderService, IMapper mapper)
        : GenericController<Gender, GenderViewModel, ShortGenderViewModel>(genderService, mapper)
    {
    }
}
