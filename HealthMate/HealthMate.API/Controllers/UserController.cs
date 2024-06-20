using AutoMapper;
using HealthMate.API.ViewModels.User;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController(IUserService userService, IMapper mapper)
        : GenericController<User, UserViewModel, ShortUserViewModel>(userService, mapper)
    {

    }
}
