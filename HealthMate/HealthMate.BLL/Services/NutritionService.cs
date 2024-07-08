using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class NutritionService(INutritionRepository nutritionRepository, IMapper mapper)
        : ModelWithNotesAndDateService<NutritionEntity, Nutrition>(nutritionRepository, mapper), INutritionService
    {
        public new async Task<Nutrition> UpdateAsync(Guid id, Nutrition model, CancellationToken token)
        {
            _ = await nutritionRepository.GetByIdAsync(id, token) ??
                throw new NotFoundException($"Entity with id: {id} not found.");

            var nutritionEntity = mapper.Map<NutritionEntity>(model);

            nutritionEntity.Id = id;

            nutritionEntity.Calories = 0;

            foreach (var foodItem in nutritionEntity.FoodItems)
            {
                foodItem.Calories = CalculateCalories(foodItem);

                nutritionEntity.Calories += foodItem.Calories;
            }

            await nutritionRepository.UpdateAsync(nutritionEntity, token);

            return mapper.Map<Nutrition>(nutritionEntity);
        }

        public new async Task<Nutrition> CreateAsync(Nutrition model, CancellationToken token)
        {
            var nutritionEntity = mapper.Map<NutritionEntity>(model);

            nutritionEntity.Calories = 0;

            foreach (var foodItem in nutritionEntity.FoodItems)
            {
                foodItem.Calories = CalculateCalories(foodItem);

                nutritionEntity.Calories += foodItem.Calories;
            }

            await nutritionRepository.CreateAsync(nutritionEntity, token);

            return mapper.Map<Nutrition>(nutritionEntity);
        }

        private int CalculateCalories(FoodItemEntity foodItem)
        {
            double protein = (foodItem.Protein / 100) * foodItem.Quantity;
            double fat = (foodItem.Fat / 100) * foodItem.Quantity;
            double carbohydrates = (foodItem.Carbohydrates / 100) * foodItem.Quantity;

            return (int)(protein * 4 + fat * 9 + carbohydrates * 4);
        }
    }
}
