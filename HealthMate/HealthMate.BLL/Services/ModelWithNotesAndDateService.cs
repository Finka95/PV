using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Abstractions;

namespace HealthMate.BLL.Services
{
    public class ModelWithNotesAndDateService<TEntity, TModel>
        (IModelWithNotesAndDateRepository<TEntity> modelWithNotesAndDateRepository, IMapper mapper)
        : GenericService<TEntity, TModel>(modelWithNotesAndDateRepository, mapper), IModelWithNotesAndDateService<TModel>
        where TEntity : BaseEntityWithNotesAndDate
        where TModel : BaseModelWithNotesAndDate
    {
        public async Task<TModel?> GetByDate(DateOnly date,
            CancellationToken token)
        {
            var entity = await modelWithNotesAndDateRepository
                .GetByDate(date, token);

            return mapper.Map<TModel>(entity);
        }

        public async Task<ICollection<TModel>?> GetBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token)
        {
            var entityCollection = await modelWithNotesAndDateRepository
                .GetBetweenTwoDates(startDate, finishDate, token);

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }
    }
}
