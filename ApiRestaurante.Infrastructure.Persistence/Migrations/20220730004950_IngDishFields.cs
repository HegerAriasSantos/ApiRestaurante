using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiRestaurante.Infrastructure.Persistence.Migrations
{
    public partial class IngDishFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDish_Dishes_IdDish",
                table: "IngredientDish");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDish_Ingredients_IdIngredient",
                table: "IngredientDish");

            migrationBuilder.RenameColumn(
                name: "IdIngredient",
                table: "IngredientDish",
                newName: "IngredientId");

            migrationBuilder.RenameColumn(
                name: "IdDish",
                table: "IngredientDish",
                newName: "DishId");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientDish_IdIngredient",
                table: "IngredientDish",
                newName: "IX_IngredientDish_IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDish_Dishes_DishId",
                table: "IngredientDish",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDish_Ingredients_IngredientId",
                table: "IngredientDish",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDish_Dishes_DishId",
                table: "IngredientDish");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDish_Ingredients_IngredientId",
                table: "IngredientDish");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "IngredientDish",
                newName: "IdIngredient");

            migrationBuilder.RenameColumn(
                name: "DishId",
                table: "IngredientDish",
                newName: "IdDish");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientDish_IngredientId",
                table: "IngredientDish",
                newName: "IX_IngredientDish_IdIngredient");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDish_Dishes_IdDish",
                table: "IngredientDish",
                column: "IdDish",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDish_Ingredients_IdIngredient",
                table: "IngredientDish",
                column: "IdIngredient",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
