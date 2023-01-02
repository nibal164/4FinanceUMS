using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoapLush.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SoapCategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subCategortyId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoapCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SoapSubCategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoapSubCategories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subCategortyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoapCategoryid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_SoapCategories_SoapCategoryid",
                        column: x => x.SoapCategoryid,
                        principalTable: "SoapCategories",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SoapCategorySoapSubCategory",
                columns: table => new
                {
                    SoapSubCategoriesid = table.Column<int>(type: "int", nullable: false),
                    soapCategoriesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoapCategorySoapSubCategory", x => new { x.SoapSubCategoriesid, x.soapCategoriesid });
                    table.ForeignKey(
                        name: "FK_SoapCategorySoapSubCategory_SoapCategories_soapCategoriesid",
                        column: x => x.soapCategoriesid,
                        principalTable: "SoapCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoapCategorySoapSubCategory_SoapSubCategories_SoapSubCategoriesid",
                        column: x => x.SoapSubCategoriesid,
                        principalTable: "SoapSubCategories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SoapCategoryid",
                table: "Products",
                column: "SoapCategoryid");

            migrationBuilder.CreateIndex(
                name: "IX_SoapCategorySoapSubCategory_soapCategoriesid",
                table: "SoapCategorySoapSubCategory",
                column: "soapCategoriesid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SoapCategorySoapSubCategory");

            migrationBuilder.DropTable(
                name: "SoapCategories");

            migrationBuilder.DropTable(
                name: "SoapSubCategories");
        }
    }
}
