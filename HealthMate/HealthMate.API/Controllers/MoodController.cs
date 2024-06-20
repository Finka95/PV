using AutoMapper;
using HealthMate.API.ViewModels.Mood;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MoodController(IMoodService moodService, IMapper mapper)
    : ModelWithNotesAndDateController<Mood, MoodViewModel, ShortMoodViewModel>(moodService, mapper)
    {
    }
}
