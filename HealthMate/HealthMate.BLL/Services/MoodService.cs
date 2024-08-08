using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class MoodService(IMoodRepository moodRepository, IMapper mapper,
        IUserRepository userRepository, IDateProvider dateProvider)
        : ModelWithNotesAndDateService<MoodEntity, Mood>(moodRepository, userRepository,
            mapper, dateProvider), IMoodService
    {
        public new async Task<Mood> CreateAsync(Mood model, CancellationToken token)
        {
            model.Date = dateProvider.ConvertToUtc(model.Date);

            var moodCollection = await moodRepository.GetByDate(model.UserId, model.Date, token);

            if (moodCollection.Count > 0)
                throw new CollectionNotEmptyException();

            var entity = mapper.Map<MoodEntity>(model);

            await moodRepository.CreateAsync(entity, token);

            return mapper.Map<Mood>(entity);
        }
    }
}
