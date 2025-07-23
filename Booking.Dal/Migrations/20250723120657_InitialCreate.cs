using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Dal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    Service_VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Service_IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Venue_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressInformation_Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressInformation_Unit = table.Column<int>(type: "int", nullable: true),
                    AddressInformation_PostalCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressInformation_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressInformation_StateOrProvince = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressInformation_Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Venue_IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Start = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    End = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: true),
                    Visit_VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ClientId",
                        column: x => x.ClientId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Service_VenueId",
                        column: x => x.Service_VenueId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_VenueId",
                        column: x => x.VenueId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Visit_VenueId",
                        column: x => x.Visit_VenueId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaseEntity_OpeningHours",
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
                    table.PrimaryKey("PK_BaseEntity_OpeningHours", x => new { x.VenueId, x.Id });
                    table.ForeignKey(
                        name: "FK_BaseEntity_OpeningHours_BaseEntity_VenueId",
                        column: x => x.VenueId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSchedule",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Availability_Day = table.Column<int>(type: "int", nullable: true),
                    Availability_Start = table.Column<TimeSpan>(type: "time", nullable: true),
                    Availability_End = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSchedule", x => new { x.EmployeeId, x.Id });
                    table.ForeignKey(
                        name: "FK_EmployeeSchedule_BaseEntity_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenuePhoto",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AltText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenuePhoto", x => new { x.VenueId, x.Id });
                    table.ForeignKey(
                        name: "FK_VenuePhoto_BaseEntity_VenueId",
                        column: x => x.VenueId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ClientId",
                table: "BaseEntity",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Email",
                table: "BaseEntity",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_EmployeeId",
                table: "BaseEntity",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Service_VenueId",
                table: "BaseEntity",
                column: "Service_VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ServiceId",
                table: "BaseEntity",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_VenueId",
                table: "BaseEntity",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Visit_VenueId",
                table: "BaseEntity",
                column: "Visit_VenueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntity_OpeningHours");

            migrationBuilder.DropTable(
                name: "EmployeeSchedule");

            migrationBuilder.DropTable(
                name: "VenuePhoto");

            migrationBuilder.DropTable(
                name: "BaseEntity");
        }
    }
}
