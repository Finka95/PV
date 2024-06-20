namespace HealthMate.DAL.Abstractions
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken token);
        Task<ICollection<TEntity>> GetAllAsync(CancellationToken token);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token);
        Task DeleteAsync(Guid id, CancellationToken token);
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken token);
    }
}
