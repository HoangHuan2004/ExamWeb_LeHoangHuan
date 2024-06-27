using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_LeHoangHuan.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaNhacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaCD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NgheSi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaNhacs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "GiaBan", "NgheSi", "SoLuong", "TrongNuoc", "TuaCD" },
                values: new object[,]
                {
                    { 1, 100000.0, "Aki", 50, true, "No Internet" },
                    { 2, 120000.0, "jaigon", 40, true, "Là Tất Cả" },
                    { 3, 100000.0, "Sơn Tùng", 20, true, "nắng ấm" },
                    { 4, 100000.0, "Dế Choắt", 10, true, "Chú Ché Loắt Choắt" },
                    { 5, 100000.0, "Bray", 15, false, "Để Ai Cần" },
                    { 6, 100000.0, "Aki", 24, true, "Yêu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaNhacs");
        }
    }
}
