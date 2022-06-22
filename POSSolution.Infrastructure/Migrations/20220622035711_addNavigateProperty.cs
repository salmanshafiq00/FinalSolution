using Microsoft.EntityFrameworkCore.Migrations;

namespace POSSolution.Infrastructure.Migrations
{
    public partial class addNavigateProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "SalesDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_ItemId",
                table: "SalesDetails",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesDetails_Items_ItemId",
                table: "SalesDetails",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesDetails_Items_ItemId",
                table: "SalesDetails");

            migrationBuilder.DropIndex(
                name: "IX_SalesDetails_ItemId",
                table: "SalesDetails");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "SalesDetails");
        }
    }
}
