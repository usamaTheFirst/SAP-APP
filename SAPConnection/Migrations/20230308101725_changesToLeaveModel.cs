using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAPConnection.Migrations
{
    /// <inheritdoc />
    public partial class changesToLeaveModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "approvalStatus",
                table: "leaveModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "submissionStatus",
                table: "leaveModel",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "approvalStatus",
                table: "leaveModel");

            migrationBuilder.DropColumn(
                name: "submissionStatus",
                table: "leaveModel");
        }
    }
}
