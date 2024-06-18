using AutoMapper;
using HealthMate.BLL.Models;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Mappers
{
    public sealed class MapperBllProfile : Profile
    {
        public MapperBllProfile()
        {
            CreateMap<ActivityEntity, Activity>().ReverseMap();

            CreateMap<ActivityTypeEntity, ActivityType>().ReverseMap();

            CreateMap<FoodItemEntity, FoodItem>().ReverseMap();

            CreateMap<GenderEntity, Gender>().ReverseMap();

            CreateMap<HealthEntity, Health>().ReverseMap();

            CreateMap<MedicationEntity, Medication>().ReverseMap();

            CreateMap<MoodEntity, Mood>().ReverseMap();

            CreateMap<NoteEntity, Note>().ReverseMap();

            CreateMap<NutritionEntity, Nutrition>().ReverseMap();

            CreateMap<UserEntity, User>().ReverseMap();
        }
    }
}
