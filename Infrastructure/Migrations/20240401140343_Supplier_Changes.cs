using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Supplier_Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decorations_Materials_MaterialId",
                table: "Decorations");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_ColorTypes_ColorTypeId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Supplier_SupplierId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColorTypeId",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaterialId",
                table: "Decorations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Decorations_Materials_MaterialId",
                table: "Decorations",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_ColorTypes_ColorTypeId",
                table: "Materials",
                column: "ColorTypeId",
                principalTable: "ColorTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Suppliers_SupplierId",
                table: "Materials",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decorations_Materials_MaterialId",
                table: "Decorations");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_ColorTypes_ColorTypeId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Suppliers_SupplierId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "Materials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColorTypeId",
                table: "Materials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MaterialId",
                table: "Decorations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Decorations_Materials_MaterialId",
                table: "Decorations",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_ColorTypes_ColorTypeId",
                table: "Materials",
                column: "ColorTypeId",
                principalTable: "ColorTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Supplier_SupplierId",
                table: "Materials",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "Id");
        }
    }
}
