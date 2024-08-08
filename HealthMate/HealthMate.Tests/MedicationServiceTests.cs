using AutoFixture;
using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Mappers;
using HealthMate.BLL.Providers;
using HealthMate.BLL.Services;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;
using NSubstitute;
using Shouldly;
using Xunit;

namespace HealthMate.Tests
{
    public class MedicationServiceTests
    {
        private readonly IMedicationRepository _medicationRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMedicationService _medicationService;
        private readonly IDateProvider _dateProvider;
        private readonly IMapper _mapper;
        private readonly Fixture _fixture;

        public MedicationServiceTests()
        {
            _medicationRepository = Substitute.For<IMedicationRepository>();
            _userRepository = Substitute.For<IUserRepository>();

            _mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MapperBllProfile());
            }).CreateMapper();

            _dateProvider = new DateProvider();

            _medicationService = new MedicationService(_medicationRepository, _mapper, _userRepository, _dateProvider);

            _fixture = new Fixture();
        }

        [Fact]
        public async Task GetMedicationsByDateOfUse_WithValidDate_ReturnsMedicationCollection()
        {
            // Arrange
            var date = _fixture.Create<DateTime>();

            var user = new UserEntity()
            {
                Name = _fixture.Create<string>(),
                UserName = _fixture.Create<string>(),
                Email = _fixture.Create<string>(),
                DateOfBirth = date
            };

            var firstEntity = _fixture.Build<MedicationEntity>()
                .With(m => m.User, user)
                .With(m => m.Date, date)
                .With(m => m.EndDate, date.AddDays(+6))
                .With(m => m.StartDate, date)
                .With(m => m.Notes, new List<NoteEntity>())
                .Create();

            var secondEntity = _fixture.Build<MedicationEntity>()
                .With(m => m.User, user)
                .With(m => m.Date, date)
                .With(m => m.EndDate, date.AddDays(+5))
                .With(m => m.StartDate, date)
                .With(m => m.Notes, new List<NoteEntity>())
                .Create();

            var entities = new List<MedicationEntity>() { firstEntity, secondEntity };

            _medicationRepository
                .GetMedicationsByDateOfUse(user.Id, date, Arg.Any<CancellationToken>())
                .Returns(entities);

            // Act
            var result = await _medicationService
                .GetMedicationsByDateOfUse(user.Id, date, CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.Count().ShouldBe(entities.Count);
            result.ShouldAllBe(m => entities.Any(e => e.Id == m.Id && e.UserId == m.UserId && e.Date == m.Date));
        }

        [Fact]
        public async Task GetMedicationsByDateOfUse_WithNoDataAndValidDate_ReturnsEmptyCollection()
        {
            // Arrange
            var date = _fixture.Create<DateTime>();

            var userId = _fixture.Create<Guid>();

            _medicationRepository.GetMedicationsByDateOfUse(userId, date, Arg.Any<CancellationToken>())
                .Returns(new List<MedicationEntity>());

            // Act
            var result = await _medicationService
                .GetMedicationsByDateOfUse(userId, date, CancellationToken.None);

            // Assert
            result.ShouldNotBeNull();
            result.ShouldBeEmpty();
        }
    }
}
