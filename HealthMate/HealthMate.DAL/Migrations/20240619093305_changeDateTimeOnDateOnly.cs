using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeDateTimeOnDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItemsDbSet_NutritionDbSet_NutritionId",
                table: "FoodItemsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_ActivitiesDbSet_ActivityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_FoodItemsDbSet_FoodItemId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_HealthsDbSet_HealthId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_MedicationsDbSet_MedicationId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_MoodsDbSet_MoodId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_NutritionDbSet_NutritionId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersDbSet_Gender_GenderId",
                table: "UsersDbSet");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropColumn(
                name: "User",
                table: "HealthsDbSet");

            migrationBuilder.DropColumn(
                name: "ActivityType",
                table: "ActivitiesDbSet");

            migrationBuilder.RenameColumn(
                name: "NutritionId",
                table: "NotesDbSet",
                newName: "NutritionEntityId");

            migrationBuilder.RenameColumn(
                name: "MoodId",
                table: "NotesDbSet",
                newName: "MoodEntityId");

            migrationBuilder.RenameColumn(
                name: "MedicationId",
                table: "NotesDbSet",
                newName: "MedicationEntityId");

            migrationBuilder.RenameColumn(
                name: "HealthId",
                table: "NotesDbSet",
                newName: "HealthEntityId");

            migrationBuilder.RenameColumn(
                name: "FoodItemId",
                table: "NotesDbSet",
                newName: "FoodItemEntityId");

            migrationBuilder.RenameColumn(
                name: "ActivityId",
                table: "NotesDbSet",
                newName: "ActivityEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_NutritionId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_NutritionEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_MoodId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_MoodEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_MedicationId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_MedicationEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_HealthId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_HealthEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_FoodItemId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_FoodItemEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_ActivityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_ActivityEntityId");

            migrationBuilder.RenameColumn(
                name: "NutritionId",
                table: "FoodItemsDbSet",
                newName: "NutritionEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodItemsDbSet_NutritionId",
                table: "FoodItemsDbSet",
                newName: "IX_FoodItemsDbSet_NutritionEntityId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "UsersDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UsersDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "UsersDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "UsersDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "NutritionDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "NotesDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "NotesDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "MoodsDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "MedicationsDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "MedicationName",
                table: "MedicationsDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "MedicationsDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "MedicationsDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Dosage",
                table: "MedicationsDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "HealthsDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodItemsDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ActivityTypesDbSet",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "ActivitiesDbSet",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateTable(
                name: "GenderEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderEntity", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItemsDbSet_NutritionDbSet_NutritionEntityId",
                table: "FoodItemsDbSet",
                column: "NutritionEntityId",
                principalTable: "NutritionDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_ActivitiesDbSet_ActivityEntityId",
                table: "NotesDbSet",
                column: "ActivityEntityId",
                principalTable: "ActivitiesDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_FoodItemsDbSet_FoodItemEntityId",
                table: "NotesDbSet",
                column: "FoodItemEntityId",
                principalTable: "FoodItemsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_HealthsDbSet_HealthEntityId",
                table: "NotesDbSet",
                column: "HealthEntityId",
                principalTable: "HealthsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_MedicationsDbSet_MedicationEntityId",
                table: "NotesDbSet",
                column: "MedicationEntityId",
                principalTable: "MedicationsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_MoodsDbSet_MoodEntityId",
                table: "NotesDbSet",
                column: "MoodEntityId",
                principalTable: "MoodsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_NutritionDbSet_NutritionEntityId",
                table: "NotesDbSet",
                column: "NutritionEntityId",
                principalTable: "NutritionDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersDbSet_GenderEntity_GenderId",
                table: "UsersDbSet",
                column: "GenderId",
                principalTable: "GenderEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItemsDbSet_NutritionDbSet_NutritionEntityId",
                table: "FoodItemsDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_ActivitiesDbSet_ActivityEntityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_FoodItemsDbSet_FoodItemEntityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_HealthsDbSet_HealthEntityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_MedicationsDbSet_MedicationEntityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_MoodsDbSet_MoodEntityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_NotesDbSet_NutritionDbSet_NutritionEntityId",
                table: "NotesDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersDbSet_GenderEntity_GenderId",
                table: "UsersDbSet");

            migrationBuilder.DropTable(
                name: "GenderEntity");

            migrationBuilder.RenameColumn(
                name: "NutritionEntityId",
                table: "NotesDbSet",
                newName: "NutritionId");

            migrationBuilder.RenameColumn(
                name: "MoodEntityId",
                table: "NotesDbSet",
                newName: "MoodId");

            migrationBuilder.RenameColumn(
                name: "MedicationEntityId",
                table: "NotesDbSet",
                newName: "MedicationId");

            migrationBuilder.RenameColumn(
                name: "HealthEntityId",
                table: "NotesDbSet",
                newName: "HealthId");

            migrationBuilder.RenameColumn(
                name: "FoodItemEntityId",
                table: "NotesDbSet",
                newName: "FoodItemId");

            migrationBuilder.RenameColumn(
                name: "ActivityEntityId",
                table: "NotesDbSet",
                newName: "ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_NutritionEntityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_NutritionId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_MoodEntityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_MoodId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_MedicationEntityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_MedicationId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_HealthEntityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_HealthId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_FoodItemEntityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_FoodItemId");

            migrationBuilder.RenameIndex(
                name: "IX_NotesDbSet_ActivityEntityId",
                table: "NotesDbSet",
                newName: "IX_NotesDbSet_ActivityId");

            migrationBuilder.RenameColumn(
                name: "NutritionEntityId",
                table: "FoodItemsDbSet",
                newName: "NutritionId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodItemsDbSet_NutritionEntityId",
                table: "FoodItemsDbSet",
                newName: "IX_FoodItemsDbSet_NutritionId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "UsersDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UsersDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "UsersDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "UsersDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "NutritionDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "NotesDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "NotesDbSet",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "MoodsDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "MedicationsDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "MedicationName",
                table: "MedicationsDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Frequency",
                table: "MedicationsDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "MedicationsDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Dosage",
                table: "MedicationsDbSet",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "HealthsDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<Guid>(
                name: "User",
                table: "HealthsDbSet",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "FoodItemsDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ActivityTypesDbSet",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ActivitiesDbSet",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<Guid>(
                name: "ActivityType",
                table: "ActivitiesDbSet",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItemsDbSet_NutritionDbSet_NutritionId",
                table: "FoodItemsDbSet",
                column: "NutritionId",
                principalTable: "NutritionDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_ActivitiesDbSet_ActivityId",
                table: "NotesDbSet",
                column: "ActivityId",
                principalTable: "ActivitiesDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_FoodItemsDbSet_FoodItemId",
                table: "NotesDbSet",
                column: "FoodItemId",
                principalTable: "FoodItemsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_HealthsDbSet_HealthId",
                table: "NotesDbSet",
                column: "HealthId",
                principalTable: "HealthsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_MedicationsDbSet_MedicationId",
                table: "NotesDbSet",
                column: "MedicationId",
                principalTable: "MedicationsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_MoodsDbSet_MoodId",
                table: "NotesDbSet",
                column: "MoodId",
                principalTable: "MoodsDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDbSet_NutritionDbSet_NutritionId",
                table: "NotesDbSet",
                column: "NutritionId",
                principalTable: "NutritionDbSet",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersDbSet_Gender_GenderId",
                table: "UsersDbSet",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
