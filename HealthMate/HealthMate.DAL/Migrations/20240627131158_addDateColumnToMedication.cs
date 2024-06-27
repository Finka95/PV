using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addDateColumnToMedication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "MedicationsDbSet",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "MedicationsDbSet");
        }
    }
}
