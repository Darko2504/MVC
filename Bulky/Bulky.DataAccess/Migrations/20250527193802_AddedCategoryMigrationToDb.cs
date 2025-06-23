using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bulky.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCategoryMigrationToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category21Id",
                table: "Categories",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "Category21Id");
        }
    }
}
