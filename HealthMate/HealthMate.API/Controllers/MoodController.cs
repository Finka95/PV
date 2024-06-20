using AutoMapper;
using HealthMate.API.ViewModels.Mood;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MoodController(IMoodService moodService, IMapper mapper)
    : GenericController<Mood, MoodViewModel, ShortMoodViewModel>(moodService, mapper)
    {
        [HttpGet(Name = "MoodByDate")]
        public async Task<MoodViewModel> GetMoodByDate([FromQuery] DateOnly date, CancellationToken token)
        {
            var mood = await moodService.GetMoodByDate(date, token);

            return mapper.Map<MoodViewModel>(mood);
        }

        [HttpGet]
        public async Task<ICollection<MoodViewModel>> GetMoodsBetweenTwoDates([FromQuery] DateOnly startDate,
            [FromQuery] DateOnly finishDate,
            CancellationToken token)
        {
            var moods = await moodService.GetMoodsBetweenTwoDates(startDate, finishDate, token);

            return mapper.Map<ICollection<MoodViewModel>>(moods);
        }
    }
}
