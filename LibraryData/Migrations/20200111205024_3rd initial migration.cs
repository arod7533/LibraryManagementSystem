using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class _3rdinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addres",
                table: "LibraryBranches");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "LibraryBranches",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "LibraryBranches");

            migrationBuilder.AddColumn<string>(
                name: "Addres",
                table: "LibraryBranches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
