using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRestaurante.Infrastructure.Persistence.Migrations
{
    public partial class ChangedIdFieldNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDish_Dishes_IdDish",
                table: "OrderDish");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDish_Orders_IdOrder",
                table: "OrderDish");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_IdTable",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "IdTable",
                table: "Orders",
                newName: "TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_IdTable",
                table: "Orders",
                newName: "IX_Orders_TableId");

            migrationBuilder.RenameColumn(
                name: "IdOrder",
                table: "OrderDish",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "IdDish",
                table: "OrderDish",
                newName: "DishId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDish_IdOrder",
                table: "OrderDish",
                newName: "IX_OrderDish_OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDish_Dishes_DishId",
                table: "OrderDish",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDish_Orders_OrderId",
                table: "OrderDish",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDish_Dishes_DishId",
                table: "OrderDish");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDish_Orders_OrderId",
                table: "OrderDish");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Orders",
                newName: "IdTable");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_TableId",
                table: "Orders",
                newName: "IX_Orders_IdTable");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderDish",
                newName: "IdOrder");

            migrationBuilder.RenameColumn(
                name: "DishId",
                table: "OrderDish",
                newName: "IdDish");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDish_OrderId",
                table: "OrderDish",
                newName: "IX_OrderDish_IdOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDish_Dishes_IdDish",
                table: "OrderDish",
                column: "IdDish",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDish_Orders_IdOrder",
                table: "OrderDish",
                column: "IdOrder",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_IdTable",
                table: "Orders",
                column: "IdTable",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
