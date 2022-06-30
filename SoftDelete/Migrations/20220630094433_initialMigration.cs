using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftDelete.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "IsDelete", "Name" },
                values: new object[] { 1, false, "Alice" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "IsDelete", "Name" },
                values: new object[] { 2, false, "Bob" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "IsDelete", "Name" },
                values: new object[] { 3, true, "Tom" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_IsDelete",
                table: "Students",
                column: "IsDelete");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
