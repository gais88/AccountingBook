using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class inicreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComapnyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComapnyShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComapnyCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
