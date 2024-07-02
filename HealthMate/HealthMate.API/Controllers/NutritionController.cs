using AutoMapper;
using HealthMate.API.ViewModels.Nutrition;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionController(INutritionService nutritionService, IMapper mapper)
        : ModelWithNotesAndDateController<Nutrition, NutritionViewModel, ShortNutritionViewModel>(nutritionService, mapper)
    {
    }
}
