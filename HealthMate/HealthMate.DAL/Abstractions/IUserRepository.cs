using HealthMate.DAL.Entities;

namespace HealthMate.DAL.Abstractions
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
        Task<int> GetTimeZoneOffsetMinutes(Guid userId);
    }
}
