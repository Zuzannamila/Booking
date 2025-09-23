using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Dal.Migrations
{
    /// <inheritdoc />
    public partial class RemovePhotoNavigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Venues_VenueId",
                schema: "dbo",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professionals_Photos_PhotoId",
                schema: "dbo",
                table: "Professionals");

            migrationBuilder.DropIndex(
                name: "IX_Professionals_PhotoId",
                schema: "dbo",
                table: "Professionals");

            migrationBuilder.DropIndex(
                name: "IX_Photos_VenueId",
                schema: "dbo",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                schema: "dbo",
                table: "Professionals");

            migrationBuilder.DropColumn(
                name: "VenueId",
                schema: "dbo",
                table: "Photos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PhotoId",
                schema: "dbo",
                table: "Professionals",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VenueId",
                schema: "dbo",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Professionals_PhotoId",
                schema: "dbo",
                table: "Professionals",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_VenueId",
                schema: "dbo",
                table: "Photos",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Venues_VenueId",
                schema: "dbo",
                table: "Photos",
                column: "VenueId",
                principalSchema: "dbo",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professionals_Photos_PhotoId",
                schema: "dbo",
                table: "Professionals",
                column: "PhotoId",
                principalSchema: "dbo",
                principalTable: "Photos",
                principalColumn: "Id");
        }
    }
}
