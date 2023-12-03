using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace restaurants_backend.Migrations
{
    /// <inheritdoc />
    public partial class ModifyStaffTableHourlyWage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "HourlyWage",
                table: "Staff",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "HourlyWage",
                table: "Staff",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }
    }
}
