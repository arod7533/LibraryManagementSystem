using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class cleanupcheckouttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chekouts_LibraryAssets_LibraryAssetId",
                table: "Chekouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Chekouts_LibraryCards_LibraryCardId",
                table: "Chekouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_GetLibraryAssetId",
                table: "Holds");

            migrationBuilder.DropIndex(
                name: "IX_Holds_GetLibraryAssetId",
                table: "Holds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chekouts",
                table: "Chekouts");

            migrationBuilder.DropColumn(
                name: "GetLibraryAssetId",
                table: "Holds");

            migrationBuilder.RenameTable(
                name: "Chekouts",
                newName: "Checkouts");

            migrationBuilder.RenameIndex(
                name: "IX_Chekouts_LibraryCardId",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Chekouts_LibraryAssetId",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryAssetId");

            migrationBuilder.AddColumn<int>(
                name: "LibraryAssetId",
                table: "Holds",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkouts",
                table: "Checkouts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                table: "Checkouts",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryCards_LibraryCardId",
                table: "Checkouts",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryCards_LibraryCardId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds");

            migrationBuilder.DropIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Holds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkouts",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "LibraryAssetId",
                table: "Holds");

            migrationBuilder.RenameTable(
                name: "Checkouts",
                newName: "Chekouts");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryCardId",
                table: "Chekouts",
                newName: "IX_Chekouts_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryAssetId",
                table: "Chekouts",
                newName: "IX_Chekouts_LibraryAssetId");

            migrationBuilder.AddColumn<int>(
                name: "GetLibraryAssetId",
                table: "Holds",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chekouts",
                table: "Chekouts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Holds_GetLibraryAssetId",
                table: "Holds",
                column: "GetLibraryAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chekouts_LibraryAssets_LibraryAssetId",
                table: "Chekouts",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chekouts_LibraryCards_LibraryCardId",
                table: "Chekouts",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_GetLibraryAssetId",
                table: "Holds",
                column: "GetLibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
