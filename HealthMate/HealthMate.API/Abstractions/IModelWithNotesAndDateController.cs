namespace HealthMate.API.Abstractions
{
    public interface IModelWithNotesAndDateController<TViewModel, TShorViewModel>
        : IGenericController<TViewModel, TShorViewModel>
        where TViewModel : class
        where TShorViewModel : class
    {
        Task<ICollection<TViewModel>> GetByDate(Guid userId,
            DateOnly date,
            CancellationToken token);

        Task<ICollection<TViewModel>> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
