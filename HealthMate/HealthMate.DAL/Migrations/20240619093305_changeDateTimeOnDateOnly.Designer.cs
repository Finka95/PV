﻿// <auto-generated />
using System;
using HealthMate.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240619093305_changeDateTimeOnDateOnly")]
    partial class changeDateTimeOnDateOnly
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HealthMate.DAL.Entities.ActivityEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ActivityTypeId")
                        .HasColumnType("uuid");

                    b.Property<int>("CaloriesBurned")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("ActivitiesDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.ActivityTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ActivityTypesDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.FoodItemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Calories")
                        .HasColumnType("integer");

                    b.Property<double>("Carbohydrates")
                        .HasColumnType("double precision");

                    b.Property<double>("Fat")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("NutritionEntityId")
                        .HasColumnType("uuid");

                    b.Property<double>("Protein")
                        .HasColumnType("double precision");

                    b.Property<double>("Quantity")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("NutritionEntityId");

                    b.ToTable("FoodItemsDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.GenderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GenderEntity");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.HealthEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("BloodSugar")
                        .HasColumnType("double precision");

                    b.Property<double>("Cholesterol")
                        .HasColumnType("double precision");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("DiastolicBloodPressure")
                        .HasColumnType("integer");

                    b.Property<int>("HeartRate")
                        .HasColumnType("integer");

                    b.Property<int>("SystolicBloodPressure")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HealthsDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.MedicationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Dosage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Frequency")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MedicationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MedicationsDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.MoodEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("MoodStatus")
                        .HasColumnType("int");

                    b.Property<int>("StressLevel")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MoodsDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.NoteEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ActivityEntityId")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid?>("FoodItemEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("HealthEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MedicationEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("MoodEntityId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("NutritionEntityId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ActivityEntityId");

                    b.HasIndex("FoodItemEntityId");

                    b.HasIndex("HealthEntityId");

                    b.HasIndex("MedicationEntityId");

                    b.HasIndex("MoodEntityId");

                    b.HasIndex("NutritionEntityId");

                    b.ToTable("NotesDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.NutritionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Calories")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("NutritionDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uuid");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("UsersDbSet");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.ActivityEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.ActivityTypeEntity", "ActivityType")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTypeId");

                    b.HasOne("HealthMate.DAL.Entities.UserEntity", "User")
                        .WithMany("ActivityCollection")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActivityType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.FoodItemEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.NutritionEntity", null)
                        .WithMany("FoodItems")
                        .HasForeignKey("NutritionEntityId");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.HealthEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.UserEntity", "User")
                        .WithMany("HealthCollection")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.MedicationEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.UserEntity", "User")
                        .WithMany("MedicationsCollection")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.MoodEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.UserEntity", "User")
                        .WithMany("MoodsCollection")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.NoteEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.ActivityEntity", null)
                        .WithMany("Notes")
                        .HasForeignKey("ActivityEntityId");

                    b.HasOne("HealthMate.DAL.Entities.FoodItemEntity", null)
                        .WithMany("Notes")
                        .HasForeignKey("FoodItemEntityId");

                    b.HasOne("HealthMate.DAL.Entities.HealthEntity", null)
                        .WithMany("Notes")
                        .HasForeignKey("HealthEntityId");

                    b.HasOne("HealthMate.DAL.Entities.MedicationEntity", null)
                        .WithMany("Notes")
                        .HasForeignKey("MedicationEntityId");

                    b.HasOne("HealthMate.DAL.Entities.MoodEntity", null)
                        .WithMany("Notes")
                        .HasForeignKey("MoodEntityId");

                    b.HasOne("HealthMate.DAL.Entities.NutritionEntity", null)
                        .WithMany("Notes")
                        .HasForeignKey("NutritionEntityId");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.NutritionEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.UserEntity", "User")
                        .WithMany("NutritionCollection")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.UserEntity", b =>
                {
                    b.HasOne("HealthMate.DAL.Entities.GenderEntity", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.ActivityEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.ActivityTypeEntity", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.FoodItemEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.HealthEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.MedicationEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.MoodEntity", b =>
                {
                    b.Navigation("Notes");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.NutritionEntity", b =>
                {
                    b.Navigation("FoodItems");

                    b.Navigation("Notes");
                });

            modelBuilder.Entity("HealthMate.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("ActivityCollection");

                    b.Navigation("HealthCollection");

                    b.Navigation("MedicationsCollection");

                    b.Navigation("MoodsCollection");

                    b.Navigation("NutritionCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
