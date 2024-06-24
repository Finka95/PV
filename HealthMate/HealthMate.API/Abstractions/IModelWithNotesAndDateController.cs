using HealthMate.API.ViewModels.Note;

namespace HealthMate.API.Abstractions
{
    public interface IModelWithNotesAndDateController<TViewModel, TShorViewModel>
        : IGenericController<TViewModel, TShorViewModel>
    {
        Task<TViewModel> GetByDate(DateOnly date,
            CancellationToken token);

        Task<ICollection<TViewModel>> GetBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);

        Task<TViewModel> AddNote(Guid id,
            ShortNoteViewModel noteViewModel,
            CancellationToken token);

        Task RemoveNote(Guid modelId,
            Guid noteId,
            CancellationToken token);

        Task<TViewModel> UpdateNote(Guid modelId,
            Guid noteId,
            ShortNoteViewModel shortNoteViewModel,
            CancellationToken token);
    }
}
