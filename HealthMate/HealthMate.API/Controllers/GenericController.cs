using AutoMapper;
using HealthMate.API.Abstractions;
using HealthMate.BLL.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class GenericController<TModel, TDto, TShortDto>(IGenericService<TModel> service, IMapper mapper)
        : ControllerBase, IGenericController<TShortDto>
        where TModel : class
        where TDto : BaseDto
        where TShortDto : class
    {
        [HttpGet("{id:guid}", Name = "GetById")]
        public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken token)
        {
            var resultModel = await service.GetByIdAsync(id, token);

            var resultDto = mapper.Map<TDto>(resultModel);

            return Ok(resultDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token)
        {
            var resultModel = await service.GetAllAsync(token);

            var resultDtoCollection = mapper.Map<List<TDto>>(resultModel);

            return Ok(resultDtoCollection);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateAsync(Guid id, TShortDto dto, CancellationToken token)
        {
            var model = mapper.Map<TModel>(dto);

            var resultModel = await service.UpdateAsync(id, model, token);

            var resultDto = mapper.Map<TDto>(resultModel);

            return Ok(resultDto);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken token)
        {
            await service.DeleteAsync(id, token);

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(TShortDto dto, CancellationToken token)
        {
            var model = mapper.Map<TModel>(dto);

            var resultModel = await service.CreateAsync(model, token);

            var resultModelDto = mapper.Map<TDto>(resultModel);

            return CreatedAtRoute("GetById", new { id = resultModelDto.Id }, resultModelDto);
        }
    }
}
