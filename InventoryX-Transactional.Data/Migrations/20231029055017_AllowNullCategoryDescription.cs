using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryX_Transactional.Data.Migrations
{
    /// <inheritdoc />
    public partial class AllowNullCategoryDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 29, 0, 50, 16, 920, DateTimeKind.Local).AddTicks(1276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 21, 58, 24, 552, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 29, 0, 50, 16, 920, DateTimeKind.Local).AddTicks(492),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 28, 21, 58, 24, 551, DateTimeKind.Local).AddTicks(9225));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Provider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 21, 58, 24, 552, DateTimeKind.Local).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 29, 0, 50, 16, 920, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 28, 21, 58, 24, 551, DateTimeKind.Local).AddTicks(9225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 29, 0, 50, 16, 920, DateTimeKind.Local).AddTicks(492));
        }
    }
}
