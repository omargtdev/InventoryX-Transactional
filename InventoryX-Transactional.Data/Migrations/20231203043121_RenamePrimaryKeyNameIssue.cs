using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryX_Transactional.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenamePrimaryKeyNameIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReceiptId",
                table: "Issue",
                newName: "IssueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IssueId",
                table: "Issue",
                newName: "ReceiptId");
        }
    }
}
