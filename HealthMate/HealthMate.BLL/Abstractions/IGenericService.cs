namespace HealthMate.BLL.Abstractions
{
    public interface IGenericService<TModel>
    {
        public Task<TModel?> GetByIdAsync(Guid id, CancellationToken token);
        public Task<ICollection<TModel>> GetAllAsync(CancellationToken token);
        public Task<TModel> UpdateAsync(Guid id, TModel model, CancellationToken token);
        public Task DeleteAsync(Guid id, CancellationToken token);
        public Task<TModel> CreateAsync(TModel model, CancellationToken token);
    }
}
