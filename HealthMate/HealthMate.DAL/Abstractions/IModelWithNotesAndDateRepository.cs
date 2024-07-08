namespace HealthMate.DAL.Abstractions
{
    public interface IModelWithNotesAndDateRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, IBaseEntity, IBaseEntityWithNotesAndDate
    {
        Task<TEntity?> GetByDate(Guid userId,
            DateOnly date,
            CancellationToken token);
        Task<ICollection<TEntity>> GetBetweenTwoDates(Guid userId,
            DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);
    }
}
