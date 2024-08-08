namespace HealthMate.API.Abstractions
{
    public interface IModelWithNotesAndDateController<TViewModel, TShorViewModel>
        : IGenericController<TViewModel, TShorViewModel>
        where TViewModel : class
        where TShorViewModel : class
    {
        Task<ICollection<TViewModel>> GetByDate(Guid userId,
            DateTime date,
            CancellationToken token);

        Task<ICollection<TViewModel>> GetBetweenTwoDates(Guid userId,
            DateTime startDate,
            DateTime finishDate,
            CancellationToken token);
    }
}
