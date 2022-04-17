using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ingeniería.Backend.Migrations
{
    /// <inheritdoc />
    public partial class fixedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Categorías",
                newName: "Categoría");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categoría",
                table: "Categorías",
                newName: "Marca");
        }
    }
}
