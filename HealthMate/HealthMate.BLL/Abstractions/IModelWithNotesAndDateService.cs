namespace HealthMate.BLL.Abstractions
{
    public interface IModelWithNotesAndDateService<TModel>
        : IGenericService<TModel>
        where TModel : class, IBaseModel, IBaseModelWithNotesAndDate
    {
        Task<TModel?> GetByDate(Guid userId,
            DateOnly date,
            CancellationToken token);

        Task<ICollection<TModel>?> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
