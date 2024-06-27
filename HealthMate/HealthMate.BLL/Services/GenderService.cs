using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class GenderService(IGenderRepository genderRepository, IMapper mapper)
        : GenericService<GenderEntity, Gender>(genderRepository, mapper), IGenderService
    {
    }
}
