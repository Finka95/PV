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
using NSubstitute.ReturnsExtensions;
using Shouldly;
using Xunit;

namespace HealthMate.Tests
{
    public class GenericServiceTests
    {
        private readonly IGenderRepository _genderRepository;
        private readonly IGenderService _genderService;
        private readonly IMapper _mapper;
        private readonly Fixture _fixture;

        public GenericServiceTests()
        {
            _genderRepository = Substitute.For<IGenderRepository>();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperBllProfile());
            }).CreateMapper();

            _genderService = new GenderService(_genderRepository, _mapper);

            _fixture = new Fixture();
        }

        [Fact]
        public async Task GetByIdAsync_ValidId_ReturnGender()
        {
            //Arrange

            var id = _fixture.Create<Guid>();
            var entity = _fixture.Build<GenderEntity>()
                .With(e => e.Id, id).Create();

            _genderRepository.GetByIdAsync(id, Arg.Any<CancellationToken>()).Returns(entity);

            //Act 

            var result = await _genderService.GetByIdAsync(id, CancellationToken.None);

            //Assert 

            result.ShouldNotBeNull();
            result.Id.ShouldBe(entity.Id);
            result.Name.ShouldBe(entity.Name);
        }

        [Fact]
        public async Task GetByIdAsync_WithInvalidId_ThrowsNotFoundException()
        {
            //Arrange

            var id = _fixture.Create<Guid>();

            _genderRepository.GetByIdAsync(id, Arg.Any<CancellationToken>()).ReturnsNull();

            //Act 

            var action = () => _genderService.GetByIdAsync(id, CancellationToken.None);

            //Assert 

            await action.ShouldThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task CreateAsync_WithValidModel_ReturnsCreateModel()
        {
            //Arrange

            var model = _fixture.Create<Gender>();
            var entity = _mapper.Map<GenderEntity>(model);

            _genderRepository.CreateAsync(Arg.Any<GenderEntity>(), Arg.Any<CancellationToken>())
                .Returns(entity);

            //Act 

            var result = await _genderService.CreateAsync(model, CancellationToken.None);

            //Assert 

            result.ShouldNotBeNull();
            result.Id.ShouldBe(entity.Id);
            result.Name.ShouldBe(entity.Name);
        }

        [Fact]
        public async Task UpdateAsync_WithValidIdAndModel_ReturnsUpdateModel()
        {
            //Arrange

            var model = _fixture.Create<Gender>();
            var entity = _mapper.Map<GenderEntity>(model);

            _genderRepository.GetByIdAsync(model.Id, Arg.Any<CancellationToken>()).Returns(entity);
            _genderRepository.UpdateAsync(Arg.Any<GenderEntity>(), Arg.Any<CancellationToken>()).Returns(entity);

            //Act

            var result = await _genderService.UpdateAsync(model.Id, model, CancellationToken.None);

            //Assert

            result.ShouldNotBeNull();
            result.Id.ShouldBe(entity.Id);
            result.Name.ShouldBe(entity.Name);
        }


        [Fact]
        public async Task UpdateAsync_WithInvalidId_ThrowsNotFoundException()
        {
            //Arrange

            var id = _fixture.Create<Guid>();
            var model = _fixture.Create<Gender>();

            _genderRepository.GetByIdAsync(id, Arg.Any<CancellationToken>()).ReturnsNull();

            //Act 

            var action = () => _genderService.UpdateAsync(id, model, CancellationToken.None);

            //Assert 

            await action.ShouldThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task DeleteAsync_WithValidId_ShouldDeleteModel()
        {
            //Arrange 

            var model = _fixture.Create<Gender>();
            var entity = _mapper.Map<GenderEntity>(model);

            _genderRepository.GetByIdAsync(model.Id, Arg.Any<CancellationToken>()).Returns(entity);

            //Act

            await _genderService.DeleteAsync(model.Id, CancellationToken.None);

            //Assert

            await _genderRepository.Received(1).DeleteAsync(model.Id, Arg.Any<CancellationToken>());
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidId_ThrowsNotFoundException()
        {
            //Arrange

            var id = _fixture.Create<Guid>();
            var model = _fixture.Create<Gender>();

            _genderRepository.GetByIdAsync(id, Arg.Any<CancellationToken>()).ReturnsNull();

            //Act 

            var action = () => _genderService.DeleteAsync(id, CancellationToken.None);

            //Assert 

            await action.ShouldThrowAsync<NotFoundException>();
        }

        [Fact]
        public async Task GetAllAsync_ReturnsAllEntities()
        {
            // Arrange
            var entities = _fixture.CreateMany<GenderEntity>(3).ToList();
            _genderRepository.GetAllAsync(Arg.Any<CancellationToken>()).Returns(entities);

            // Act
            var result = await _genderService.GetAllAsync(CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.Count.ShouldBe(entities.Count);
            result.ShouldAllBe(m => entities.Any(e => e.Id == m.Id && e.Name == m.Name));
        }
    }
}
