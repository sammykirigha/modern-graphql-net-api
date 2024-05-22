using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ServiceProviderClientId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                schema: "sp",
                table: "SP_Client",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_Client_ServiceId",
                schema: "sp",
                table: "SP_Client",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Client_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Client",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ClientsServices_SP_Client_ClientId",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "ClientId",
                principalSchema: "sp",
                principalTable: "SP_Client",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ClientsServices_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Client_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Client");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ClientsServices_SP_Client_ClientId",
                schema: "sp",
                table: "SP_ClientsServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ClientsServices_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ClientsServices");

            migrationBuilder.DropIndex(
                name: "IX_SP_Client_ServiceId",
                schema: "sp",
                table: "SP_Client");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                schema: "sp",
                table: "SP_Client");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceProviderClientId",
                schema: "sp",
                table: "SP_Service",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
