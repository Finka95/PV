using AutoMapper;
using HealthMate.BLL.Abstractions;
using HealthMate.BLL.Models;
using HealthMate.DAL.Abstractions;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Services
{
    public class MoodService(IMoodRepository moodRepository, IMapper mapper)
        : ModelWithNotesAndDateService<MoodEntity, Mood>(moodRepository, mapper), IMoodService
    {
    }
}
