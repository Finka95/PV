using HealthMate.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.DbContexts
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> UsersDbSet { get; set; }
        public DbSet<Activity> ActivitiesDbSet { get; set; }
        public DbSet<ActivityType> ActivityTypesDbSet { get; set; }
        public DbSet<FoodItem> FoodItemsDbSet { get; set; }
        public DbSet<Health> HealthsDbSet { get; set; }
        public DbSet<Medication> MedicationsDbSet { get; set; }
        public DbSet<Mood> MoodsDbSet { get; set; }
        public DbSet<Note> NotesDbSet { get; set; }
        public DbSet<Nutrition> NutritionDbSet { get; set; }
        
    }
}
