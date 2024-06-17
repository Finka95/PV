using AutoMapper;
using HealthMate.API.DTO.Models;
using HealthMate.API.DTO.ShortModels;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService, IMapper mapper)
        : GenericController<User, UserDTO, ShortUserDTO>(userService, mapper)
    {

    }
}
