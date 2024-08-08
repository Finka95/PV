using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Abstractions;

namespace HealthMate.BLL.Services
{
    public class ModelWithNotesAndDateService<TEntity, TModel>
        (IModelWithNotesAndDateRepository<TEntity> modelWithNotesAndDateRepository, IUserRepository userRepository,
        IMapper mapper, IDateProvider dateProvider)
        : GenericService<TEntity, TModel>(modelWithNotesAndDateRepository, mapper), IModelWithNotesAndDateService<TModel>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate
        where TModel : class, IBaseModel, IBaseModelWithNotesAndDate
    {
        public async Task<ICollection<TModel>> GetByDate(Guid userId,
            DateTime date,
            CancellationToken token)
        {
            var timeZoneOffsetMinutes = await userRepository.GetTimeZoneOffsetMinutes(userId);

            date = date.Date.AddMinutes(timeZoneOffsetMinutes);

            var entityCollection = await modelWithNotesAndDateRepository
                .GetByDate(userId, date, token);

            foreach (var entity in entityCollection)
            {
                entity.Date = entity.Date.AddMinutes(timeZoneOffsetMinutes);
            }

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }

        public async Task<ICollection<TModel>?> GetBetweenTwoDates(Guid userId,
            DateTime startDate,
            DateTime finishDate,
            CancellationToken token)
        {
            var timeZoneOffsetMinutes = await userRepository.GetTimeZoneOffsetMinutes(userId);

            startDate = startDate.Date.AddMinutes(timeZoneOffsetMinutes);
            finishDate = finishDate.Date.AddMinutes(timeZoneOffsetMinutes);

            var entityCollection = await modelWithNotesAndDateRepository
                .GetBetweenTwoDates(userId, startDate, finishDate, token);

            foreach (var entity in entityCollection)
            {
                entity.Date = entity.Date.AddMinutes(timeZoneOffsetMinutes);
            }

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }

        public new async Task<TModel> CreateAsync(TModel model, CancellationToken token)
        {
            model.Date = dateProvider.ConvertToUtc(model.Date);

            var entity = mapper.Map<TEntity>(model);

            await modelWithNotesAndDateRepository.CreateAsync(entity, token);

            return mapper.Map<TModel>(entity);
        }
    }
}
