namespace HealthMate.DAL.Abstractions
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        public Task<TEntity?> GetById(Guid id, CancellationToken token);
        public Task<ICollection<TEntity>> GetAll(CancellationToken token);
        public Task<TEntity> Update(TEntity entity, CancellationToken token);
        public Task Delete(Guid id, CancellationToken token);
        public Task<TEntity> Create(TEntity entity, CancellationToken token);
    }
}
