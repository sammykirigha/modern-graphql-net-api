using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateddatabasewithnewmodelsandchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Discount",
                schema: "sp",
                table: "SP_Plan");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceProviderId",
                schema: "sp",
                table: "SP_Service",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewId",
                schema: "sp",
                table: "SP_LoginLog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewId",
                schema: "sp",
                table: "SP_ErrorLog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewId1",
                schema: "sp",
                table: "SP_ErrorLog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewId",
                schema: "sp",
                table: "SP_EntityLog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewId1",
                schema: "sp",
                table: "SP_EntityLog",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                schema: "sp",
                table: "SP_Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SP_ServiceProviderEntity",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ServiceProviderEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_ServiceProviderEntity_SP_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "sp",
                        principalTable: "SP_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SP_Booking",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    AcceptedAt = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    CancelledAt = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    CancellationReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Booking_SP_ServiceProviderEntity_ServiceProviderId",
                        column: x => x.ServiceProviderId,
                        principalSchema: "sp",
                        principalTable: "SP_ServiceProviderEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SP_Booking_SP_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SP_Booking_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_Review",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    verifiedTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Review_SP_Booking_BookingId",
                        column: x => x.BookingId,
                        principalSchema: "sp",
                        principalTable: "SP_Booking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_Review_SP_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SP_Review_SP_User_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_Service_ServiceProviderId",
                schema: "sp",
                table: "SP_Service",
                column: "ServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_LoginLog_ReviewId",
                schema: "sp",
                table: "SP_LoginLog",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ErrorLog_ReviewId",
                schema: "sp",
                table: "SP_ErrorLog",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ErrorLog_ReviewId1",
                schema: "sp",
                table: "SP_ErrorLog",
                column: "ReviewId1");

            migrationBuilder.CreateIndex(
                name: "IX_SP_EntityLog_ReviewId",
                schema: "sp",
                table: "SP_EntityLog",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_EntityLog_ReviewId1",
                schema: "sp",
                table: "SP_EntityLog",
                column: "ReviewId1");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Booking_ServiceId",
                schema: "sp",
                table: "SP_Booking",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Booking_ServiceProviderId",
                schema: "sp",
                table: "SP_Booking",
                column: "ServiceProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Booking_UserId",
                schema: "sp",
                table: "SP_Booking",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Review_BookingId",
                schema: "sp",
                table: "SP_Review",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Review_CustomerId",
                schema: "sp",
                table: "SP_Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Review_ServiceId",
                schema: "sp",
                table: "SP_Review",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceProviderEntity_Email",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceProviderEntity_LocationId",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_EntityLog_SP_Review_ReviewId",
                schema: "sp",
                table: "SP_EntityLog",
                column: "ReviewId",
                principalSchema: "sp",
                principalTable: "SP_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_EntityLog_SP_Review_ReviewId1",
                schema: "sp",
                table: "SP_EntityLog",
                column: "ReviewId1",
                principalSchema: "sp",
                principalTable: "SP_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ErrorLog_SP_Review_ReviewId",
                schema: "sp",
                table: "SP_ErrorLog",
                column: "ReviewId",
                principalSchema: "sp",
                principalTable: "SP_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ErrorLog_SP_Review_ReviewId1",
                schema: "sp",
                table: "SP_ErrorLog",
                column: "ReviewId1",
                principalSchema: "sp",
                principalTable: "SP_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_LoginLog_SP_Review_ReviewId",
                schema: "sp",
                table: "SP_LoginLog",
                column: "ReviewId",
                principalSchema: "sp",
                principalTable: "SP_Review",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Service_SP_ServiceProviderEntity_ServiceProviderId",
                schema: "sp",
                table: "SP_Service",
                column: "ServiceProviderId",
                principalSchema: "sp",
                principalTable: "SP_ServiceProviderEntity",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_EntityLog_SP_Review_ReviewId",
                schema: "sp",
                table: "SP_EntityLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_EntityLog_SP_Review_ReviewId1",
                schema: "sp",
                table: "SP_EntityLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ErrorLog_SP_Review_ReviewId",
                schema: "sp",
                table: "SP_ErrorLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ErrorLog_SP_Review_ReviewId1",
                schema: "sp",
                table: "SP_ErrorLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_LoginLog_SP_Review_ReviewId",
                schema: "sp",
                table: "SP_LoginLog");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Service_SP_ServiceProviderEntity_ServiceProviderId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Subscription_SP_ServiceProviderEntity_ServiceProviderId",
                schema: "sp",
                table: "SP_Subscription");

            migrationBuilder.DropTable(
                name: "SP_Review",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_Booking",
                schema: "sp");

            migrationBuilder.DropTable(
                name: "SP_ServiceProviderEntity",
                schema: "sp");

            migrationBuilder.DropIndex(
                name: "IX_SP_Service_ServiceProviderId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropIndex(
                name: "IX_SP_LoginLog_ReviewId",
                schema: "sp",
                table: "SP_LoginLog");

            migrationBuilder.DropIndex(
                name: "IX_SP_ErrorLog_ReviewId",
                schema: "sp",
                table: "SP_ErrorLog");

            migrationBuilder.DropIndex(
                name: "IX_SP_ErrorLog_ReviewId1",
                schema: "sp",
                table: "SP_ErrorLog");

            migrationBuilder.DropIndex(
                name: "IX_SP_EntityLog_ReviewId",
                schema: "sp",
                table: "SP_EntityLog");

            migrationBuilder.DropIndex(
                name: "IX_SP_EntityLog_ReviewId1",
                schema: "sp",
                table: "SP_EntityLog");

            migrationBuilder.DropColumn(
                name: "ServiceProviderId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                schema: "sp",
                table: "SP_LoginLog");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                schema: "sp",
                table: "SP_ErrorLog");

            migrationBuilder.DropColumn(
                name: "ReviewId1",
                schema: "sp",
                table: "SP_ErrorLog");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                schema: "sp",
                table: "SP_EntityLog");

            migrationBuilder.DropColumn(
                name: "ReviewId1",
                schema: "sp",
                table: "SP_EntityLog");

            migrationBuilder.DropColumn(
                name: "Slug",
                schema: "sp",
                table: "SP_Category");

            migrationBuilder.RenameColumn(
                name: "ServiceProviderId",
                schema: "sp",
                table: "SP_Subscription",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Subscription_ServiceProviderId",
                schema: "sp",
                table: "SP_Subscription",
                newName: "IX_SP_Subscription_UserId");

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                schema: "sp",
                table: "SP_Plan",
                type: "decimal(19,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "SP_Client",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_Client_SP_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "sp",
                        principalTable: "SP_Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP_Client_SP_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_SubscriptionPayments",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_SubscriptionPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_SubscriptionPayments_SP_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalSchema: "sp",
                        principalTable: "SP_Payment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_SubscriptionPayments_SP_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalSchema: "sp",
                        principalTable: "SP_Subscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SP_ClientsServices",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ClientsServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_ClientsServices_SP_Client_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "sp",
                        principalTable: "SP_Client",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_ClientsServices_SP_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_Client_Email",
                schema: "sp",
                table: "SP_Client",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_Client_LocationId",
                schema: "sp",
                table: "SP_Client",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Client_ServiceId",
                schema: "sp",
                table: "SP_Client",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ClientsServices_ClientId",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ClientsServices_ServiceId",
                schema: "sp",
                table: "SP_ClientsServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_SubscriptionPayments_PaymentId",
                schema: "sp",
                table: "SP_SubscriptionPayments",
                column: "PaymentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_SubscriptionPayments_SubscriptionId",
                schema: "sp",
                table: "SP_SubscriptionPayments",
                column: "SubscriptionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Subscription_SP_User_UserId",
                schema: "sp",
                table: "SP_Subscription",
                column: "UserId",
                principalSchema: "sp",
                principalTable: "SP_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
