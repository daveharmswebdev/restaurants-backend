using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace restaurants_backend.Migrations
{
    /// <inheritdoc />
    public partial class modifyStaff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Staff",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Staff");
        }
    }
}
