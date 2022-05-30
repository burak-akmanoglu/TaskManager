using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class lastmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeekTaskFinishTime",
                table: "TblWeek");

            migrationBuilder.DropColumn(
                name: "MonthTaskFinishTime",
                table: "TblMonth");

            migrationBuilder.DropColumn(
                name: "DayTaskFinishTime",
                table: "TblDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeekTaskFinishTime",
                table: "TblWeek",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MonthTaskFinishTime",
                table: "TblMonth",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DayTaskFinishTime",
                table: "TblDay",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
