using AutoMapper;
using HealthMate.API.ViewModels.Activity;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;

namespace HealthMate.API.Controllers
{
    public class ActivityController
        (IActivityService activityService, IMapper mapper)
        : ModelWithNotesAndDateController<Activity, ActivityViewModel, ShortActivityViewModel>(activityService, mapper)
    {
    }
}
