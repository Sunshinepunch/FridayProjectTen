using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class MachineName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "EngineerMachine");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Machines");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "EngineerMachine",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
