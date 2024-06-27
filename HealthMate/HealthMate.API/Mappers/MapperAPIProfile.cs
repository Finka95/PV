using AutoMapper;
using HealthMate.API.ViewModels.Activity;
using HealthMate.API.ViewModels.ActivityType;
using HealthMate.API.ViewModels.FoodItem;
using HealthMate.API.ViewModels.Gender;
using HealthMate.API.ViewModels.Health;
using HealthMate.API.ViewModels.Medication;
using HealthMate.API.ViewModels.Mood;
using HealthMate.API.ViewModels.Note;
using HealthMate.API.ViewModels.Nutrition;
using HealthMate.API.ViewModels.User;
using HealthMate.BLL.Models;

namespace HealthMate.API.Mappers
{
    public sealed class MapperAPIProfile : Profile
    {
        public MapperAPIProfile()
        {
            CreateMap<Activity, ActivityViewModel>().ReverseMap();
            CreateMap<Activity, ShortActivityViewModel>().ReverseMap();

            CreateMap<ActivityType, ActivityTypeViewModel>().ReverseMap();
            CreateMap<ActivityType, ShortActivityTypeViewModel>().ReverseMap();

            CreateMap<FoodItem, FoodItemViewModel>().ReverseMap();
            CreateMap<FoodItem, ShortFoodItemViewModel>().ReverseMap();

            CreateMap<Gender, GenderViewModel>().ReverseMap();
            CreateMap<Gender, ShortGenderViewModel>().ReverseMap();

            CreateMap<Health, HealthViewModel>().ReverseMap();
            CreateMap<Health, ShortHealthViewModel>().ReverseMap();

            CreateMap<Medication, MedicationViewModel>().ReverseMap();

            CreateMap<Mood, MoodViewModel>().ReverseMap();
            CreateMap<Mood, ShortMoodViewModel>().ReverseMap();

            CreateMap<Note, NoteViewModel>().ReverseMap();
            CreateMap<Note, ShortNoteViewModel>().ReverseMap();

            CreateMap<Nutrition, NutritionViewModel>().ReverseMap();
            CreateMap<Nutrition, ShortNutritionViewModel>().ReverseMap();

            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<User, ShortUserViewModel>().ReverseMap();
        }
    }
}
