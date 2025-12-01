using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedmodelsandaddednewones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Booking_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Review_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Service_SP_ServiceProviderEntity_ServiceProviderId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropTable(
                name: "SP_ServiceLocation",
                schema: "sp");

            migrationBuilder.DropIndex(
                name: "IX_SP_ServiceProviderEntity_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "ClientId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropColumn(
                name: "LocationId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropColumn(
                name: "Area",
                schema: "sp",
                table: "SP_Location");

            migrationBuilder.DropColumn(
                name: "County",
                schema: "sp",
                table: "SP_Location");

            migrationBuilder.DropColumn(
                name: "Town",
                schema: "sp",
                table: "SP_Location");

            migrationBuilder.RenameColumn(
                name: "ServiceProviderId",
                schema: "sp",
                table: "SP_Service",
                newName: "ServiceProviderEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Service_ServiceProviderId",
                schema: "sp",
                table: "SP_Service",
                newName: "IX_SP_Service_ServiceProviderEntityId");

            migrationBuilder.AddColumn<string>(
                name: "ConstituencyId",
                schema: "sp",
                table: "SP_Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocationName",
                schema: "sp",
                table: "SP_Location",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SP_County",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_County", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP_CustomService",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_CustomService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP_ProviderLocations",
                schema: "sp",
                columns: table => new
                {
                    ServiceProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ProviderLocations", x => new { x.ServiceProviderId, x.LocationId });
                });

            migrationBuilder.CreateTable(
                name: "SP_ProviderServices",
                schema: "sp",
                columns: table => new
                {
                    ServiceProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ProviderServices", x => new { x.ServiceProviderId, x.ServiceId });
                });

            migrationBuilder.CreateTable(
                name: "SP_Constituency",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConstituencyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Constituency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Constituency_SP_County_CountyId",
                        column: x => x.CountyId,
                        principalSchema: "sp",
                        principalTable: "SP_County",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_Constituency_CountyId",
                schema: "sp",
                table: "SP_Constituency",
                column: "CountyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Booking_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Booking",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Review_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Review",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Service_SP_ServiceProviderEntity_ServiceProviderEntityId",
                schema: "sp",
                table: "SP_Service",
                column: "ServiceProviderEntityId",
                principalSchema: "sp",
                principalTable: "SP_ServiceProviderEntity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Booking_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Review_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Service_SP_ServiceProviderEntity_ServiceProviderEntityId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropTable(
                name: "SP_Constituency",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_CustomService",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_ProviderLocations",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_ProviderServices",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_County",
                schema: "sp");

            migrationBuilder.DropColumn(
                name: "ConstituencyId",
                schema: "sp",
                table: "SP_Location");

            migrationBuilder.DropColumn(
                name: "LocationName",
                schema: "sp",
                table: "SP_Location");

            migrationBuilder.RenameColumn(
                name: "ServiceProviderEntityId",
                schema: "sp",
                table: "SP_Service",
                newName: "ServiceProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Service_ServiceProviderEntityId",
                schema: "sp",
                table: "SP_Service",
                newName: "IX_SP_Service_ServiceProviderId");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                schema: "sp",
                table: "SP_Service",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                schema: "sp",
                table: "SP_Service",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                schema: "sp",
                table: "SP_Service",
                type: "decimal(19,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                schema: "sp",
                table: "SP_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "County",
                schema: "sp",
                table: "SP_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Town",
                schema: "sp",
                table: "SP_Location",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SP_ServiceLocation",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ServiceLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_ServiceLocation_SP_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "sp",
                        principalTable: "SP_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP_ServiceLocation_SP_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceProviderEntity_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceLocation_LocationId",
                schema: "sp",
                table: "SP_ServiceLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceLocation_ServiceId",
                schema: "sp",
                table: "SP_ServiceLocation",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Booking_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Booking",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Review_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Review",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Service_SP_ServiceProviderEntity_ServiceProviderId",
                schema: "sp",
                table: "SP_Service",
                column: "ServiceProviderId",
                principalSchema: "sp",
                principalTable: "SP_ServiceProviderEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                column: "LocationId",
                principalSchema: "sp",
                principalTable: "SP_Location",
                principalColumn: "Id");
        }
    }
}
