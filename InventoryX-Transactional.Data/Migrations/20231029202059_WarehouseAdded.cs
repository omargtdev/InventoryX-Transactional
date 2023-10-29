using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryX_Transactional.Data.Migrations
{
    /// <inheritdoc />
    public partial class WarehouseAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 29, 15, 20, 59, 112, DateTimeKind.Local).AddTicks(9255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 29, 0, 51, 54, 787, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 29, 15, 20, 59, 112, DateTimeKind.Local).AddTicks(8914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 29, 0, 51, 54, 787, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "int", unicode: false, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxStock = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 29, 15, 20, 59, 112, DateTimeKind.Local).AddTicks(9533)),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.WarehouseId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 29, 0, 51, 54, 787, DateTimeKind.Local).AddTicks(4714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 29, 15, 20, 59, 112, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 29, 0, 51, 54, 787, DateTimeKind.Local).AddTicks(3869),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 29, 15, 20, 59, 112, DateTimeKind.Local).AddTicks(8914));
        }
    }
}
