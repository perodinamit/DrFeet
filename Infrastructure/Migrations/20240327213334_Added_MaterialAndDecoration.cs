using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_MaterialAndDecoration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Tops",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Soles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Shoes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Linings",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UOM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColorTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_ColorTypes_ColorTypeId",
                        column: x => x.ColorTypeId,
                        principalTable: "ColorTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Decorations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decorations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Decorations_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tops_MaterialId",
                table: "Tops",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Soles_MaterialId",
                table: "Soles",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Linings_MaterialId",
                table: "Linings",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Decorations_MaterialId",
                table: "Decorations",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ColorTypeId",
                table: "Materials",
                column: "ColorTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Linings_Materials_MaterialId",
                table: "Linings",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Soles_Materials_MaterialId",
                table: "Soles",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tops_Materials_MaterialId",
                table: "Tops",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Linings_Materials_MaterialId",
                table: "Linings");

            migrationBuilder.DropForeignKey(
                name: "FK_Soles_Materials_MaterialId",
                table: "Soles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tops_Materials_MaterialId",
                table: "Tops");

            migrationBuilder.DropTable(
                name: "Decorations");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Tops_MaterialId",
                table: "Tops");

            migrationBuilder.DropIndex(
                name: "IX_Soles_MaterialId",
                table: "Soles");

            migrationBuilder.DropIndex(
                name: "IX_Linings_MaterialId",
                table: "Linings");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Soles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Linings");
        }
    }
}
