using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenQuynhAnh056.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyNQA056",
                columns: table => new
                {
                    CompanyId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyNQA056", x => x.CompanyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyNQA056");
        }
    }
}
