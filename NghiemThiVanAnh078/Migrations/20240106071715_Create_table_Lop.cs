using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NghiemThiVanAnh078.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Lop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "TEXT", nullable: false),
                    TenLop = table.Column<string>(type: "TEXT", nullable: false),
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_Lop_NTVA078_Masinhvien",
                        column: x => x.Masinhvien,
                        principalTable: "NTVA078",
                        principalColumn: "Masinhvien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Masinhvien",
                table: "Lop",
                column: "Masinhvien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lop");
        }
    }
}
