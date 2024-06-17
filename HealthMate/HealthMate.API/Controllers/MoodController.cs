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
        public async Task<MoodDTO> GetMoodByDate([FromQuery] DateTime date, CancellationToken token)
        {
            var mood = await moodService.GetMoodByDate(date, token);

            return mapper.Map<MoodDTO>(mood);
        }

        [HttpGet]
        public async Task<ICollection<MoodDTO>> GetMoodsBetweenTwoDates([FromQuery] DateTime startDate,
            [FromQuery] DateTime finishDate,
            CancellationToken token)
        {
            var moods = await moodService.GetMoodsBetweenTwoDates(startDate, finishDate, token);

            return mapper.Map<ICollection<MoodDTO>>(moods);
        }
    }
}
