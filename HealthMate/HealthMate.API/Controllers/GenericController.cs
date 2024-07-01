using AutoMapper;
using HealthMate.API.Abstractions;
using HealthMate.BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<TModel, TViewModel, TShortViewModel>(IGenericService<TModel> service, IMapper mapper)
        : ControllerBase, IGenericController<TViewModel, TShortViewModel>
        where TModel : class, IBaseModel
        where TViewModel : class, IBaseViewModel
        where TShortViewModel : class
    {
        [HttpGet("{id:guid}")]
        public async Task<TViewModel?> GetByIdAsync(Guid id, CancellationToken token)
        {
            var resultModel = await service.GetByIdAsync(id, token);

            return mapper.Map<TViewModel>(resultModel);
        }

        [HttpGet]
        public async Task<ICollection<TViewModel>?> GetAllAsync(CancellationToken token)
        {
            var resultModel = await service.GetAllAsync(token);

            return mapper.Map<List<TViewModel>>(resultModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<TViewModel> UpdateAsync(Guid id, TShortViewModel dto, CancellationToken token)
        {
            var model = mapper.Map<TModel>(dto);

            var resultModel = await service.UpdateAsync(id, model, token);

            return mapper.Map<TViewModel>(resultModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task DeleteAsync(Guid id, CancellationToken token)
        {
            await service.DeleteAsync(id, token);
        }

        [HttpPost]
        public async Task<TViewModel> CreateAsync(TShortViewModel dto, CancellationToken token)
        {
            var model = mapper.Map<TModel>(dto);

            var resultModel = await service.CreateAsync(model, token);

            return mapper.Map<TViewModel>(resultModel);
        }
    }
}
