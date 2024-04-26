using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_Calculation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "CalculationId",
                table: "Shoes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Calculation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculationItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Normativ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalculationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationItem_Calculation_CalculationId",
                        column: x => x.CalculationId,
                        principalTable: "Calculation",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_CalculationId",
                table: "Shoes",
                column: "CalculationId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationItem_CalculationId",
                table: "CalculationItem",
                column: "CalculationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Calculation_CalculationId",
                table: "Shoes",
                column: "CalculationId",
                principalTable: "Calculation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Calculation_CalculationId",
                table: "Shoes");

            migrationBuilder.DropTable(
                name: "CalculationItem");

            migrationBuilder.DropTable(
                name: "Calculation");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_CalculationId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "ExpensePerUnit",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "NumberOfUnits",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "CalculationId",
                table: "Shoes");
        }
    }
}
