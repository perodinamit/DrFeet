using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ShoeTableCoeficientsadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LiningCoeficient",
                table: "Shoes",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PurposeCoeficient",
                table: "Shoes",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SoleCoeficient",
                table: "Shoes",
                type: "decimal(6,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TopCoeficient",
                table: "Shoes",
                type: "decimal(6,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LiningCoeficient",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "PurposeCoeficient",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "SoleCoeficient",
                table: "Shoes");

            migrationBuilder.DropColumn(
                name: "TopCoeficient",
                table: "Shoes");
        }
    }
}
