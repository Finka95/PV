using AutoFixture;
using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Mappers;
using HealthMate.BLL.Services;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using Shouldly;
using Xunit;

namespace HealthMate.Tests
{
    public class ModelWithNotesAndDateServiceTests
    {
        private readonly IMoodRepository _moodRepository;
        private readonly IMoodService _moodService;
        private readonly IMapper _mapper;
        private readonly Fixture _fixture;

        public ModelWithNotesAndDateServiceTests()
        {
            _moodRepository = Substitute.For<IMoodRepository>();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperBllProfile());
            }).CreateMapper();

            _moodService = new MoodService(_moodRepository, _mapper);

            _fixture = new Fixture();
        }

        [Fact]
        public async Task GetByDate_WithValidUserIdAndDate_ReturnsModel()
        {
            //Arrange 

            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());

            var user = new UserEntity()
            {
                Name = _fixture.Create<string>(),
                UserName = _fixture.Create<string>(),
                Email = _fixture.Create<string>(),
                DateOfBirth = date
            };

            var entity = _fixture.Build<MoodEntity>()
                .With(m => m.User, user)
                .With(m => m.Date, date)
                .With(m => m.Notes, new List<NoteEntity>())
                .Create();

            _moodRepository.GetByDate(entity.UserId, date, Arg.Any<CancellationToken>()).Returns(entity);

            //Act

            var result = await _moodService.GetByDate(entity.UserId, date, CancellationToken.None);

            //Assert

            result.ShouldNotBeNull();
            result.UserId.ShouldBe(entity.UserId);
            result.Date.ShouldBe(date);
            result.Id.ShouldBe(entity.Id);
            result.Notes.ShouldBeEmpty();
        }

        [Fact]
        public async Task GetByDate_WithNoDataAndValidDate_ReturnsNull()
        {
            // Arrange 
            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());
            var userId = Guid.NewGuid();
            _moodRepository.GetByDate(userId, date, Arg.Any<CancellationToken>()).ReturnsNull();

            // Act
            var result = await _moodService.GetByDate(userId, date, CancellationToken.None);

            // Assert
            result.ShouldBeNull();
        }

        [Fact]
        public async Task GetBetweenTwoDates_WithValidStartAndEndDates_ReturnsCorrectModels()
        {
            // Arrange
            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());
            var startDate = date.AddDays(-7);
            var finishDate = date;
            var user = new UserEntity()
            {
                Name = _fixture.Create<string>(),
                UserName = _fixture.Create<string>(),
                Email = _fixture.Create<string>(),
                DateOfBirth = date
            };

            var firstEntity = _fixture.Build<MoodEntity>()
                .With(m => m.User, user)
                .With(m => m.Date, date)
                .With(m => m.Notes, new List<NoteEntity>())
                .Create();

            var secondEntity = _fixture.Build<MoodEntity>()
                .With(m => m.User, user)
                .With(m => m.Date, date)
                .With(m => m.Notes, new List<NoteEntity>())
                .Create();

            var entities = new List<MoodEntity>() { firstEntity, secondEntity };

            _moodRepository.GetBetweenTwoDates(user.Id, startDate, finishDate, Arg.Any<CancellationToken>())
                .Returns(entities);

            // Act
            var result = await _moodService.GetBetweenTwoDates(user.Id, startDate, finishDate, CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBe(entities.Count);
            result.ShouldAllBe(m => entities.Any(e => e.Id == m.Id && e.UserId == m.UserId && e.Date == m.Date));
        }

        [Fact]
        public async Task GetBetweenTwoDates_WithNoData_ReturnsEmptyList()
        {
            // Arrange
            var date = DateOnly.FromDateTime(_fixture.Create<DateTime>());
            var userId = Guid.NewGuid();
            var startDate = date.AddDays(-7);
            var finishDate = date;

            _moodRepository.GetBetweenTwoDates(userId, startDate, finishDate, Arg.Any<CancellationToken>())
                .Returns(new List<MoodEntity>());

            // Act
            var result = await _moodService.GetBetweenTwoDates(userId, startDate, finishDate, CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.ShouldBeEmpty();
        }
    }
}
