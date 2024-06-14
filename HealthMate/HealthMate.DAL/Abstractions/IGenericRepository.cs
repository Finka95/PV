namespace HealthMate.DAL.Abstractions
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public Task<TEntity?> GetByIdAsync(Guid id, CancellationToken token);
        public Task<ICollection<TEntity>> GetAllAsync(CancellationToken token);
        public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token);
        public Task DeleteAsync(Guid id, CancellationToken token);
        public Task<TEntity> CreateAsync(TEntity entity, CancellationToken token);
    }
}
