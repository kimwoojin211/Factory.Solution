using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class ExtraProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Busy",
                table: "Engineers",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Busy",
                table: "Engineers");
        }
    }
}
