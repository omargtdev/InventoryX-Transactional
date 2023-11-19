using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryX_Transactional.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingRefferralGuideToReceipt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Warehouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReceiptProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(7195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(5414));

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPurchasePrice",
                table: "ReceiptProduct",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.AddColumn<string>(
                name: "ReferralGuideFileName",
                table: "Receipt",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductPrice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5051),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(4293),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(1603),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(3298));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPurchasePrice",
                table: "ReceiptProduct");

            migrationBuilder.DropColumn(
                name: "ReferralGuideFileName",
                table: "Receipt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Warehouse",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(3909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ReceiptProduct",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(5414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(5012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(3570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "ProductPrice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(4834),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(4495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 5, 15, 39, 12, 584, DateTimeKind.Local).AddTicks(3298),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 19, 0, 7, 38, 746, DateTimeKind.Local).AddTicks(1603));
        }
    }
}
