using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TopTableUnitsExpensesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ExpensePerUnit",
                table: "Tops",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NumberOfUnits",
                table: "Tops",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Units",
                table: "Tops",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpensePerUnit",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "NumberOfUnits",
                table: "Tops");

            migrationBuilder.DropColumn(
                name: "Units",
                table: "Tops");
        }
    }
}
