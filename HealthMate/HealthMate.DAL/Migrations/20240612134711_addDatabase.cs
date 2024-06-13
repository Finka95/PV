using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityTypesDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTypesDbSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UserName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    Weight = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersDbSet_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ActivityType = table.Column<Guid>(type: "uuid", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: false),
                    CaloriesBurned = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActivityTypeId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitiesDbSet_ActivityTypesDbSet_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityTypesDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivitiesDbSet_UsersDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthsDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    User = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SystolicBloodPressure = table.Column<int>(type: "integer", nullable: false),
                    DiastolicBloodPressure = table.Column<int>(type: "integer", nullable: false),
                    HeartRate = table.Column<int>(type: "integer", nullable: false),
                    BloodSugar = table.Column<double>(type: "double precision", nullable: false),
                    Cholesterol = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthsDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthsDbSet_UsersDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationsDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicationName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Dosage = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Frequency = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationsDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicationsDbSet_UsersDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoodsDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MoodStatus = table.Column<int>(type: "int", nullable: false),
                    StressLevel = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoodsDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoodsDbSet_UsersDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NutritionDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    Calories = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NutritionDbSet_UsersDbSet_UserId",
                        column: x => x.UserId,
                        principalTable: "UsersDbSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemsDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    Calories = table.Column<int>(type: "integer", nullable: false),
                    Protein = table.Column<double>(type: "double precision", nullable: false),
                    Fat = table.Column<double>(type: "double precision", nullable: false),
                    Carbohydrates = table.Column<double>(type: "double precision", nullable: false),
                    NutritionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemsDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemsDbSet_NutritionDbSet_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "NutritionDbSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NotesDbSet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uuid", nullable: true),
                    FoodItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    HealthId = table.Column<Guid>(type: "uuid", nullable: true),
                    MedicationId = table.Column<Guid>(type: "uuid", nullable: true),
                    MoodId = table.Column<Guid>(type: "uuid", nullable: true),
                    NutritionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotesDbSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotesDbSet_ActivitiesDbSet_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "ActivitiesDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotesDbSet_FoodItemsDbSet_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItemsDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotesDbSet_HealthsDbSet_HealthId",
                        column: x => x.HealthId,
                        principalTable: "HealthsDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotesDbSet_MedicationsDbSet_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "MedicationsDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotesDbSet_MoodsDbSet_MoodId",
                        column: x => x.MoodId,
                        principalTable: "MoodsDbSet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotesDbSet_NutritionDbSet_NutritionId",
                        column: x => x.NutritionId,
                        principalTable: "NutritionDbSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesDbSet_ActivityTypeId",
                table: "ActivitiesDbSet",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesDbSet_UserId",
                table: "ActivitiesDbSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemsDbSet_NutritionId",
                table: "FoodItemsDbSet",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthsDbSet_UserId",
                table: "HealthsDbSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationsDbSet_UserId",
                table: "MedicationsDbSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MoodsDbSet_UserId",
                table: "MoodsDbSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NotesDbSet_ActivityId",
                table: "NotesDbSet",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_NotesDbSet_FoodItemId",
                table: "NotesDbSet",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_NotesDbSet_HealthId",
                table: "NotesDbSet",
                column: "HealthId");

            migrationBuilder.CreateIndex(
                name: "IX_NotesDbSet_MedicationId",
                table: "NotesDbSet",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_NotesDbSet_MoodId",
                table: "NotesDbSet",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_NotesDbSet_NutritionId",
                table: "NotesDbSet",
                column: "NutritionId");

            migrationBuilder.CreateIndex(
                name: "IX_NutritionDbSet_UserId",
                table: "NutritionDbSet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersDbSet_GenderId",
                table: "UsersDbSet",
                column: "GenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotesDbSet");

            migrationBuilder.DropTable(
                name: "ActivitiesDbSet");

            migrationBuilder.DropTable(
                name: "FoodItemsDbSet");

            migrationBuilder.DropTable(
                name: "HealthsDbSet");

            migrationBuilder.DropTable(
                name: "MedicationsDbSet");

            migrationBuilder.DropTable(
                name: "MoodsDbSet");

            migrationBuilder.DropTable(
                name: "ActivityTypesDbSet");

            migrationBuilder.DropTable(
                name: "NutritionDbSet");

            migrationBuilder.DropTable(
                name: "UsersDbSet");

            migrationBuilder.DropTable(
                name: "Gender");
        }
    }
}
