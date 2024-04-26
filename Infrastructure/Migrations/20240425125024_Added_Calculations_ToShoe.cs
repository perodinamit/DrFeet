using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_Calculations_ToShoe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Calculations_CalculationId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_CalculationId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "CalculationId",
                table: "Shoes");

            migrationBuilder.AddColumn<int>(
                name: "ShoeId",
                table: "Calculations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calculations_ShoeId",
                table: "Calculations",
                column: "ShoeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calculations_Shoes_ShoeId",
                table: "Calculations",
                column: "ShoeId",
                principalTable: "Shoes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calculations_Shoes_ShoeId",
                table: "Calculations");

            migrationBuilder.DropIndex(
                name: "IX_Calculations_ShoeId",
                table: "Calculations");

            migrationBuilder.DropColumn(
                name: "ShoeId",
                table: "Calculations");

            migrationBuilder.AddColumn<int>(
                name: "CalculationId",
                table: "Shoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_CalculationId",
                table: "Shoes",
                column: "CalculationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Calculations_CalculationId",
                table: "Shoes",
                column: "CalculationId",
                principalTable: "Calculations",
                principalColumn: "Id");
        }
    }
}
