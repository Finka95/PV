﻿namespace HealthMate.BLL.Abstractions
{
    public interface IGenericService<TModel> where TModel : class, IBaseModel
    {
        Task<TModel?> GetByIdAsync(Guid id, CancellationToken token);
        Task<ICollection<TModel>> GetAllAsync(CancellationToken token);
        Task<TModel> UpdateAsync(Guid id, TModel model, CancellationToken token);
        Task DeleteAsync(Guid id, CancellationToken token);
        Task<TModel> CreateAsync(TModel model, CancellationToken token);
    }
}
