using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loterie.Migrations
{
    /// <inheritdoc />
    public partial class EditTicketSessionNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "game",
                table: "Ticket",
                newName: "Game");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Game",
                table: "Ticket",
                newName: "game");
        }
    }
}
