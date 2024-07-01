﻿using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.DAL.Abstractions;

namespace HealthMate.BLL.Services
{
    public class GenericService<TEntity, TModel>(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        : IGenericService<TModel>
        where TEntity : class, IBaseEntity
        where TModel : class, IBaseModel
    {
        public async Task<TModel?> GetByIdAsync(Guid id, CancellationToken token)
        {
            var entity = await genericRepository.GetByIdAsync(id, token) ??
                         throw new NotFoundException($"Entity with id: {id} not found.");

            return mapper.Map<TModel>(entity);
        }

        public async Task<ICollection<TModel>> GetAllAsync(CancellationToken token)
        {
            var entityCollection = await genericRepository.GetAllAsync(token);

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }

        public async Task<TModel> UpdateAsync(Guid id, TModel model, CancellationToken token)
        {
            _ = await genericRepository.GetByIdAsync(id, token) ??
                throw new NotFoundException($"Entity with id: {id} not found.");

            var entity = mapper.Map<TEntity>(model);

            entity.Id = id;

            var updateEntity = await genericRepository.UpdateAsync(entity, token);

            return mapper.Map<TModel>(updateEntity);
        }

        public async Task DeleteAsync(Guid id, CancellationToken token)
        {
            _ = await genericRepository.GetByIdAsync(id, token) ??
                throw new NotFoundException($"Entity with id: {id} not found.");

            await genericRepository.DeleteAsync(id, token);
        }

        public async Task<TModel> CreateAsync(TModel model, CancellationToken token)
        {
            var entity = mapper.Map<TEntity>(model);

            await genericRepository.CreateAsync(entity, token);

            return mapper.Map<TModel>(entity);
        }
    }
}
