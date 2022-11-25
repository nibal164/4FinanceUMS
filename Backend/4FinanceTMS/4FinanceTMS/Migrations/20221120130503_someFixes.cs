using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4FinanceTMS.Migrations
{
    /// <inheritdoc />
    public partial class someFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Speciality",
                table: "Teacher",
                newName: "Specality");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specality",
                table: "Teacher",
                newName: "Speciality");
        }
    }
}
