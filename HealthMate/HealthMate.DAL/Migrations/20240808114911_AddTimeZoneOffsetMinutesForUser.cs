using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthMate.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeZoneOffsetMinutesForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeZoneOffsetMinutes",
                table: "UsersDbSet",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeZoneOffsetMinutes",
                table: "UsersDbSet");
        }
    }
}
