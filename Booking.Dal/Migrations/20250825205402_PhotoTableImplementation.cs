using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Dal.Migrations
{
    /// <inheritdoc />
    public partial class PhotoTableImplementation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VenuePhotos",
                schema: "dbo");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                schema: "dbo",
                table: "Professionals");

            migrationBuilder.AlterColumn<Guid>(
                name: "VenueId",
                schema: "dbo",
                table: "Professionals",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2)
                .OldAnnotation("Relational:ColumnOrder", 3);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "VenueId",
                schema: "dbo",
                table: "Professionals",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                schema: "dbo",
                table: "Professionals",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.CreateTable(
                name: "VenuePhotos",
                schema: "dbo",
                columns: table => new
                {
                    VenueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AltText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenuePhotos", x => new { x.VenueId, x.Id });
                    table.ForeignKey(
                        name: "FK_VenuePhotos_Venues_VenueId",
                        column: x => x.VenueId,
                        principalSchema: "dbo",
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
