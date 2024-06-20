using HealthMate.BLL.Models;

namespace HealthMate.BLL.Abstractions
{
    public interface IModelWithNotesAndDateService<TModel>
        : IGenericService<TModel>
        where TModel : BaseModelWithNotesAndDate
    {
        Task<TModel?> GetByDate(DateOnly date,
            CancellationToken token);

        Task<ICollection<TModel>?> GetBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
