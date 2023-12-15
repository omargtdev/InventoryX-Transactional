using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryX_Transactional.Data.Migrations
{
    /// <inheritdoc />
    public partial class IssuesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Warehouse",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReceiptProduct",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipt",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductPrice",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    ReceiptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.ReceiptId);
                    table.ForeignKey(
                        name: "FK_Issue_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssueProduct",
                columns: table => new
                {
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitPriceForSale = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueProduct", x => new { x.IssueId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_IssueProduct_Issue_IssueId",
                        column: x => x.IssueId,
                        principalTable: "Issue",
                        principalColumn: "ReceiptId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssueProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Issue_ClientId",
                table: "Issue",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueProduct_ProductId",
                table: "IssueProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssueProduct");

            migrationBuilder.DropTable(
                name: "Issue");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Warehouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReceiptProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(7195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductPrice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(4293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(1603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
