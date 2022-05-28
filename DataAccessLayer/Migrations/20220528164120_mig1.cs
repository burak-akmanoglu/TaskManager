using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAdmin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdmin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "TblDay",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayTime = table.Column<int>(type: "int", nullable: false),
                    DayTaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayTaskFinishTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDay", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "TblMonth",
                columns: table => new
                {
                    MonthID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthTime = table.Column<int>(type: "int", nullable: false),
                    MonthTaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthTaskFinishTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMonth", x => x.MonthID);
                });

            migrationBuilder.CreateTable(
                name: "TblTaskImportance",
                columns: table => new
                {
                    TaskImportanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskImportanceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTaskImportance", x => x.TaskImportanceID);
                });

            migrationBuilder.CreateTable(
                name: "TblTaskStatus",
                columns: table => new
                {
                    TaskStatuseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskStatuseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTaskStatus", x => x.TaskStatuseID);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "TblWeek",
                columns: table => new
                {
                    WeekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekTime = table.Column<int>(type: "int", nullable: false),
                    WeekTaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekTaskFinishTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWeek", x => x.WeekID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAdmin");

            migrationBuilder.DropTable(
                name: "TblDay");

            migrationBuilder.DropTable(
                name: "TblMonth");

            migrationBuilder.DropTable(
                name: "TblTaskImportance");

            migrationBuilder.DropTable(
                name: "TblTaskStatus");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblWeek");
        }
    }
}
