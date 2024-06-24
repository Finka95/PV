using AutoMapper;
using HealthMate.API.Abstractions;
using HealthMate.API.ViewModels.Note;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelWithNotesAndDateController<TModel, TViewModel, TShorViewModel>
        (IModelWithNotesAndDateService<TModel> modelWithNotesAndDateService, IMapper mapper)
        : GenericController<TModel, TViewModel, TShorViewModel>(modelWithNotesAndDateService, mapper),
            IModelWithNotesAndDateController<TViewModel, TShorViewModel>
        where TModel : BaseModelWithNotesAndDate
        where TViewModel : BaseViewModelWithNotesAndDate
        where TShorViewModel : class
    {
        [HttpGet("by-date")]
        public async Task<TViewModel> GetByDate([FromQuery] DateOnly date,
            CancellationToken token)
        {
            var model = await modelWithNotesAndDateService
                .GetByDate(date, token);

            return mapper.Map<TViewModel>(model);
        }

        [HttpGet("between-dates")]
        public async Task<ICollection<TViewModel>> GetBetweenTwoDates([FromQuery] DateOnly startDate,
            [FromQuery] DateOnly finishDate,
            CancellationToken token)
        {
            var models = await modelWithNotesAndDateService
                .GetBetweenTwoDates(startDate, finishDate, token);

            return mapper.Map<ICollection<TViewModel>>(models);
        }

        [HttpPost("note/{id:guid}")]
        public async Task<TViewModel> AddNote(Guid id,
            ShortNoteViewModel noteViewModel,
            CancellationToken token)
        {
            var note = mapper.Map<Note>(noteViewModel);

            var model = await modelWithNotesAndDateService.AddNote(id, note, token);

            return mapper.Map<TViewModel>(model);
        }

        [HttpDelete("note/{id:guid}")]
        public async Task RemoveNote(Guid modelId, Guid noteId, CancellationToken token)
        {
            await modelWithNotesAndDateService.RemoveNote(modelId, noteId, token);
        }

        [HttpPut("{modelId:guid}/note/{noteId:guid}")]
        public async Task<TViewModel> UpdateNote(Guid modelId,
            Guid noteId,
            ShortNoteViewModel shortNoteViewModel,
            CancellationToken token)
        {
            var noteModel = mapper.Map<Note>(shortNoteViewModel);

            var resultModel = await modelWithNotesAndDateService.UpdateNote(modelId, noteModel, noteId, token);

            return mapper.Map<TViewModel>(resultModel);
        }
    }
}
