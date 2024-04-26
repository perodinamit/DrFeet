using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_CalcId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalculationItem_Calculation_CalculationId",
                table: "CalculationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Calculation_CalculationId",
                table: "Shoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculationItem",
                table: "CalculationItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculation",
                table: "Calculation");

            migrationBuilder.RenameTable(
                name: "CalculationItem",
                newName: "CalculationItems");

            migrationBuilder.RenameTable(
                name: "Calculation",
                newName: "Calculations");

            migrationBuilder.RenameIndex(
                name: "IX_CalculationItem_CalculationId",
                table: "CalculationItems",
                newName: "IX_CalculationItems_CalculationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculationItems",
                table: "CalculationItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CalculationItems_Calculations_CalculationId",
                table: "CalculationItems",
                column: "CalculationId",
                principalTable: "Calculations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Calculations_CalculationId",
                table: "Shoes",
                column: "CalculationId",
                principalTable: "Calculations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CalculationItems_Calculations_CalculationId",
                table: "CalculationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Calculations_CalculationId",
                table: "Shoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculationItems",
                table: "CalculationItems");

            migrationBuilder.RenameTable(
                name: "Calculations",
                newName: "Calculation");

            migrationBuilder.RenameTable(
                name: "CalculationItems",
                newName: "CalculationItem");

            migrationBuilder.RenameIndex(
                name: "IX_CalculationItems_CalculationId",
                table: "CalculationItem",
                newName: "IX_CalculationItem_CalculationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculation",
                table: "Calculation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculationItem",
                table: "CalculationItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CalculationItem_Calculation_CalculationId",
                table: "CalculationItem",
                column: "CalculationId",
                principalTable: "Calculation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Calculation_CalculationId",
                table: "Shoes",
                column: "CalculationId",
                principalTable: "Calculation",
                principalColumn: "Id");
        }
    }
}
