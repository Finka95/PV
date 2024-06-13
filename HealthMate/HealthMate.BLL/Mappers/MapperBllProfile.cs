using AutoMapper;
using HealthMate.DAL.Entities;

namespace HealthMate.BLL.Mappers
{
    public sealed class MapperBllProfile : Profile
    {
        public MapperBllProfile()
        {
            CreateMap<Activity, Models.Activity>().ReverseMap();

            CreateMap<ActivityType, Models.ActivityType>().ReverseMap();

            CreateMap<FoodItem, Models.FoodItem>().ReverseMap();

            CreateMap<Gender, Models.Gender>().ReverseMap();

            CreateMap<Health, Models.Health>().ReverseMap();

            CreateMap<Medication, Models.Medication>().ReverseMap();

            CreateMap<Mood, Models.Mood>().ReverseMap();

            CreateMap<Note, Models.Note>().ReverseMap();

            CreateMap<Nutrition, Models.Nutrition>().ReverseMap();

            CreateMap<User, Models.User>().ReverseMap();
        }
    }
}
