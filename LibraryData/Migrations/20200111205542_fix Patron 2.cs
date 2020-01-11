using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class fixPatron2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_LibaryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibaryCardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibaryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibaryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibaryBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibaryCardId",
                table: "Patrons");

            migrationBuilder.AddColumn<int>(
                name: "LibraryBranchId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryCardId",
                table: "Patrons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryCardId",
                table: "Patrons");

            migrationBuilder.AddColumn<int>(
                name: "LibaryBranchId",
                table: "Patrons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibaryCardId",
                table: "Patrons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibaryBranchId",
                table: "Patrons",
                column: "LibaryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibaryCardId",
                table: "Patrons",
                column: "LibaryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_LibaryBranchId",
                table: "Patrons",
                column: "LibaryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibaryCardId",
                table: "Patrons",
                column: "LibaryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
