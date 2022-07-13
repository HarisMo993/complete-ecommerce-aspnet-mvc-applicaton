using Microsoft.EntityFrameworkCore.Migrations;

namespace eTickets.Migrations
{
    public partial class FixFullNamePropertyInActorAndProducer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FUllName",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "FUllName",
                table: "Actors",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "FUllName");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FUllName");
        }
    }
}
