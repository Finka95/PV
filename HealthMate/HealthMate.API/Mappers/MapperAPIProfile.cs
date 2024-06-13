using AutoMapper;
using HealthMate.API.DTO.Models;
using HealthMate.API.DTO.ShortModels;
using HealthMate.BLL.Models;

namespace HealthMate.API.Mappers
{
    public sealed class MapperAPIProfile : Profile
    {
        public MapperAPIProfile()
        {
            CreateMap<Activity, ActivityDTO>().ReverseMap();
            CreateMap<Activity, ShortActivityDTO>().ReverseMap();

            CreateMap<ActivityType, ActivityTypeDTO>().ReverseMap();
            CreateMap<ActivityType, ShortActivityTypeDTO>().ReverseMap();

            CreateMap<FoodItem, FoodItemDTO>().ReverseMap();
            CreateMap<FoodItem, ShortFoodItemDTO>().ReverseMap();

            CreateMap<Gender, GenderDTO>().ReverseMap();
            CreateMap<Gender, ShortGenderDTO>().ReverseMap();

            CreateMap<Health, HealthDTO>().ReverseMap();
            CreateMap<Health, ShortHealthDTO>().ReverseMap();

            CreateMap<Medication, MedicationDTO>().ReverseMap();
            CreateMap<Medication, ShortMedicationDTO>().ReverseMap();

            CreateMap<Mood, MoodDTO>().ReverseMap();
            CreateMap<Mood, ShortMoodDTO>().ReverseMap();

            CreateMap<Note, NoteDTO>().ReverseMap();
            CreateMap<Note, ShortNoteDTO>().ReverseMap();

            CreateMap<Nutrition, NutritionDTO>().ReverseMap();
            CreateMap<Nutrition, ShortNutritionDTO>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, ShortUserDTO>().ReverseMap();
        }
    }
}
