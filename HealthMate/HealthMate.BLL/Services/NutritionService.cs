﻿using AutoMapper;
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
                nutritionEntity.Calories += foodItem.Calories;
            }

            await nutritionRepository.UpdateAsync(nutritionEntity, token);

            return mapper.Map<Nutrition>(nutritionEntity);
        }

        public async Task<Nutrition> AddFoodItem(Guid nutritionId, FoodItem foodItemModel, CancellationToken token)
        {
            var foodItemEntity = mapper.Map<FoodItemEntity>(foodItemModel);

            var nutritionEntity = await nutritionRepository.GetByIdAsync(nutritionId, token) ??
                              throw new NotFoundException($"Entity with id: {nutritionId} not found.");

            nutritionEntity.FoodItems.Add(foodItemEntity);

            foodItemEntity.Calories = CalculateCalories(foodItemEntity);

            nutritionEntity.Calories += foodItemEntity.Calories;

            await nutritionRepository.UpdateAsync(nutritionEntity, token);

            return mapper.Map<Nutrition>(nutritionEntity);
        }

        public async Task RemoveFoodItem(Guid nutritionId, Guid foodItemId, CancellationToken token)
        {
            var nutritionEntity = await nutritionRepository.GetByIdAsync(nutritionId, token) ??
                                  throw new NotFoundException($"Entity with id: {nutritionId} not found.");

            var foodItemEntity = await nutritionRepository.GetFoodItem(foodItemId, token) ??
                             throw new NotFoundException($"FoodItem with id: {foodItemId} not found.");

            nutritionEntity.Calories -= foodItemEntity.Calories;

            nutritionEntity.FoodItems.Remove(foodItemEntity);

            await nutritionRepository.UpdateAsync(nutritionEntity, token);
        }

        public async Task<Nutrition> UpdateFoodItem(Guid nutritionId, FoodItem foodItemModel, Guid foodItemId, CancellationToken token)
        {
            var nutritionEntity = await nutritionRepository.GetByIdAsync(nutritionId, token) ??
                                  throw new NotFoundException($"Entity with id: {nutritionId} not found.");

            var foodItemEntity = await nutritionRepository.GetFoodItem(foodItemId, token) ??
                                 throw new NotFoundException($"FoodItem with id: {foodItemId} not found.");

            nutritionEntity.Calories -= foodItemEntity.Calories;

            foodItemEntity = mapper.Map<FoodItemEntity>(foodItemModel);

            foodItemEntity.Calories = CalculateCalories(foodItemEntity);

            nutritionEntity.Calories += foodItemEntity.Calories;

            foodItemEntity.Id = foodItemId;

            await nutritionRepository.UpdateAsync(nutritionEntity, token);

            return mapper.Map<Nutrition>(nutritionEntity);
        }

        private int CalculateCalories(FoodItemEntity foodItem)
        {
            double protein = (foodItem.Protein / 100) * foodItem.Quantity;
            double fat = (foodItem.Fat / 100) * foodItem.Quantity;
            double carbohydrates = (foodItem.Carbohydrates / 100) * foodItem.Carbohydrates;

            return (int)(protein * 4 + fat * 9 + carbohydrates * 4);
        }
    }
}
