using AutoMapper;
using HealthMate.API.Abstractions;
using HealthMate.BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelWithNotesAndDateController<TModel, TViewModel, TShorViewModel>
        (IModelWithNotesAndDateService<TModel> modelWithNotesAndDateService, IMapper mapper)
        : GenericController<TModel, TViewModel, TShorViewModel>(modelWithNotesAndDateService, mapper),
            IModelWithNotesAndDateController<TViewModel, TShorViewModel>
        where TModel : class, IBaseModel, IBaseModelWithNotesAndDate
        where TViewModel : class, IBaseViewModel, IBaseViewModelWithNotesAndDate
        where TShorViewModel : class
    {
        [HttpGet("{userId:guid}/by-date")]
        public async Task<TViewModel> GetByDate(Guid userId,
            [FromQuery] DateOnly date,
            CancellationToken token)
        {
            var model = await modelWithNotesAndDateService
                .GetByDate(userId, date, token);

            return mapper.Map<TViewModel>(model);
        }

        [HttpGet("{userId:guid}/between-dates")]
        public async Task<ICollection<TViewModel>> GetBetweenTwoDates(Guid userId,
            [FromQuery] DateOnly startDate,
            [FromQuery] DateOnly finishDate,
            CancellationToken token)
        {
            var models = await modelWithNotesAndDateService
                .GetBetweenTwoDates(userId, startDate, finishDate, token);

            return mapper.Map<ICollection<TViewModel>>(models);
        }
    }
}
