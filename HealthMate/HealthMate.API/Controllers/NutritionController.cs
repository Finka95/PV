using AutoMapper;
using HealthMate.API.ViewModels.FoodItem;
using HealthMate.API.ViewModels.Nutrition;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionController(INutritionService nutritionService, IMapper mapper)
        : ModelWithNotesAndDateController<Nutrition, NutritionViewModel, ShortNutritionViewModel>(nutritionService, mapper)
    {
        [HttpPost("foodItem/{nutritionId:guid}")]
        public async Task<NutritionViewModel> AddFoodItem(Guid nutritionId,
            ShortFoodItemViewModel foodItemViewModel,
            CancellationToken token)
        {
            var foodItemModel = mapper.Map<FoodItem>(foodItemViewModel);

            var nutritionModel = await nutritionService.AddFoodItem(nutritionId, foodItemModel, token);

            return mapper.Map<NutritionViewModel>(nutritionModel);
        }

        [HttpDelete("{nutritionId:guid}/foodItem/{foodItemId:guid}")]
        public async Task RemoveFoodItem(Guid nutritionId, Guid foodItemId, CancellationToken token)
        {
            await nutritionService.RemoveFoodItem(nutritionId, foodItemId, token);
        }

        [HttpPut("{modelId:guid}/foodItem/{noteId:guid}")]
        public async Task<NutritionViewModel> UpdateNutrition(Guid nutritionId,
            ShortFoodItemViewModel foodItemViewModel,
            Guid foodItemId,
            CancellationToken token)
        {
            var foodItemModel = mapper.Map<FoodItem>(foodItemViewModel);

            var nutritionModel = await nutritionService.UpdateFoodItem(nutritionId, foodItemModel, foodItemId, token);

            return mapper.Map<NutritionViewModel>(nutritionModel);
        }
    }
}
