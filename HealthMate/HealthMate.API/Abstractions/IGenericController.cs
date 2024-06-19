namespace HealthMate.API.Abstractions
{
    public interface IGenericController<TDto, TShorDto>
    {
        Task<TDto?> GetByIdAsync(Guid id, CancellationToken token);
        Task<ICollection<TDto>?> GetAllAsync(CancellationToken token);
        Task<TDto> UpdateAsync(Guid id, TShorDto model, CancellationToken token);
        Task DeleteAsync(Guid id, CancellationToken token);
        Task<TDto> CreateAsync(TShorDto model, CancellationToken token);
    }
}
