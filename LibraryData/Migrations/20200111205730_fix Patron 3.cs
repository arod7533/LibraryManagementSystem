using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class fixPatron3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "Patrons");

            migrationBuilder.AddColumn<int>(
                name: "HomeLibraryBranchId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "Patrons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
