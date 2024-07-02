using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class ActivityTypeService(IActivityTypeRepository activityTypeRepository, IMapper mapper)
        : GenericService<ActivityTypeEntity, ActivityType>(activityTypeRepository, mapper), IActivityTypeService
    {
    }
}
