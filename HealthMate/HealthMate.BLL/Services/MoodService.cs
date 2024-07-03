using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;
using HealthMate.DAL.Repositories;

namespace HealthMate.BLL.Services
{
    public class MoodService(IMoodRepository moodRepository, IMapper mapper)
        : ModelWithNotesAndDateService<MoodEntity, Mood>(moodRepository, mapper), IMoodService
    {
        public new async Task<Mood> CreateAsync(Mood model, CancellationToken token)
        {
            var moodCollection = await moodRepository.GetByDate(model.UserId, model.Date, token);

            if (moodCollection.Count > 0)
                throw new SingletonInstanceCreationException();

            var entity = mapper.Map<MoodEntity>(model);

            await moodRepository.CreateAsync(entity, token);

            return mapper.Map<Mood>(entity);
        }
    }
}
