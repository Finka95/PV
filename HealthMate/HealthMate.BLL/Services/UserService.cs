using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class UserService(IUserRepository userRepository, IMapper mapper)
        : GenericService<User, Models.User>(userRepository, mapper), IUserService
    {

    }
}
