using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class ModelWithNotesAndDateService<TEntity, TModel>
        (IModelWithNotesAndDateRepository<TEntity> modelWithNotesAndDateRepository, IMapper mapper)
        : GenericService<TEntity, TModel>(modelWithNotesAndDateRepository, mapper), IModelWithNotesAndDateService<TModel>
        where TEntity : BaseEntityWithNotesAndDate
        where TModel : BaseModelWithNotesAndDate
    {
        public async Task<TModel?> GetByDate(DateOnly date,
            CancellationToken token)
        {
            var entity = await modelWithNotesAndDateRepository
                .GetByDate(date, token);

            return mapper.Map<TModel>(entity);
        }

        public async Task<ICollection<TModel>?> GetBetweenTwoDates(DateOnly startDate,
            DateOnly finishDate,
            CancellationToken token)
        {
            var entityCollection = await modelWithNotesAndDateRepository
                .GetBetweenTwoDates(startDate, finishDate, token);

            return mapper.Map<ICollection<TModel>>(entityCollection);
        }

        public async Task<TModel> AddNote(Guid id,
            Note noteModel,
            CancellationToken token)
        {
            var noteEntity = mapper.Map<NoteEntity>(noteModel);

            var modelEntity = await modelWithNotesAndDateRepository.GetByIdAsync(id, token) ??
                              throw new NotFoundException($"Entity with id: {id} not found.");

            modelEntity.Notes.Add(noteEntity);

            await modelWithNotesAndDateRepository.UpdateAsync(modelEntity, token);

            return mapper.Map<TModel>(modelEntity);
        }

        public async Task RemoveNote(Guid modelId, Guid noteId, CancellationToken token)
        {
            var modelEntity = await modelWithNotesAndDateRepository.GetByIdAsync(modelId, token) ??
                              throw new NotFoundException($"Entity with id: {modelId} not found.");

            var noteEntity = await modelWithNotesAndDateRepository.GetNote(noteId, token) ??
                             throw new NotFoundException($"Note with id: {noteId} not found.");

            modelEntity.Notes.Remove(noteEntity);

            await modelWithNotesAndDateRepository.UpdateAsync(modelEntity, token);
        }

        public async Task<TModel> UpdateNote(Guid modelId, Note noteModel, Guid noteId, CancellationToken token)
        {
            var modelEntity = await modelWithNotesAndDateRepository.GetByIdAsync(modelId, token) ??
                              throw new NotFoundException($"Entity with id: {modelId} not found.");

            _ = await modelWithNotesAndDateRepository.GetNote(noteId, token) ??
                             throw new NotFoundException($"Note with id: {noteId} not found.");

            var noteEntity = mapper.Map<NoteEntity>(noteModel);

            noteEntity.Id = noteId;

            await modelWithNotesAndDateRepository.UpdateAsync(modelEntity, token);

            return mapper.Map<TModel>(modelEntity);
        }
    }
}
