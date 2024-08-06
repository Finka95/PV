namespace HealthMate.DAL.Abstractions
{
    public interface IModelWithNotesAndDateRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate
    {
        Task<ICollection<TEntity>> GetByDate(Guid userId,
            DateTime date,
            CancellationToken token);
        Task<ICollection<TEntity>> GetBetweenTwoDates(Guid userId,
            DateTime startDate,
            DateTime finishDate,
            CancellationToken token);
    }
}
