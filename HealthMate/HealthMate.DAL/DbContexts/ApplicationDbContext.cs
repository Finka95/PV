using HealthMate.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthMate.DAL.DbContexts
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserEntity> UsersDbSet { get; set; }
        public DbSet<ActivityEntity> ActivitiesDbSet { get; set; }
        public DbSet<ActivityTypeEntity> ActivityTypesDbSet { get; set; }
        public DbSet<FoodItemEntity> FoodItemsDbSet { get; set; }
        public DbSet<HealthEntity> HealthsDbSet { get; set; }
        public DbSet<MedicationEntity> MedicationsDbSet { get; set; }
        public DbSet<MoodEntity> MoodsDbSet { get; set; }
        public DbSet<NoteEntity> NotesDbSet { get; set; }
        public DbSet<NutritionEntity> NutritionDbSet { get; set; }
        
    }
}
