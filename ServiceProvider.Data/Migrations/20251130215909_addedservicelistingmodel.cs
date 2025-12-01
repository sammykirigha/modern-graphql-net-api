using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedservicelistingmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Booking_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Review_SP_Booking_BookingId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Review_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropIndex(
                name: "IX_SP_Review_BookingId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropColumn(
                name: "BookingId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropColumn(
                name: "verifiedTransactionId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                schema: "sp",
                table: "SP_Review",
                newName: "ServiceListingId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Review_ServiceId",
                schema: "sp",
                table: "SP_Review",
                newName: "IX_SP_Review_ServiceListingId");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                schema: "sp",
                table: "SP_Booking",
                newName: "ServiceListingId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Booking_ServiceId",
                schema: "sp",
                table: "SP_Booking",
                newName: "IX_SP_Booking_ServiceListingId");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_ProviderServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ConstituencyId",
                schema: "sp",
                table: "SP_Location",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                schema: "sp",
                table: "SP_Booking",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "SP_ServiceListing",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BasePrice = table.Column<double>(type: "float", nullable: true),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceProviderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentMode = table.Column<byte>(type: "tinyint", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ServiceListing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_ServiceListing_SP_CustomService_CustomServiceId",
                        column: x => x.CustomServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_CustomService",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SP_ServiceListing_SP_ServiceProviderEntity_ServiceProviderId",
                        column: x => x.ServiceProviderId,
                        principalSchema: "sp",
                        principalTable: "SP_ServiceProviderEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP_ServiceListing_SP_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalSchema: "sp",
                        principalTable: "SP_Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_County",
                columns: new[] { "Id", "CountyName", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("05e42c00-0d43-4f8c-b298-6197b59a7c5a"), "WAJIR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0c92ad83-1cae-4564-9745-19bd589dc0ec"), "TRANS NZOIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0f6bfba1-9147-495c-91de-607be4ce8d98"), "NAROK", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1375ea45-3e76-4e59-8aa4-e00223562079"), "NAIROBI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("260fbbe6-4b60-497b-9d87-5be144a26744"), "MARSABIT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("27a81b5e-79d3-413e-84a5-a9e1a1e4bcad"), "SIAYA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("31952a88-8a7f-4bee-a13d-dbb6e1f16e60"), "BOMET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("32c68bda-8bfa-4e8a-bf4e-f3ee4ec7524a"), "WEST POKOT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("333bccd2-e9d2-488e-865e-30747007e8ab"), "KILIFI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("435f9701-8099-431d-973c-92fac09b8138"), "KERICHO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("45d5300c-06e8-461e-875b-e534d4ac5fdb"), "TAITA TAVETA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("480b37bf-ddaa-441f-a85e-51cf6bc25009"), "GARISSA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4b16ba9a-f1fd-4021-95dc-0f62838b147c"), "KISII", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4bf38bdc-8991-4085-a797-83fc8f29306d"), "EMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5980635a-d32f-45f6-902f-89e8b3f52b25"), "NYANDARUA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5ac861e4-c35a-4aec-a595-140abf57615e"), "NYERI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5adf4af9-33e4-4e94-b6d5-52031ad18926"), "BUNGOMA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5cc690b1-c1e6-4943-9f83-33b3eb526d51"), "LAIKIPIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5dca870b-b1bd-4864-8a1f-1ec3c45c4fed"), "MANDERA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5fd40543-0f23-41d3-a27a-153722619144"), "LAMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("659fb76c-ccf6-400d-b402-dfc7bc4914db"), "KWALE", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("74c3647b-1ec0-4d43-a5ec-cd741efc8b89"), "NYAMIRA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7cb2a86a-000c-491e-b533-ffc4f0afd58a"), "NAKURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7e849cf0-01f2-4f4d-ba21-48bac890fcd3"), "BARINGO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("809fb497-8ea5-41cf-9947-52252b9d4a0d"), "MIGORI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("846ee2dc-5796-45fa-89b7-8ba56840905c"), "BUSIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("88fa40c0-3a9d-4781-8ddf-e42ba55d8d87"), "KIRINYAGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9252581a-26cd-4dd4-8598-8ad606833bbb"), "KIAMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("94f2f4c5-ddf6-48f1-bdb5-902c6954eefd"), "KAJIADO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9e70507f-36e1-4dc4-91cd-56da976dd6ad"), "TANA RIVER", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9eadb99e-ed71-4e89-a313-de7d6849b690"), "HOMA BAY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a13a2ada-21f7-4ba1-b248-5123bb1ea245"), "VIHIGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("aacb62ee-3d24-486c-a97b-2109bead3d84"), "THARAKA-NITHI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("aff8c339-ee07-4287-b6c0-a38bec68ae3e"), "ELGEYO/MARAKWET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc0aa0a7-2773-4975-9168-f023d32ea1fa"), "MOMBASA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c1c3b126-38e0-49cb-8ff9-14e78af8590a"), "SAMBURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c2d6d3e4-77eb-4e20-90d0-514cd8ea7e60"), "MAKUENI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c2f78708-619c-460c-b6fa-54bc3195bc25"), "MERU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c779d704-8ae4-42ac-bdb0-b68b36b92e8e"), "MACHAKOS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c8c5136c-da3e-4712-aa3e-56d514480fc6"), "UASIN GISHU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ccf5cc04-9bf0-479d-aa99-f1b22b189ce0"), "KITUI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e924bfdd-acb6-45d3-a784-e4bdf4f1918d"), "NANDI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee847901-b1d6-4cfd-bba4-204c64745298"), "KISUMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f3c7e49b-511a-421b-a20b-1f2abe98f68a"), "KAKAMEGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f9b44c46-1901-4d6d-b0ca-058ee2aeaaa5"), "MURANG'A", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("faa47f9a-6939-4a9c-a248-81ebbf3a21ca"), "ISIOLO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fc5a5586-023b-4c85-b9d5-bc32d12c1749"), "TURKANA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListing_CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "CustomServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListing_ServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListing_ServiceProviderId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "ServiceProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Booking_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Booking",
                column: "ServiceListingId",
                principalSchema: "sp",
                principalTable: "SP_ServiceListing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Review_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Review",
                column: "ServiceListingId",
                principalSchema: "sp",
                principalTable: "SP_ServiceListing",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Booking_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_Review_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Review");

            migrationBuilder.DropTable(
                name: "SP_ServiceListing",
                schema: "sp");

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("05e42c00-0d43-4f8c-b298-6197b59a7c5a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0c92ad83-1cae-4564-9745-19bd589dc0ec"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0f6bfba1-9147-495c-91de-607be4ce8d98"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("1375ea45-3e76-4e59-8aa4-e00223562079"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("260fbbe6-4b60-497b-9d87-5be144a26744"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("27a81b5e-79d3-413e-84a5-a9e1a1e4bcad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("31952a88-8a7f-4bee-a13d-dbb6e1f16e60"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("32c68bda-8bfa-4e8a-bf4e-f3ee4ec7524a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("333bccd2-e9d2-488e-865e-30747007e8ab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("435f9701-8099-431d-973c-92fac09b8138"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("45d5300c-06e8-461e-875b-e534d4ac5fdb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("480b37bf-ddaa-441f-a85e-51cf6bc25009"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("4b16ba9a-f1fd-4021-95dc-0f62838b147c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("4bf38bdc-8991-4085-a797-83fc8f29306d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5980635a-d32f-45f6-902f-89e8b3f52b25"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5ac861e4-c35a-4aec-a595-140abf57615e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5adf4af9-33e4-4e94-b6d5-52031ad18926"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5cc690b1-c1e6-4943-9f83-33b3eb526d51"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5dca870b-b1bd-4864-8a1f-1ec3c45c4fed"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5fd40543-0f23-41d3-a27a-153722619144"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("659fb76c-ccf6-400d-b402-dfc7bc4914db"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("74c3647b-1ec0-4d43-a5ec-cd741efc8b89"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("7cb2a86a-000c-491e-b533-ffc4f0afd58a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("7e849cf0-01f2-4f4d-ba21-48bac890fcd3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("809fb497-8ea5-41cf-9947-52252b9d4a0d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("846ee2dc-5796-45fa-89b7-8ba56840905c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("88fa40c0-3a9d-4781-8ddf-e42ba55d8d87"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9252581a-26cd-4dd4-8598-8ad606833bbb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("94f2f4c5-ddf6-48f1-bdb5-902c6954eefd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9e70507f-36e1-4dc4-91cd-56da976dd6ad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9eadb99e-ed71-4e89-a313-de7d6849b690"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("a13a2ada-21f7-4ba1-b248-5123bb1ea245"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("aacb62ee-3d24-486c-a97b-2109bead3d84"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("aff8c339-ee07-4287-b6c0-a38bec68ae3e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("bc0aa0a7-2773-4975-9168-f023d32ea1fa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c1c3b126-38e0-49cb-8ff9-14e78af8590a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c2d6d3e4-77eb-4e20-90d0-514cd8ea7e60"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c2f78708-619c-460c-b6fa-54bc3195bc25"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c779d704-8ae4-42ac-bdb0-b68b36b92e8e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c8c5136c-da3e-4712-aa3e-56d514480fc6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ccf5cc04-9bf0-479d-aa99-f1b22b189ce0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e924bfdd-acb6-45d3-a784-e4bdf4f1918d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ee847901-b1d6-4cfd-bba4-204c64745298"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f3c7e49b-511a-421b-a20b-1f2abe98f68a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f9b44c46-1901-4d6d-b0ca-058ee2aeaaa5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("faa47f9a-6939-4a9c-a248-81ebbf3a21ca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("fc5a5586-023b-4c85-b9d5-bc32d12c1749"));

            migrationBuilder.DropColumn(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_ProviderServices");

            migrationBuilder.RenameColumn(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_Review",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Review_ServiceListingId",
                schema: "sp",
                table: "SP_Review",
                newName: "IX_SP_Review_ServiceId");

            migrationBuilder.RenameColumn(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_Booking",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_SP_Booking_ServiceListingId",
                schema: "sp",
                table: "SP_Booking",
                newName: "IX_SP_Booking_ServiceId");

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                schema: "sp",
                table: "SP_Review",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "TransactionType",
                schema: "sp",
                table: "SP_Review",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "verifiedTransactionId",
                schema: "sp",
                table: "SP_Review",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ConstituencyId",
                schema: "sp",
                table: "SP_Location",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "sp",
                table: "SP_Booking",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Review_BookingId",
                schema: "sp",
                table: "SP_Review",
                column: "BookingId");

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
                name: "FK_SP_Review_SP_Booking_BookingId",
                schema: "sp",
                table: "SP_Review",
                column: "BookingId",
                principalSchema: "sp",
                principalTable: "SP_Booking",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Review_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_Review",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id");
        }
    }
}
