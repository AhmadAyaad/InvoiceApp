using Microsoft.EntityFrameworkCore.Migrations;

namespace InvoiceApp.API.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInvoices",
                table: "ProductInvoices");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductInvoices",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInvoices",
                table: "ProductInvoices",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInvoices_ProductId",
                table: "ProductInvoices",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInvoices",
                table: "ProductInvoices");

            migrationBuilder.DropIndex(
                name: "IX_ProductInvoices_ProductId",
                table: "ProductInvoices");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductInvoices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInvoices",
                table: "ProductInvoices",
                column: "ProductId");
        }
    }
}
