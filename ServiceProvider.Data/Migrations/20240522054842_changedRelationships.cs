using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientServices_SP_Client_ClientId",
                schema: "sp",
                table: "ClientServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientServices_SP_Service_ServiceId",
                schema: "sp",
                table: "ClientServices");

            migrationBuilder.DropTable(
                name: "SP_Plan",
                schema: "sp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientServices",
                schema: "sp",
                table: "ClientServices");

            migrationBuilder.RenameTable(
                name: "ClientServices",
                schema: "sp",
                newName: "SP_ClientsServices",
                newSchema: "sp");

            migrationBuilder.RenameIndex(
                name: "IX_ClientServices_ServiceId",
                schema: "sp",
                table: "SP_ClientsServices",
                newName: "IX_SP_ClientsServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_ClientServices_ClientId",
                schema: "sp",
                table: "SP_ClientsServices",
                newName: "IX_SP_ClientsServices_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SP_ClientsServices",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ClientService",
                schema: "sp",
                columns: table => new
                {
                    ClientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientService", x => new { x.ClientsId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_ClientService_SP_Client_ClientsId",
                        column: x => x.ClientsId,
                        principalSchema: "sp",
                        principalTable: "SP_Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientService_SP_Service_ServicesId",
                        column: x => x.ServicesId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientService_ServicesId",
                schema: "sp",
                table: "ClientService",
                column: "ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ClientsServices_SP_Client_ClientId",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "ClientId",
                principalSchema: "sp",
                principalTable: "SP_Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ClientsServices_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_ClientsServices_SP_Client_ClientId",
                schema: "sp",
                table: "SP_ClientsServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ClientsServices_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ClientsServices");

            migrationBuilder.DropTable(
                name: "ClientService",
                schema: "sp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SP_ClientsServices",
                schema: "sp",
                table: "SP_ClientsServices");

            migrationBuilder.RenameTable(
                name: "SP_ClientsServices",
                schema: "sp",
                newName: "ClientServices",
                newSchema: "sp");

            migrationBuilder.RenameIndex(
                name: "IX_SP_ClientsServices_ServiceId",
                schema: "sp",
                table: "ClientServices",
                newName: "IX_ClientServices_ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_ClientsServices_ClientId",
                schema: "sp",
                table: "ClientServices",
                newName: "IX_ClientServices_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientServices",
                schema: "sp",
                table: "ClientServices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SP_Plan",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(19,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Plan", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ClientServices_SP_Client_ClientId",
                schema: "sp",
                table: "ClientServices",
                column: "ClientId",
                principalSchema: "sp",
                principalTable: "SP_Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientServices_SP_Service_ServiceId",
                schema: "sp",
                table: "ClientServices",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
