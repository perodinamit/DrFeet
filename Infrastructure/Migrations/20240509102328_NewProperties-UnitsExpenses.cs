using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertiesUnitsExpenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExpensePerUnit",
                table: "Soles",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Units",
                table: "Soles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpensePerUnit",
                table: "Purposes",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Units",
                table: "Purposes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpensePerUnit",
                table: "Linings",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Units",
                table: "Linings",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExpensePerUnit",
                table: "Decorations",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Units",
                table: "Decorations",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpensePerUnit",
                table: "Soles");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "Soles");

            migrationBuilder.DropColumn(
                name: "ExpensePerUnit",
                table: "Purposes");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "Purposes");

            migrationBuilder.DropColumn(
                name: "ExpensePerUnit",
                table: "Linings");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "Linings");

            migrationBuilder.DropColumn(
                name: "ExpensePerUnit",
                table: "Decorations");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "Decorations");
        }
    }
}
