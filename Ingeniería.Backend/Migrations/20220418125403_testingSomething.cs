using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ingeniería.Backend.Migrations
{
    /// <inheritdoc />
    public partial class testingSomething : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Pedidos_OrderId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_OrderId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Productos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_PedidoId",
                table: "Productos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Pedidos_PedidoId",
                table: "Productos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Pedidos_PedidoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_PedidoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Pedidos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_OrderId",
                table: "Productos",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Pedidos_OrderId",
                table: "Productos",
                column: "OrderId",
                principalTable: "Pedidos",
                principalColumn: "Id");
        }
    }
}
