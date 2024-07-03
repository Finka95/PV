namespace HealthMate.DAL.Abstractions
{
    public interface IModelWithNotesAndDateRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate
    {
        Task<ICollection<TEntity>> GetByDate(Guid userId,
            DateOnly data,
            CancellationToken token);
        Task<ICollection<TEntity>> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
