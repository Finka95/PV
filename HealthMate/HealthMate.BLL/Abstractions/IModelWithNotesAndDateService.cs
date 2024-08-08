namespace HealthMate.BLL.Abstractions
{
    public interface IModelWithNotesAndDateService<TModel>
        : IGenericService<TModel>
        where TModel : class, IBaseModel, IBaseModelWithNotesAndDate
    {
        Task<ICollection<TModel>> GetByDate(Guid userId,
            DateTime date,
            CancellationToken token);

        Task<ICollection<TModel>?> GetBetweenTwoDates(Guid userId,
            DateTime startDate,
            DateTime finishDate,
            CancellationToken token);
    }
}
