using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class UserService(IUserRepository userRepository, IMapper mapper)
        : GenericService<UserEntity, User>(userRepository, mapper), IUserService
    {

    }
}
