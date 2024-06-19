using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingBook.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompanyDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "companies",
                columns: new[] { "Id", "ComapnyCode", "ComapnyName", "ComapnyShortName" },
                values: new object[] { 1L, "i001", "InifintyGroup", "inf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "companies",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
