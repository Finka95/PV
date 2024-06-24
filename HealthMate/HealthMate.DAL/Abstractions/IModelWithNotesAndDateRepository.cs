using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IModelWithNotesAndDateRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : BaseEntityWithNotesAndDate
    {
        Task<TEntity?> GetByDate(DateOnly data,
            CancellationToken token);
        Task<ICollection<TEntity>> GetBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token);

        Task<NoteEntity?> GetNote(Guid id,
            CancellationToken token);
    }
}
