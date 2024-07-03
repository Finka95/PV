using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Abstractions;

namespace HealthMate.BLL.Services
{
    public class ModelWithNotesAndDateService<TEntity, TModel>
        (IModelWithNotesAndDateRepository<TEntity> modelWithNotesAndDateRepository, IMapper mapper)
        : GenericService<TEntity, TModel>(modelWithNotesAndDateRepository, mapper), IModelWithNotesAndDateService<TModel>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate
        where TModel : class, IBaseModel, IBaseModelWithNotesAndDate
    {
        public async Task<ICollection<TModel>> GetByDate(Guid userId,
            DateOnly date,
            CancellationToken token)
        {
            var entityCollection = await modelWithNotesAndDateRepository
                .GetByDate(userId, date, token);

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }

        public async Task<ICollection<TModel>?> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token)
        {
            var entityCollection = await modelWithNotesAndDateRepository
                .GetBetweenTwoDates(userId, startDate, finishDate, token);

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }
    }
}
