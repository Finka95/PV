using AutoMapper;
using HealthMate.API.ViewModels.ActivityType;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthMate.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityTypeController(IActivityTypeService activityTypeService, IMapper mapper)
        : GenericController<ActivityType, ActivityTypeViewModel, ShortActivityTypeViewModel>(activityTypeService, mapper)
    {
    }
}
