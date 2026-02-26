using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersAndRegistrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registration_Events_EventId",
                table: "Registration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registration",
                table: "Registration");

            migrationBuilder.RenameTable(
                name: "Registration",
                newName: "Registrations");

            migrationBuilder.RenameIndex(
                name: "IX_Registration_EventId",
                table: "Registrations",
                newName: "IX_Registrations_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Events_EventId",
                table: "Registrations",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Events_EventId",
                table: "Registrations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Registrations",
                table: "Registrations");

            migrationBuilder.RenameTable(
                name: "Registrations",
                newName: "Registration");

            migrationBuilder.RenameIndex(
                name: "IX_Registrations_EventId",
                table: "Registration",
                newName: "IX_Registration_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registration",
                table: "Registration",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registration_Events_EventId",
                table: "Registration",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
