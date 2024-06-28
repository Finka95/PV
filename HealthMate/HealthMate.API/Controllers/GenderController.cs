using AutoMapper;
using HealthMate.API.ViewModels.Gender;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;

namespace HealthMate.API.Controllers
{
    public class GenderController(IGenderService genderService, IMapper mapper)
        : GenericController<Gender, GenderViewModel, ShortGenderViewModel>(genderService, mapper)
    {
    }
}
