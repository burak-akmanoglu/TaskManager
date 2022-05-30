using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TblDay",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayTime = table.Column<int>(type: "int", nullable: false),
                    DayTaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayTaskFinishTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TaskImportanceID = table.Column<int>(type: "int", nullable: true),
                    TaskStatuseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDay", x => x.DayId);
                    table.ForeignKey(
                        name: "FK_TblDay_TblTaskImportance_TaskImportanceID",
                        column: x => x.TaskImportanceID,
                        principalTable: "TblTaskImportance",
                        principalColumn: "TaskImportanceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblDay_TblTaskStatus_TaskStatuseID",
                        column: x => x.TaskStatuseID,
                        principalTable: "TblTaskStatus",
                        principalColumn: "TaskStatuseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblDay_TblUser_UserID",
                        column: x => x.UserID,
                        principalTable: "TblUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblMonth",
                columns: table => new
                {
                    MonthID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MonthTime = table.Column<int>(type: "int", nullable: false),
                    MonthTaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthTaskFinishTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TaskImportanceID = table.Column<int>(type: "int", nullable: true),
                    TaskStatuseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMonth", x => x.MonthID);
                    table.ForeignKey(
                        name: "FK_TblMonth_TblTaskImportance_TaskImportanceID",
                        column: x => x.TaskImportanceID,
                        principalTable: "TblTaskImportance",
                        principalColumn: "TaskImportanceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMonth_TblTaskStatus_TaskStatuseID",
                        column: x => x.TaskStatuseID,
                        principalTable: "TblTaskStatus",
                        principalColumn: "TaskStatuseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblMonth_TblUser_UserID",
                        column: x => x.UserID,
                        principalTable: "TblUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblWeek",
                columns: table => new
                {
                    WeekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekTime = table.Column<int>(type: "int", nullable: false),
                    WeekTaskContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeekTaskFinishTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    TaskImportanceID = table.Column<int>(type: "int", nullable: true),
                    TaskStatuseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblWeek", x => x.WeekID);
                    table.ForeignKey(
                        name: "FK_TblWeek_TblTaskImportance_TaskImportanceID",
                        column: x => x.TaskImportanceID,
                        principalTable: "TblTaskImportance",
                        principalColumn: "TaskImportanceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblWeek_TblTaskStatus_TaskStatuseID",
                        column: x => x.TaskStatuseID,
                        principalTable: "TblTaskStatus",
                        principalColumn: "TaskStatuseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblWeek_TblUser_UserID",
                        column: x => x.UserID,
                        principalTable: "TblUser",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblDay_TaskImportanceID",
                table: "TblDay",
                column: "TaskImportanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TblDay_TaskStatuseID",
                table: "TblDay",
                column: "TaskStatuseID");

            migrationBuilder.CreateIndex(
                name: "IX_TblDay_UserID",
                table: "TblDay",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMonth_TaskImportanceID",
                table: "TblMonth",
                column: "TaskImportanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMonth_TaskStatuseID",
                table: "TblMonth",
                column: "TaskStatuseID");

            migrationBuilder.CreateIndex(
                name: "IX_TblMonth_UserID",
                table: "TblMonth",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TblWeek_TaskImportanceID",
                table: "TblWeek",
                column: "TaskImportanceID");

            migrationBuilder.CreateIndex(
                name: "IX_TblWeek_TaskStatuseID",
                table: "TblWeek",
                column: "TaskStatuseID");

            migrationBuilder.CreateIndex(
                name: "IX_TblWeek_UserID",
                table: "TblWeek",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblDay");

            migrationBuilder.DropTable(
                name: "TblMonth");

            migrationBuilder.DropTable(
                name: "TblWeek");

            migrationBuilder.DropTable(
                name: "TblTaskImportance");

            migrationBuilder.DropTable(
                name: "TblTaskStatus");

            migrationBuilder.DropTable(
                name: "TblUser");
        }
    }
}
