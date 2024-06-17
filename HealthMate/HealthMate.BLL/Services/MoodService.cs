using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class MoodService(IMoodRepository moodRepository, IMapper mapper)
        : GenericService<Mood, Models.Mood>(moodRepository, mapper), IMoodService
    {
        public async Task<Models.Mood?> GetMoodByDate(DateTime date, CancellationToken token)
        {
            var moodEntity = await moodRepository.GetMoodByDate(date, token);

            return mapper.Map<Models.Mood>(moodEntity);
        }

        public async Task<ICollection<Models.Mood>?> GetMoodsBetweenTwoDates(DateTime startDate,
            DateTime finishDate,
            CancellationToken token)
        {
            var moodEntityCollection = await moodRepository.GetMoodsBetweenTwoDates(startDate, finishDate, token);

            return mapper.Map<ICollection<Models.Mood>>(moodEntityCollection);
        }
    }
}
