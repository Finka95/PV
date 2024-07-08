using AutoFixture;
using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Exceptions;
using HealthMate.BLL.Mappers;
using HealthMate.BLL.Models;
using HealthMate.BLL.Services;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;
using NSubstitute;
using Shouldly;
using Xunit;
using Xunit.Abstractions;

namespace HealthMate.Tests
{
    public class NutritionServiceTests
    {
        private readonly INutritionRepository _nutritionRepository;
        private readonly INutritionService _nutritionService;
        private readonly IMapper _mapper;
        private readonly Fixture _fixture;

        public NutritionServiceTests(ITestOutputHelper testOutputHelper)
        {
            _nutritionRepository = Substitute.For<INutritionRepository>();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperBllProfile());
            }).CreateMapper();

            _nutritionService = new NutritionService(_nutritionRepository, _mapper);

            _fixture = new Fixture();
        }

        [Fact]
        public async Task UpdateAsync_WithValidIdAndModel_ReturnsUpdateModel()
        {
            // Arrange
            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());

            var updatedModel = _fixture.Build<Nutrition>()
                .With(n => n.Date, date)
                .With(n => n.FoodItems, new List<FoodItem>
                {
                    new FoodItem {Protein = 10, Fat = 5, Carbohydrates = 20, Quantity = 100},
                    new FoodItem {Protein = 5, Fat = 10, Carbohydrates = 15, Quantity = 200}
                })
                .With(n => n.User, (User)null)
                .With(m => m.Notes, new List<Note>())
                .Create();

            var existingEntity = _mapper.Map<NutritionEntity>(updatedModel);

           _nutritionRepository.GetByIdAsync(existingEntity.Id, Arg.Any<CancellationToken>())
                .Returns(existingEntity);
            _nutritionRepository.UpdateAsync(Arg.Any<NutritionEntity>(), Arg.Any<CancellationToken>())
                .Returns(x => x.Arg<NutritionEntity>());

            // Act
            var result = await _nutritionService.UpdateAsync(existingEntity.Id, updatedModel, CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(existingEntity.Id);
            result.Date.ShouldBe(updatedModel.Date);
            result.UserId.ShouldBe(updatedModel.UserId);
            result.FoodItems.Count.ShouldBe(updatedModel.FoodItems.Count);
            result.Calories.ShouldBe(505); 

            await _nutritionRepository.Received(1).GetByIdAsync(existingEntity.Id, Arg.Any<CancellationToken>());
            await _nutritionRepository.Received(1)
                .UpdateAsync(Arg.Any<NutritionEntity>(), Arg.Any<CancellationToken>());
        }

        [Fact]
        public async Task UpdateAsync_WithInvalidId_ThrowsNotFoundException()
        {
            //Arrange
            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());

            var model = _fixture.Build<Nutrition>()
                .With(n => n.Date, date)
                .With(n => n.User, (User)null)
                .With(m => m.Notes, new List<Note>())
                .Create();

            _nutritionRepository.GetByIdAsync(model.Id, Arg.Any<CancellationToken>())
                .Returns((NutritionEntity)null);

            //Act 

            var action = () => _nutritionService.DeleteAsync(model.Id, CancellationToken.None);

            //Assert 

            await action.ShouldThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task CreateAsync_WithValidModel_ReturnsCreatedModel()
        {
            // Arrange
            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());

            var model = _fixture.Build<Nutrition>()
                .With(n => n.Date, date)
                .With(n => n.FoodItems, new List<FoodItem>
                {
                    new FoodItem {Protein = 10, Fat = 5, Carbohydrates = 20, Quantity = 100},
                    new FoodItem {Protein = 5, Fat = 10, Carbohydrates = 15, Quantity = 200}
                })
                .With(n => n.User, (User)null)
                .With(m => m.Notes, new List<Note>())
                .Create();

            var entity = _mapper.Map<NutritionEntity>(model);
            _nutritionRepository.CreateAsync(Arg.Any<NutritionEntity>(), Arg.Any<CancellationToken>())
                .Returns(entity);

            // Act
            var result = await _nutritionService.CreateAsync(model, CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldBe(entity.Id);
            result.Date.ShouldBe(entity.Date);
            result.UserId.ShouldBe(entity.UserId);
            result.FoodItems.Count.ShouldBe(2);
            result.Calories.ShouldBe(505);
            await _nutritionRepository.Received(1).CreateAsync(Arg.Any<NutritionEntity>(), Arg.Any<CancellationToken>());
        }
    }
}
