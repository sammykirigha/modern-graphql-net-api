using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SP_Category",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP_Location",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    County = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Town = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SP_Service",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Service_SP_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "sp",
                        principalTable: "SP_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SP_ServiceLocation",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                name: "IX_SP_Service_CategoryId",
                schema: "sp",
                table: "SP_Service",
                column: "CategoryId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP_ServiceLocation",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_Location",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_Service",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_Category",
                schema: "sp");
        }
    }
}
