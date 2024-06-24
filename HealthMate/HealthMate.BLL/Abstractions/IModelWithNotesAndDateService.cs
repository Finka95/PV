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

        Task<TModel> AddNote(Guid noteId,
            Note noteModel,
            CancellationToken token);

        Task RemoveNote(Guid modelId,
            Guid noteId,
            CancellationToken token);

        Task<TModel> UpdateNote(Guid modelId,
            Note noteModel,
            Guid noteId,
            CancellationToken token);
    }
}
