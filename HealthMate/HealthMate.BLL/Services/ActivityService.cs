using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class ActivityService
        (IActivityRepository activityRepository, IMapper mapper)
        : ModelWithNotesAndDateService<ActivityEntity, Activity>(activityRepository, mapper), IActivityService
    {
    }
}
