﻿using HealthMate.API.ViewModels.Note;

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
    }
}
