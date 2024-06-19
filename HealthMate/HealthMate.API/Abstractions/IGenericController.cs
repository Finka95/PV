namespace HealthMate.API.Abstractions
{
    internal interface IGenericController<TDto, TShorDto>
    {
        public Task<TDto?> GetByIdAsync(Guid id, CancellationToken token);
        public Task<ICollection<TDto>?> GetAllAsync(CancellationToken token);
        public Task<TDto> UpdateAsync(Guid id, TShorDto model, CancellationToken token);
        public Task DeleteAsync(Guid id, CancellationToken token);
        public Task<TDto> CreateAsync(TShorDto model, CancellationToken token);
    }
}
