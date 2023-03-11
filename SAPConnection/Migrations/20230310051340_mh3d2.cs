using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SAPConnection.Migrations
{
    /// <inheritdoc />
    public partial class mh3d2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "Workflows",
                newName: "ApproverRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApproverRole",
                table: "Workflows",
                newName: "ManagerId");
        }
    }
}
