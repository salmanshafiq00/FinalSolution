using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POSSolution.Infrastructure.Migrations
{
    public partial class purchaseSalesReturn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalesReturnInvoiceId",
                table: "SalesPayments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseReturnInvoiceId",
                table: "PurchasePayments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseReturnInvoiceId",
                table: "PurchaseDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PurchaseReturnInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReturnInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    PurchaseReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ReferencesNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountOnAll = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturnInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnInvoices_CompanyInfos_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnInvoices_PurchaseInvoices_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "PurchaseInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnInvoices_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesReturnInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesReturnInvoiceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    SalesReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountOnAll = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesInvoiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturnInvoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReturnInvoices_CompanyInfos_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "CompanyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReturnInvoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesReturnInvoices_SalesInvoices_SalesInvoiceId",
                        column: x => x.SalesInvoiceId,
                        principalTable: "SalesInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseReturnDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseReturnInvoiceId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseReturnDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseReturnDetails_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                        column: x => x.PurchaseReturnInvoiceId,
                        principalTable: "PurchaseReturnInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesReturnDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalesReturnInvoiceId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesReturnDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesReturnDetails_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesReturnDetails_SalesReturnInvoices_SalesReturnInvoiceId",
                        column: x => x.SalesReturnInvoiceId,
                        principalTable: "SalesReturnInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SalesPayments_SalesReturnInvoiceId",
                table: "SalesPayments",
                column: "SalesReturnInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasePayments_PurchaseReturnInvoiceId",
                table: "PurchasePayments",
                column: "PurchaseReturnInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseDetails_PurchaseReturnInvoiceId",
                table: "PurchaseDetails",
                column: "PurchaseReturnInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnDetails_ItemId",
                table: "PurchaseReturnDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnDetails_PurchaseReturnInvoiceId",
                table: "PurchaseReturnDetails",
                column: "PurchaseReturnInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnInvoices_CompanyId",
                table: "PurchaseReturnInvoices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnInvoices_PurchaseId",
                table: "PurchaseReturnInvoices",
                column: "PurchaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseReturnInvoices_SupplierId",
                table: "PurchaseReturnInvoices",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnDetails_ItemId",
                table: "SalesReturnDetails",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnDetails_SalesReturnInvoiceId",
                table: "SalesReturnDetails",
                column: "SalesReturnInvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnInvoices_CompanyId",
                table: "SalesReturnInvoices",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnInvoices_CustomerId",
                table: "SalesReturnInvoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesReturnInvoices_SalesInvoiceId",
                table: "SalesReturnInvoices",
                column: "SalesInvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseDetails_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                table: "PurchaseDetails",
                column: "PurchaseReturnInvoiceId",
                principalTable: "PurchaseReturnInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PurchasePayments_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                table: "PurchasePayments",
                column: "PurchaseReturnInvoiceId",
                principalTable: "PurchaseReturnInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesPayments_SalesReturnInvoices_SalesReturnInvoiceId",
                table: "SalesPayments",
                column: "SalesReturnInvoiceId",
                principalTable: "SalesReturnInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseDetails_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                table: "PurchaseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PurchasePayments_PurchaseReturnInvoices_PurchaseReturnInvoiceId",
                table: "PurchasePayments");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesPayments_SalesReturnInvoices_SalesReturnInvoiceId",
                table: "SalesPayments");

            migrationBuilder.DropTable(
                name: "PurchaseReturnDetails");

            migrationBuilder.DropTable(
                name: "SalesReturnDetails");

            migrationBuilder.DropTable(
                name: "PurchaseReturnInvoices");

            migrationBuilder.DropTable(
                name: "SalesReturnInvoices");

            migrationBuilder.DropIndex(
                name: "IX_SalesPayments_SalesReturnInvoiceId",
                table: "SalesPayments");

            migrationBuilder.DropIndex(
                name: "IX_PurchasePayments_PurchaseReturnInvoiceId",
                table: "PurchasePayments");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseDetails_PurchaseReturnInvoiceId",
                table: "PurchaseDetails");

            migrationBuilder.DropColumn(
                name: "SalesReturnInvoiceId",
                table: "SalesPayments");

            migrationBuilder.DropColumn(
                name: "PurchaseReturnInvoiceId",
                table: "PurchasePayments");

            migrationBuilder.DropColumn(
                name: "PurchaseReturnInvoiceId",
                table: "PurchaseDetails");
        }
    }
}
