using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAPConnection.Migrations
{
    /// <inheritdoc />
    public partial class abcd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leaveModel_Approvers_RouteIdId",
                table: "leaveModel");

            migrationBuilder.DropIndex(
                name: "IX_leaveModel_RouteIdId",
                table: "leaveModel");

            migrationBuilder.RenameColumn(
                name: "RouteIdId",
                table: "leaveModel",
                newName: "RouteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "leaveModel",
                newName: "RouteIdId");

            migrationBuilder.CreateIndex(
                name: "IX_leaveModel_RouteIdId",
                table: "leaveModel",
                column: "RouteIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_leaveModel_Approvers_RouteIdId",
                table: "leaveModel",
                column: "RouteIdId",
                principalTable: "Approvers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
