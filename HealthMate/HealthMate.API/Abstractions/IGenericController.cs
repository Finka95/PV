namespace HealthMate.API.Abstractions
{
    public interface IGenericController<TViewModel, TShorViewModel>
        where TViewModel : class
        where TShorViewModel : class
    {
        Task<TViewModel?> GetByIdAsync(Guid id, CancellationToken token);
        Task<ICollection<TViewModel>?> GetAllAsync(CancellationToken token);
        Task<TViewModel> UpdateAsync(Guid id, TShorViewModel model, CancellationToken token);
        Task DeleteAsync(Guid id, CancellationToken token);
        Task<TViewModel> CreateAsync(TShorViewModel model, CancellationToken token);
    }
}
