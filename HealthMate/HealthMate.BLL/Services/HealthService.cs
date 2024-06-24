using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class HealthService(IHealthRepository healthRepository, IMapper mapper)
        : ModelWithNotesAndDateService<HealthEntity, Health>(healthRepository, mapper), IHealthService
    {
    }
}
