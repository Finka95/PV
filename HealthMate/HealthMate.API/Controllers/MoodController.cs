using AutoMapper;
using HealthMate.API.DTO.Models;
using HealthMate.API.DTO.ShortModels;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MoodController(IMoodService moodService, IMapper mapper)
    : GenericController<Mood, MoodDTO, ShortMoodDTO>(moodService, mapper)
    {
        [HttpGet(Name = "MoodByDate")]
        public async Task<IActionResult> GetMoodByDate([FromQuery] DateTime date, CancellationToken token)
        {
            var mood = await moodService.GetMoodByDate(date, token);

            var moodDto = mapper.Map<MoodDTO>(mood);

            return Ok(moodDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetMoodsBetweenTwoDates([FromQuery] DateTime startDate,
            [FromQuery] DateTime finishDate,
            CancellationToken token)
        {
            var moods = await moodService.GetMoodsBetweenTwoDates(startDate, finishDate, token);

            var moodsDto = mapper.Map<ICollection<MoodDTO>>(moods);

            return Ok(moodsDto);
        }
    }
}
