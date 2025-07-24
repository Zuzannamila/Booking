using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Dal.Migrations
{
    /// <inheritdoc />
    public partial class FixedOwnedEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Venues_OpeningHours",
                schema: "dbo");

            migrationBuilder.AddColumn<string>(
                name: "AddressInformation_City",
                schema: "dbo",
                table: "Venues",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressInformation_Country",
                schema: "dbo",
                table: "Venues",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressInformation_PostalCode",
                schema: "dbo",
                table: "Venues",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressInformation_StateOrProvince",
                schema: "dbo",
                table: "Venues",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressInformation_Street",
                schema: "dbo",
                table: "Venues",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AddressInformation_Unit",
                schema: "dbo",
                table: "Venues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OpeningHours",
                schema: "dbo",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHours", x => new { x.VenueId, x.Id });
                    table.ForeignKey(
                        name: "FK_OpeningHours_Venues_VenueId",
                        column: x => x.VenueId,
                        principalSchema: "dbo",
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OpeningHours",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "AddressInformation_City",
                schema: "dbo",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "AddressInformation_Country",
                schema: "dbo",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "AddressInformation_PostalCode",
                schema: "dbo",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "AddressInformation_StateOrProvince",
                schema: "dbo",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "AddressInformation_Street",
                schema: "dbo",
                table: "Venues");

            migrationBuilder.DropColumn(
                name: "AddressInformation_Unit",
                schema: "dbo",
                table: "Venues");

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "dbo",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StateOrProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Unit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.VenueId);
                    table.ForeignKey(
                        name: "FK_Addresses_Venues_VenueId",
                        column: x => x.VenueId,
                        principalSchema: "dbo",
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venues_OpeningHours",
                schema: "dbo",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues_OpeningHours", x => new { x.VenueId, x.Id });
                    table.ForeignKey(
                        name: "FK_Venues_OpeningHours_Venues_VenueId",
                        column: x => x.VenueId,
                        principalSchema: "dbo",
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
