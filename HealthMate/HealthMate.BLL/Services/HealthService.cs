using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class HealthService
        (IModelWithNotesAndDateRepository<HealthEntity> modelWithNotesAndDateRepository, IMapper mapper)
        : ModelWithNotesAndDateService<HealthEntity, Health>(modelWithNotesAndDateRepository, mapper), IHealthService
    {
    }
}
