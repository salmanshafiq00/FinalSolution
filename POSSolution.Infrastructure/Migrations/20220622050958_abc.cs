using Microsoft.EntityFrameworkCore.Migrations;

namespace POSSolution.Infrastructure.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                table: "PurchaseDetails");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseDetails_PurchaseReturnInvoiceId",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "PurchaseReturnInvoiceId",
                table: "PurchaseDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaseReturnInvoiceId",
                table: "PurchaseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PurchaseReturnInvoiceId",
                table: "PurchaseDetails",
                column: "PurchaseReturnInvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                table: "PurchaseDetails",
                column: "PurchaseReturnInvoiceId",
                principalTable: "PurchaseReturnInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
