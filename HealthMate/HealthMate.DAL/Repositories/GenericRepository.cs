﻿using HealthMate.DAL.Abstractions;
using HealthMate.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.Repositories
{
    public class GenericRepository<TEntity>(ApplicationDbContext context) : IGenericRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext Context = context;
        protected readonly DbSet<TEntity> DbSet = context.Set<TEntity>();

        public async Task<TEntity?> GetByIdAsync(Guid id,
            CancellationToken token) =>
            await DbSet
                .Where(t => t.Id.Equals(id))
                .SingleOrDefaultAsync(token);

        public async Task<ICollection<TEntity>> GetAllAsync(CancellationToken token) =>
            await DbSet
                .ToListAsync(token);

        public async Task<TEntity> UpdateAsync(TEntity entity,
            CancellationToken token)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync(token);
            return entity;
        }

        public async Task DeleteAsync(Guid id,
            CancellationToken token)
        {
            var entity = await DbSet
                .Where(t => t.Id.Equals(id))
                .SingleOrDefaultAsync(token);

            if (entity != null)
            {
                DbSet.Remove(entity);

                await Context.SaveChangesAsync(token);
            }
        }

        public async Task<TEntity> CreateAsync(TEntity entity,
            CancellationToken token)
        {
            DbSet.Add(entity);
            await Context.SaveChangesAsync(token);
            return entity;
        }
    }
}
