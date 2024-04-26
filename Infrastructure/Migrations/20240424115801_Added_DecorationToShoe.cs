using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_DecorationToShoe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DecorationId",
                table: "Shoes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Calculations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shoes_DecorationId",
                table: "Shoes",
                column: "DecorationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shoes_Decorations_DecorationId",
                table: "Shoes",
                column: "DecorationId",
                principalTable: "Decorations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shoes_Decorations_DecorationId",
                table: "Shoes");

            migrationBuilder.DropIndex(
                name: "IX_Shoes_DecorationId",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "DecorationId",
                table: "Shoes");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Calculations",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
