using AutoMapper;
using HealthMate.API.Abstractions;
using HealthMate.BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenericController<TModel, TDto, TShortDto>(IGenericService<TModel> service, IMapper mapper)
        : ControllerBase, IGenericController<TDto, TShortDto>
        where TModel : BaseModel
        where TDto : BaseViewModel
        where TShortDto : class
    {
        [HttpGet("{id:guid}", Name = "GetById")]
        public async Task<TDto?> GetByIdAsync(Guid id, CancellationToken token)
        {
            var resultModel = await service.GetByIdAsync(id, token);

            return mapper.Map<TDto>(resultModel);
        }

        [HttpGet]
        public async Task<ICollection<TDto>?> GetAllAsync(CancellationToken token)
        {
            var resultModel = await service.GetAllAsync(token);

            return mapper.Map<List<TDto>>(resultModel);
        }

        [HttpPut("{id:guid}")]
        public async Task<TDto> UpdateAsync(Guid id, TShortDto dto, CancellationToken token)
        {
            var model = mapper.Map<TModel>(dto);

            var resultModel = await service.UpdateAsync(id, model, token);

            return mapper.Map<TDto>(resultModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task DeleteAsync(Guid id, CancellationToken token)
        {
            await service.DeleteAsync(id, token);
        }

        [HttpPost]
        public async Task<TDto> CreateAsync(TShortDto dto, CancellationToken token)
        {
            var model = mapper.Map<TModel>(dto);

            var resultModel = await service.CreateAsync(model, token);

            return mapper.Map<TDto>(resultModel);
        }
    }
}
