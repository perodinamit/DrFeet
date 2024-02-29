using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedLookupTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<int>(
                name: "ColorTypeId",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiningId",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PurposeId",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SoleId",
                table: "Shoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ColorTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Linings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Soles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soles", x => x.Id);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Shoes_ColorTypeId",
                table: "Shoes",
                column: "ColorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_LiningId",
                table: "Shoes",
                column: "LiningId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_PurposeId",
                table: "Shoes",
                column: "PurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_SoleId",
                table: "Shoes",
                column: "SoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_ColorTypes_ColorTypeId",
                table: "Shoes",
                column: "ColorTypeId",
                principalTable: "ColorTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Linings_LiningId",
                table: "Shoes",
                column: "LiningId",
                principalTable: "Linings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Purposes_PurposeId",
                table: "Shoes",
                column: "PurposeId",
                principalTable: "Purposes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Soles_SoleId",
                table: "Shoes",
                column: "SoleId",
                principalTable: "Soles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

         
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_ColorTypes_ColorTypeId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Linings_LiningId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Purposes_PurposeId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Soles_SoleId",
                table: "Shoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tops_ColorTypes_ColorId",
                table: "Tops");

            migrationBuilder.DropTable(
                name: "ColorTypes");

            migrationBuilder.DropTable(
                name: "Linings");

            migrationBuilder.DropTable(
                name: "Purposes");

            migrationBuilder.DropTable(
                name: "Soles");

            migrationBuilder.DropIndex(
                name: "IX_Tops_ColorId",
                table: "Tops");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_ColorTypeId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_LiningId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_PurposeId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_SoleId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "ColorTypeId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "LiningId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "PurposeId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "SoleId",
                table: "Shoes");
        }
    }
}
