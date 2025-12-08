using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class newMigrationswithallchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Service_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ServiceListing_SP_CustomService_CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SP_ServiceListingsServices",
                schema: "sp",
                table: "SP_ServiceListingsServices");

            migrationBuilder.DropIndex(
                name: "IX_SP_ServiceListing_CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DropIndex(
                name: "IX_SP_Service_ServiceListingId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("642de52e-39c6-4912-847e-a8565ed82e76"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("9c8bef09-0f7e-44ca-a68e-ad7747cb7363"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("a3aaf6e4-1b6d-47d5-9800-9e9f51e2b148"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("c53751c3-0dc5-47e2-b7f7-c883fbe97614"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("00f2e6d0-e477-4a15-bf5c-081e11b87820"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("02f2d11e-ce0b-4769-9262-1c19d63344fa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0351d6f1-4275-4349-bd78-0486b8031f31"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("055a397c-079f-4845-b956-73b59064774c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("060b9812-e498-4f9b-9782-90287200673d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("06b9dff2-1666-4ee0-b7f7-c200d070b7a6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("09794c49-9ca3-4a3c-aee8-d60d48ce5669"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("09cc580a-480d-4e19-b701-edd9efb67ab7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("09d25ee4-259d-46c9-bf11-30be9899f654"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0b32c198-d0b6-4150-b405-40af50d27504"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0c2310d9-fd7d-464f-b352-a9c9f0f147e5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0c67c9fe-0bd0-4bec-b7b2-9ccceb776192"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0ef5cc42-7797-438a-9fd6-f0f4f24fbbc8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1336dff4-9413-441f-b885-ac50b0a058af"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("15161dff-eb93-4008-a4c9-63a62aab1d91"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1542f83f-560e-4adf-a0aa-4f0fa5ea58c2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("15856a2b-9bec-4b27-80d7-b2101e23f2a7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("174c2e9e-8b31-44ab-af19-d0d617faf4be"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("174c92f2-f047-4839-8e3d-29afa8db8609"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("185fb642-045a-4d7a-8619-525d675efa06"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1aed4f32-c883-4b97-958e-ef6eb68a677f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1f6a1b41-1df4-42d2-b162-43b335714db0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("216073bd-7853-4a65-8e52-a6c754d107e9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("22516c62-3e05-4493-b879-05e644bf9562"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("22912dfb-8029-4d73-a13d-bb0c0fa5c8f2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2517e9c9-f0b4-4014-8bd0-95ce9d3bf737"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2579da6f-1235-45e6-adaa-d5ca243bb4d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("25f444e7-e4bd-422d-8cf7-ffff91529136"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("26a9c2ad-15b9-4dd6-810a-110a2024bd9e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("26c56be9-a92a-4740-b253-05cb3478a952"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("28699d70-d9b4-492e-9ae3-2877ddcc7bcd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("289e5f8d-c479-4490-9cb1-b5672712e4dd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2b6c14f6-2152-4185-b3ce-88b7afbf3af3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2cc759cb-7fa3-4bf2-830f-2f68f79cb0d7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("30a1a3a8-0d62-48cc-bf98-03aae08e0410"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3151c7e0-4397-4c38-a7b6-a452870d9729"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3649571a-84c6-4334-874e-4096bcfcba26"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("36512ad1-e7a0-4eac-9dab-7147b60dc031"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("36605f31-35c3-4142-9c18-9880c6a1a175"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("36a0b32e-681c-4c7b-b2a1-18e723761b32"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("374e39d9-c4b5-496b-bb25-4b29496ed041"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("37a2c883-bab6-4f0e-8d0d-72c2dc43d816"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("38db608b-8981-4936-bff4-7e71934908f3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3b3e498f-f019-44a3-b4a0-eef5e1fc26ca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3d467d8f-07c6-4aff-afd4-83a2b478c925"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3deba142-19b5-4e64-a905-701886ac2b7c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3e98a75c-06fc-4c89-ac42-2cbd1180149e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3edf7548-f820-4ce3-9bd5-f8442c2949c0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3f78a17f-34f3-415e-b5e1-245b2b90a808"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4050e743-14a4-4c79-9296-07713d22c6aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("42a48b27-57e2-483e-b7ce-a3dc59fc37c0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("42b5a2d0-5434-4af8-8bad-6215b5a65569"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("46981384-0b4e-4768-bca9-e70abbedee2a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("47ca91f4-145f-4c51-b2d8-d454a6392b77"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4801c94a-4f1a-419e-9fe3-9cb0092783ff"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4d793e76-bdde-4dbe-94d3-0c9fadf32762"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4ead04e6-6163-4019-9228-3911589385ff"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4f3b452d-3771-4a8f-b82f-2f918efa7d0d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4f75c836-7424-46db-9ee3-c5d964028bd5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4fb5eb62-3acd-468d-9b96-f6bb789e2919"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("50ea6c83-95cc-452e-b9d4-82edc468e3bd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("517de4aa-ae8e-44cb-b4ec-06537d55c692"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("55bbb1a2-6364-43a6-afc3-b9fcf58aa779"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("56b89997-d006-458e-a851-d25a63a52eda"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("57ef3c70-9d72-4db0-8e33-9d9bdd6d34bf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("581d3758-1032-41aa-9ec3-6d6d82db2799"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("58a26f8d-c1a6-4795-825f-5c16ceabf7be"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5961f883-b5cb-4324-beab-6863d9fd328c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5c773750-3149-43a0-b4a6-69e0030db84f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5e686b55-6196-4ea3-b1c5-d934aee83b45"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("63792bb6-8a6b-4bcb-9db5-d8f6a89e7a8a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6635777a-65ad-4366-8639-62976603a735"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("666d6f82-9041-4f4d-bd5a-23eee6cd3dc0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("67c0289f-7029-453b-88da-9acd6dada7a0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6a405972-c20d-4161-8c31-319fbea06bc0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6b6bc4c0-04ee-4ef0-85fe-582ce9187a47"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6d820397-07e3-4e9d-8cb5-1c98d2574719"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6d8610fe-1d0f-440e-8a42-ed8b4a56aaf4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6fc9ca01-71b4-4f06-8f8c-fdfa7e6e07f6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("70628a70-e7ac-4273-a7ed-323b076a0aa3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("712e00fb-dd4b-460a-b58e-b24609b9d88f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("71476f7f-40fa-4e13-8369-3b1b4920b681"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("717ba905-f40e-4f59-bfcb-882ce78ba45d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("71cb21c6-0c82-4d44-9421-81af1392d1dc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("73daec9d-f1ea-4305-94ae-f95a9e4dffdc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("73f2ab48-5457-4a6a-bc5b-8c278784c2b2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("768541fe-a1f8-4b5b-9175-c167b6195950"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("76e4e966-008f-4995-8656-97fdbd61a3ea"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7701feaf-41a5-4f16-b06e-bedac7797ae9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("777d6586-83c6-4405-9257-56c635695a14"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7993458b-10c4-44f1-8c5c-adfee8502cf9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7cb17adb-915c-4840-b211-bcbb62c76275"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7dc462d6-6d9a-4ce1-b222-4b83bdf0fe64"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82134a50-f9cf-4c56-94e7-c9078ff9c656"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8217e211-2508-4c7d-bef5-ba5b12ab121f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82b31b11-be43-4a72-b27e-213e40b2155c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82c21665-8b3c-4cc7-9369-3b6d5f5e3b96"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82dd43f9-8222-4592-a037-cecb5ccda02e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82e1a766-a9df-4281-903a-6fbb9c33c019"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("84c4c2a1-dad2-49f1-8ba4-6e40efa32de0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("87840d91-1830-4a18-b448-959f2148c9df"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8785aedf-9a50-4806-ab3d-4996939ea426"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("883ef1e4-5502-43b4-8d7f-113adf0e474a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("89dd6cc6-bf9f-44e4-a307-9cf6610e646b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8a051adf-c2ea-4def-8c42-d505034a89d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8da0085c-d845-47ba-9b30-c7c16ecd1274"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("90c1f955-8c8a-4740-97d6-c25d153e792c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("915bf705-fe0e-46c8-90b4-6182bf3cb1e3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("92c438b6-7c3f-4e49-bd84-9a9767dee98e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("92ce1d86-32d6-4645-a651-5475836724a1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9476f504-1a6c-4e2c-88a8-867a190905db"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("95791121-62c5-4e04-8271-afedf4a34558"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("95fb1421-c056-463a-ad96-46234be9a65b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9dc85c9f-a367-4965-a082-610043116199"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9fa3f983-25a1-4406-8335-e6111473bd72"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a05854e2-874a-40a8-a9c2-6805dba717c9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a06c834d-dbf7-4822-a872-f846bf1d4e18"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a26718d4-6213-4435-a982-7e04bdac6531"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a351053a-145d-41aa-bb17-0e17253fefec"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a4b1c949-d915-4af9-892f-69e94e0c596a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a510067d-4ef7-412f-ae94-9fc0c6870abe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ac24dcd8-2a04-4b4c-8e66-101f31ddc3b8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ac7e9f27-d0e6-4dd4-8359-e9c0d65aa86c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("acef6d1d-6029-473b-94bb-4c59682baeb7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ad3b4011-18eb-4afa-8ba5-242d6e4457bb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("add7ebcc-4a12-4ea5-9561-5060f0ae8de3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b0550a84-71ea-45b5-bd37-b5cbe89141c3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b0bb6705-8a80-455d-9049-477cc3897c92"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b2f40da9-6488-4825-976f-fdd7b29b18d4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b3ef00dd-0529-4f2c-85df-a0fda7e507ac"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b5502ba8-911f-452b-9dda-965ec0890470"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b7625719-d1c1-4c53-ae25-292c124a628c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b765dd01-c7f3-44ef-b2c5-24d8aa8bb173"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b86f14d9-d352-459c-986e-813fea3abc60"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b88a3dac-817a-4746-83bb-801d8e056675"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bac3f867-96cf-406e-8098-4994ea309431"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bbf44382-27d9-4919-82b8-b9a74b368ee6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bd090c0e-436b-46d3-8816-ece458e6236f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c0cb361e-688c-45ab-953d-7bf8a1eaf53c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c18c1e40-e34c-44e2-af39-10c4020ca1aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c2a63ac0-d954-4a34-b166-e4e0ac8b3138"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c30b2866-8684-4f32-9ca6-48a549aa60fe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c66f9a5a-7409-49cf-8382-f5c2d78ca69b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c73056ae-36b3-4b5c-91d9-fd7ec0cef5f3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c97c95a7-ea72-4031-8dbe-5f4275795761"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cad68b36-151a-4c93-b659-d7a4e749d5fd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cc4ae899-9c6d-4b81-9197-98ce0996c439"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cd2f2870-9386-4d3a-8a9b-c4834493bd85"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cd5e0830-5f46-4142-8107-619994dd18d7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cf5a1767-a12d-4be5-baf0-10ac7f0ab6fe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cfaa5544-0053-450b-8291-a4982c232745"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cffba51b-98d7-4347-8587-c1985ba4f3d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d004c0dd-9efd-4945-ae17-ec59143d86d5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d21ae405-44b9-47cd-8165-376c95a1fb80"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d39dab19-5460-402a-aa57-74883772cced"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d3f3748e-c895-4012-8a09-6722eea97726"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d59a741f-86aa-401f-8845-18fc909b9e7d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d778ee17-6db4-45c3-b5c3-dafef0b2528a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d7cf1a02-248e-415f-9e65-f900f4598e98"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d9293c86-adb9-4097-bade-e810750f940c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dcc8137b-640a-4445-8713-b84e381c40e1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("df0b9210-b106-4319-9cbe-4a7ff309d3a2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e1bd58fc-c636-44b1-8ac6-1996a9fba8b5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e37a2dda-badf-4581-b849-93fdc9964770"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e62ad177-e20a-4c9c-b096-830c3968b7f0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e7384e2c-df7d-47cf-93d0-496f8be2da44"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e7afec40-bf73-4562-88dc-4302f6ad47ae"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e90532c7-2510-4d87-9933-06ecd1eabb9a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e90ec4d2-4fa2-4d93-ba2d-0de0b821d085"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e990bf7d-c60a-4f68-bbeb-12196e1b9f2b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ea379b1a-9cbd-46a6-8b8e-d275761d9184"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("eab71cbe-5d84-4267-a76a-633c60f52f12"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ec35dfe0-4c45-480d-9e48-6c77ae7c8ec1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ef9785f8-e26e-4072-badf-97eaf3b3233c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f04da4f8-f3b3-4755-a9ce-df5d8be0e7ad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f116c308-12a1-4b4f-ae78-597ea70a68df"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f3524eac-faad-4193-8577-c2bf81ad4982"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f6691e6c-c87e-487f-8e54-03784da1c46d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f6b20a82-e32a-49a3-9348-b3e90e461007"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f9366cca-76c9-47f0-87a3-d1a8dbf26534"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fa4d35c5-e788-42b9-abba-a391609b079f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fc5626b9-066e-447a-9454-185cf9a26166"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fcbe2be0-2306-4be1-9849-11e3d3359a09"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fe12a615-1a56-4f48-808f-ca214e7f8f1e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fe4cdad2-0a5b-4054-be33-4e4afde6cf39"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0b19231e-90ed-4221-8692-66f86d6dc69e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("1e83f693-b970-40f7-8f80-d503880b2212"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("36289aa3-03ad-49f6-a520-2dfe5170efa1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("4e0acc24-e1a5-420d-83ca-e0371e01a372"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5c59e543-b9ff-4c8c-9907-51cdde4271c1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("605fc00d-bd73-4cae-b7cf-faf5cb662cd5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("616e14eb-f04d-42d4-bc51-fd60d0659e74"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("70baf021-39f7-4d98-a8f2-afbc6d3e0bd1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("af46fa09-5da7-486c-b8a4-e80957870192"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c79dc5f4-f3bb-480c-ada6-ffa5213a9623"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("d2b086d1-288d-4f3f-8cdb-523908566225"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e611d42a-feff-465a-9752-6aed23493e5d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e7ee76e4-47b7-438f-9b91-1dade87db902"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("eba90251-1aa0-4d0c-8432-96a1115e0436"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("15f45a3e-30eb-4971-9a59-85905952132c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("28b1c5f4-7d38-4b7c-8557-8dd205b95447"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("6455ad05-d89b-4e62-a92e-4d4399ea64e2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("81ae0752-c3a6-4cc4-a6e8-d3c4860696a7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("cca3cad1-fec0-460c-b1a5-d11a76923964"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("18d983a0-b6b8-4aef-961c-f035ffa44bb0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("224520cd-35b4-46eb-993c-d09e65eabe1a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("27935e43-0ed4-40e3-9dca-abeb1cf98801"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("298828d6-75bf-4ef7-8bff-2d93603e3b66"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("36f3a6e9-0507-4e95-896a-6cacb7d71f2d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("4c165db6-c4d9-4b21-bdea-d76c89a136e9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("583b404f-78cc-404b-a346-c9d83004ac81"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("65e295bd-b496-43e9-9e87-840a63b101b3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("66cf9499-4485-473c-941b-e30a5dcba2fb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("8e07b356-6b30-4996-8819-0528390c2aa2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("952f5839-f61b-4716-976e-4c8563f19a68"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("98449cca-1677-43f6-8e2d-0402fa681e70"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("9ba7e92e-c4d4-45f0-afaf-3f997afecf2c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("9e747cc6-4ecb-4155-b145-f169af026267"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("b19717f1-2579-4b67-8e49-001fa3f7a2a6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("cc0dfa50-a880-4a7d-8139-f244bbcdbc4b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d6fb46c7-a78c-4fd5-a378-b8f4bba076f9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d9501d32-ea7b-4651-96b5-bbab8e198ca0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("dadc106f-031f-4205-8533-1e167d64c02a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("e880be6e-2b43-45a7-996b-bec0919110b7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("f3fb2e81-1f53-4575-bf61-5ac65fe059f2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("f912df0a-e104-48c1-a1b6-5c55042c2a1a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("ff94ddd0-66f5-4b0a-ad3d-7b94e1203dc1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("28c265dc-a7c3-47d1-9388-249b5d792587"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("502dd23e-a9f0-4c9d-9e7e-ef1972397895"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("dabd7dfe-7e87-4538-a7a1-d3b985621739"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("e1923afa-fcbf-4ac7-bd5d-e1ca6a7d6087"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("f7ee0712-5c36-4f48-852f-4e166e5c7e90"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("09c5379b-c500-4e12-b9b8-0fc7a63d6557"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0bf24f06-5988-4a4d-be47-d9a1f98c7836"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2b0e1c2b-157f-4581-850a-947e56a5cecc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3af79e1f-bbc8-4365-bdf9-811df2768e70"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("537c7657-95a8-4b4c-b5b9-2fde03245a01"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("575777c9-ff19-45b8-9370-a7ceb94f898d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("618b390b-c2b8-450e-8328-9796e166adf3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("72bb0406-5277-4099-9723-f5631c89bec8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("7edce8ab-396c-4b4d-8730-b3d6f78341f0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9b2d7b80-4c31-4b0c-8186-80a04859aa0b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b32c957d-fdaa-4bdc-9356-840ec99ef588"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c6634824-a82d-41ed-8ffd-219147146440"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("cb1bba0f-bfd9-40f4-9a0d-ef7db92b1716"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ce1fa6b3-d97e-4458-ab14-118e61d9ea4c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("dba11a97-a798-45d4-af4f-10c4e3f1722c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("fe405cc4-cf41-44d5-ad07-b9d78cefba21"));

            migrationBuilder.DropColumn(
                name: "CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DropColumn(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropColumn(
                name: "Time",
                schema: "sp",
                table: "SP_Plan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SP_ServiceListingsServices",
                schema: "sp",
                table: "SP_ServiceListingsServices",
                column: "Id");

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Category",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("09a11f4b-07f4-45e0-8439-5ad5060f8348"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5338), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5338), "Tutoring & Educational Services", "" },
                    { new Guid("0eb1cba5-2ef9-4885-8c55-8365eb74c6e3"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5333), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5333), "Jua Kali & General Repairs", "" },
                    { new Guid("1014b745-a4af-4875-85c1-343d8961ab53"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5324), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5324), "Landscaping & Gardening", "" },
                    { new Guid("2b2bc2d5-7a39-4b48-96d0-9f9a40267e13"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5335), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5334), "Ride Hailing & Delivery Services", "" },
                    { new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5344), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5344), "Professional & Digital Services", "" },
                    { new Guid("5e885731-ad6d-406b-9e37-7e9fcf1a2e47"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5336), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5336), "Catering & Event Services", "" },
                    { new Guid("b04a7d6e-73d1-41fe-8879-090b68cdaf77"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5341), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5341), "Beauty, SPA & Personal Care Services", "" },
                    { new Guid("b66eb58d-ae1f-4082-ac44-9b7c39ce2b85"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5322), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5321), "Cleaning & Housekeeping", "" },
                    { new Guid("ce9510b6-912a-4b6e-947b-167f07be6b4b"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5342), "Web & IT Support Services", "" },
                    { new Guid("d9b1c7d8-6d24-4098-8201-2349b4cda0e2"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5340), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5339), "Fitness & Wellness Services", "" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_County",
                columns: new[] { "Id", "CountyName", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), "TURKANA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("076ea9e2-d1b7-41ae-b007-a1773c54d4d8"), "LAMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), "KIAMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), "UASIN GISHU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), "NYERI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0ffd28e0-7457-478a-a256-a29114efe38d"), "KIRINYAGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), "MURANG'A", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1848f487-fc9d-4fa8-a51b-bd2d16b98f4a"), "NYANDARUA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("26cfd04a-417e-4618-bbf1-a237f4cff9c5"), "EMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2b240861-de8d-44e2-8b20-529f033ae0c4"), "ELGEYO/MARAKWET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4024e881-7178-459c-a361-2786d2f6feab"), "TRANS NZOIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("41fb1c23-cbc8-4260-a800-39abae7c48ee"), "LAIKIPIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), "MANDERA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("474febb8-c1c7-4a17-8808-f704b7b4abad"), "SAMBURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("543585bc-27dd-4249-8198-4a48b2c45bbe"), "SIAYA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), "GARISSA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("613768ef-c0f5-46b2-bf9d-3f114211d7bc"), "VIHIGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("65f0cfdf-5a94-42be-8586-0066b903c84f"), "HOMA BAY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6640a9b6-d4d1-4214-b569-dc4d842d63ed"), "NAROK", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6dacc240-4b36-42aa-8024-733bb6eb5294"), "KISUMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), "MAKUENI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7745e42b-5072-4c8f-afe5-751522420537"), "NAKURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("78ca2d2b-02e8-45bf-90bb-77f1a87d163d"), "BOMET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"), "BARINGO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("91280855-873d-4992-b30f-e57e606fe917"), "NAIROBI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9f04ef94-4b96-4fbc-8f5a-bac47b9cd94c"), "THARAKA-NITHI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a1afbf64-5e7c-484e-80ca-ddbfc5907680"), "BUNGOMA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a9f01638-d11a-4227-aa94-e50ab80f908b"), "MARSABIT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac674bcc-ec67-42d1-b74c-998b57544a32"), "KWALE", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), "WAJIR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b2ef8747-cb28-4687-bd16-3f1007374f3f"), "MIGORI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b93b1724-82c9-430b-a1d8-169ba941c0b4"), "KAJIADO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bcb0bf60-a9db-4bd2-b796-7acd6b9ba9d5"), "BUSIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c411ffc2-a0e0-4438-98e1-a52fb4be6ff0"), "KISII", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c7d0a597-08ee-4d2e-b081-aabb2f8c3693"), "ISIOLO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), "KILIFI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), "MOMBASA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d5169424-54dd-4982-8914-4bde559dc4c4"), "TAITA TAVETA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e2ae9ef5-dce7-4606-aacd-9c6a98fd050d"), "KAKAMEGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e47e86b0-6bb2-4481-b217-ead5038327df"), "NYAMIRA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), "MACHAKOS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e9504587-5e5a-4c84-87cf-4422df70a01a"), "TANA RIVER", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ece65964-19ad-4bc5-8fb4-9c32d9f46df4"), "WEST POKOT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f22ced0a-96d0-499a-9d73-02ed131732e4"), "KERICHO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), "NANDI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), "MERU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), "KITUI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Location",
                columns: new[] { "Id", "ConstituencyId", "DateCreated", "DateModified", "LocationName" },
                values: new object[,]
                {
                    { new Guid("39a53e43-d907-4985-84f4-b8b4c2315648"), new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Njiru" },
                    { new Guid("8f48f282-a7f9-42e5-ba3f-423cc2a6cff4"), new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Claycity" },
                    { new Guid("919e2d56-3954-4ba2-9e3d-98483276d4d5"), new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mwiki" },
                    { new Guid("9bb9749a-d557-490b-b680-dd4c77faf451"), new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kasarani" },
                    { new Guid("bc0a8c64-1305-4f1a-b520-3ac7f57a16ab"), new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ruai" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Constituency",
                columns: new[] { "Id", "ConstituencyName", "CountyId", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("02285c78-f3aa-4c91-9cd3-ed61545fbf45"), "Emgwen", new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("02d18019-9297-4f5b-932c-bbaafb97860d"), "Kapseret", new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("04573437-51e4-4323-9dfe-23707cddd02d"), "Roysambu", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("04ed5b9f-2718-45e9-8c8d-8a242375ee0a"), "Kinango", new Guid("ac674bcc-ec67-42d1-b74c-998b57544a32"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0547ee59-178b-4009-b938-db66f2e9f6cc"), "Juja", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("055ba4ec-7c87-4df7-80d7-fbc7e8f1a113"), "Soy", new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("061a8981-3053-4ebc-8c28-62de780e2f82"), "Embakasi West", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("074a1e37-ed01-4294-9603-6c808ea7be16"), "Mwingi West", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("078c7b37-166f-4da3-a497-782bd1f46ccb"), "Ruaraka", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("089cbba0-cebd-4ebc-bd4c-a4f301e179a8"), "Chuka/Igambang'ombe", new Guid("9f04ef94-4b96-4fbc-8f5a-bac47b9cd94c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0a543163-622b-4f08-b2b5-97b670f4972b"), "Endebess", new Guid("4024e881-7178-459c-a361-2786d2f6feab"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0f56e20e-1a76-487b-aaec-73952d223229"), "Mwingi Central", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("10af6ed1-8f80-4c78-98d3-cfb1b6cfe67e"), "Daadab", new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11e1af07-2765-40a5-8bd0-82071e94663c"), "Fafi", new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("12da8a09-09ee-4461-91cb-de0d5a9ead4d"), "Wajir North", new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("15be0cb7-57b7-4585-adec-ec2706c78f39"), "Kieni", new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("184f176d-f5a1-4411-aff3-6ba23282c08b"), "Othaya", new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1d0efc4e-0bf6-4980-8a0c-9fd9eea90e1b"), "Mandera West", new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1e1d7308-f794-49a6-9bf4-e6eb71b8bbb5"), "Mbeere North", new Guid("26cfd04a-417e-4618-bbf1-a237f4cff9c5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("20bd7138-3dde-42c3-a8fd-a876c1f20ba1"), "Msambweni", new Guid("ac674bcc-ec67-42d1-b74c-998b57544a32"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("21e1fb84-8ff6-4e20-947d-19a70a0651aa"), "Kabete", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("25657c02-39ba-4b95-965f-e3f645a03781"), "Likoni", new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("26c9c648-426d-45e2-bf4b-a30a308f706a"), "Kuresoi North", new Guid("7745e42b-5072-4c8f-afe5-751522420537"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("28630967-f1fe-4496-912b-50fa35ad522e"), "Mwingi North", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("287a3b16-7bbc-44c0-b25d-f810f415d72e"), "Mwea", new Guid("0ffd28e0-7457-478a-a256-a29114efe38d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("28b31161-1e55-4b72-88f1-3393e0c42e7b"), "Kapenguria", new Guid("ece65964-19ad-4bc5-8fb4-9c32d9f46df4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29829bc8-7770-49b3-8a34-6b4921083d5d"), "Wajir South", new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2997bd8e-3dbd-420d-a275-1b0ba1bab3bc"), "Runyenjes", new Guid("26cfd04a-417e-4618-bbf1-a237f4cff9c5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29d3647d-ccf6-4444-905f-609492a8d990"), "Samburu East", new Guid("474febb8-c1c7-4a17-8808-f704b7b4abad"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2a7f1b31-94bf-4461-94ee-64b7aa19aa45"), "Kitui East", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2eb3ac46-3f64-4742-90fa-07054345d1bd"), "Kiminini", new Guid("4024e881-7178-459c-a361-2786d2f6feab"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2ee57e25-94fb-4232-a4f9-e35087c3c89d"), "Buuri", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2f4329c7-1005-41d9-bdca-281cfa81f375"), "Isiolo South", new Guid("c7d0a597-08ee-4d2e-b081-aabb2f8c3693"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3307179c-99b3-48b5-8d96-e1e8fa5eb8c4"), "Kilifi South", new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33430784-e355-4e77-a562-41ef401aaf5e"), "North Horr", new Guid("a9f01638-d11a-4227-aa94-e50ab80f908b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("374d286d-80a4-40b7-bf8c-db57b43da59f"), "Kitui Central", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("398f084d-6acc-4263-b486-0cc7c07bd465"), "Mwala", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3c9694ec-8ef6-4770-8ba4-d389f77f82a3"), "Kacheliba", new Guid("ece65964-19ad-4bc5-8fb4-9c32d9f46df4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3dac9c13-41c3-4631-94d0-eae830c1cbf4"), "Taveta", new Guid("d5169424-54dd-4982-8914-4bde559dc4c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3ea8b8fd-4bbd-4de9-b0da-6030bd2f780c"), "Maara", new Guid("9f04ef94-4b96-4fbc-8f5a-bac47b9cd94c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("400e6f14-2f88-4ca6-93ce-3fa7a7cf7e6f"), "Thika Town", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("41fa3cd0-a8e0-4646-a221-aac3154fa6e1"), "Chesumei", new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("42ff033c-2d8f-4abd-9297-5d99858be056"), "Makadara", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("436e6318-a440-4bb6-9b1e-429ee0680f6a"), "Tigania East", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4586cdf7-e77c-4d19-9934-e2d481144d71"), "Naivasha", new Guid("7745e42b-5072-4c8f-afe5-751522420537"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("46de7865-a32f-4a80-9491-372a71643d72"), "Cherangany", new Guid("4024e881-7178-459c-a361-2786d2f6feab"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("47a2e9a6-1fb9-4e15-9837-0cafb3c63826"), "Makueni", new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4824e7b8-b905-4f0f-8c96-7f7099a1db9f"), "Kilifi North", new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4885b879-a213-481b-858c-d47875d29b66"), "Turkana North", new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4d073a00-138b-4778-ae54-a7dbf4ee1b72"), "Pokot South", new Guid("ece65964-19ad-4bc5-8fb4-9c32d9f46df4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4ef4eb1a-936e-491f-9ad0-69f547e27733"), "Wajir East", new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50842c2a-84c5-4ed0-9076-0ce92885d066"), "Limuru", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("521d86bd-1dbf-4025-bf24-38a20e586945"), "Mandera South", new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("53f83da8-d559-43f7-8f64-3c74c64dea98"), "Turbo", new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55f69f62-850f-4937-8842-48c1c1421fdf"), "Dagoretti South", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57301df1-c954-4db9-99fa-3128838acc69"), "Mandera North", new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57c255f2-ad29-4304-b10a-e41ace14935b"), "Laisamis", new Guid("a9f01638-d11a-4227-aa94-e50ab80f908b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57f4ef02-ca50-470f-a33e-f52531af5f73"), "Jomvu", new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("585aec3b-9db6-4d38-87a2-a9c9de4dd92d"), "Garissa Township", new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("58f90505-0340-4f6f-a011-e5120df87bdb"), "Turkana South", new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("591d4aef-7a04-419f-94c4-c117df0bc4d6"), "Ol Jorok", new Guid("1848f487-fc9d-4fa8-a51b-bd2d16b98f4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("59f0f8c9-d9dd-4c65-b980-f989ef948ac8"), "Lagdera", new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5a9e80c3-bd30-4926-9a5a-6bbf12a8b34a"), "Lungalunga", new Guid("ac674bcc-ec67-42d1-b74c-998b57544a32"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b48f15b-c6d8-4632-ba9b-f99370152386"), "Matungulu", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5ee824f7-461c-4e06-8e89-13776e3e88f9"), "Keiyo North", new Guid("2b240861-de8d-44e2-8b20-529f033ae0c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("62af1bac-fa6a-4a15-a8a1-3e75108ffc58"), "Molo", new Guid("7745e42b-5072-4c8f-afe5-751522420537"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("631339f2-e365-47ff-8206-d29902a9c402"), "North Imenti", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("643eface-829b-4d39-a94e-3b9597560fcd"), "Mwatate", new Guid("d5169424-54dd-4982-8914-4bde559dc4c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("646ceea3-e68e-45a7-8bb7-c5fc0fc156a6"), "Kandara", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("64f5af66-a1d4-46bb-b6b4-66e7fbae3ea1"), "Baringo North", new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("64fb1e44-1625-47a5-a0b6-eb7b713cc55d"), "Mbooni", new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6baa94d5-cf46-42a7-a740-cb9e1a675545"), "Kwanza", new Guid("4024e881-7178-459c-a361-2786d2f6feab"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6c3cf16d-4c38-405d-bd71-f4ac7bd65879"), "Wajir West", new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ca934c1-e8ac-48fd-940e-2417124c8a83"), "Igembe South", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ff0beed-539e-4d36-88aa-e3c88144b2dd"), "Tigania West", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7351e3ac-6e95-4816-8d56-5728b40ae15c"), "Sigor", new Guid("ece65964-19ad-4bc5-8fb4-9c32d9f46df4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("739d1255-f977-4d8c-af57-393f3688f08c"), "Kigumo", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("73ec2ae3-ef0a-43f9-855c-95ef3d70de05"), "Baringo Central", new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("75582d45-9408-49d0-ad02-30f888829fb9"), "Mathare", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("75869b02-a148-4af4-adc4-190c9664d14f"), "Mathira", new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("759a3b64-415e-4d5e-9d7a-3517dda63749"), "Laikipia East", new Guid("41fb1c23-cbc8-4260-a800-39abae7c48ee"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("76ef3bf5-089a-4a3c-a07f-4de01d6ea47d"), "Ijara", new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7871476f-0e64-4644-96ea-65306625831b"), "Kipipiri", new Guid("1848f487-fc9d-4fa8-a51b-bd2d16b98f4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a017a89-cced-4f3c-859d-59edd9a2442f"), "Wundanyi", new Guid("d5169424-54dd-4982-8914-4bde559dc4c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a553932-5224-48ad-bee4-d94de09445f6"), "Mosop", new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7af6f9bb-9ccb-4987-9be5-9dd0f06ccd7f"), "Balambala", new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7c286fb6-33b9-49d8-b7bc-2967e0a5cc31"), "Moiben", new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7db428bd-bbe9-4b91-9a84-e540456e72d6"), "Maragwa", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7e350127-f13d-4aab-ab6a-31c501f8c3fe"), "Kaiti", new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7ff907df-e429-4d88-af7c-04187664dffd"), "Lamu West", new Guid("076ea9e2-d1b7-41ae-b007-a1773c54d4d8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("80db6991-e27d-4abf-9bf4-b8447a8b9d8f"), "Kiambu", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("81b98366-b1c9-45a2-8d36-28dbf419b47a"), "Kitui South", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82c1a10b-231c-4572-b8de-be948bc5e1e4"), "Aldai", new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("83bb93f1-468e-465e-a256-5d70a4f7e62d"), "Baringo South", new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("841e0906-19ff-481b-8672-15216d7f1adc"), "Lafey", new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("864887e6-949c-4dff-9763-3a601767de52"), "Malindi", new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("86851d56-20e1-44ba-bc18-13590d5ee767"), "Langata", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87732815-cf9d-4521-9aa2-9027be51ba52"), "Nyeri Town", new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87d7d9cf-0a19-4531-8891-fbaeeff685cb"), "Kitui West", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("880d39ef-419f-403f-bab3-d7aecc429e16"), "Gatundu South", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8ae71d6a-4401-42d5-9f2d-91cce9346b94"), "Embakasi South", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8bbf4aff-78f4-43ae-b74a-a90ce640f805"), "Ainabkoi", new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8c027802-32c5-43c2-a23a-2a9d02dc1c4d"), "Mvita", new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8c5c9179-b208-455e-bca4-3ada6a7ea8b3"), "Moyale", new Guid("a9f01638-d11a-4227-aa94-e50ab80f908b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("90f7b869-4014-4cbc-b18c-c4b62b7a2aba"), "Starehe", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9327306b-a1f1-4811-8cdc-7e5e379e5945"), "Kibra", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("95b0324a-4aa5-4fcd-a9f5-e0db25baf7b6"), "Marakwet East", new Guid("2b240861-de8d-44e2-8b20-529f033ae0c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("96dffd7d-375c-493b-a4b2-15b82e2fa2f3"), "Westlands", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("97ea8400-a93d-4bad-8398-a5a218a4d175"), "Tharaka", new Guid("9f04ef94-4b96-4fbc-8f5a-bac47b9cd94c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("987e0c95-c1b5-47f9-9c7d-ffd5db1e61ee"), "Kamukunji", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9c9c6431-b57a-450f-9fc3-e67cce4c4f18"), "Bura", new Guid("e9504587-5e5a-4c84-87cf-4422df70a01a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9e8bc9b2-63b0-4b98-a1b9-715b8ab8333d"), "Manyatta", new Guid("26cfd04a-417e-4618-bbf1-a237f4cff9c5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ebef967-7e72-4996-b3e3-afd104cb63aa"), "Galole", new Guid("e9504587-5e5a-4c84-87cf-4422df70a01a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9f3f2b67-2b8d-4e72-b86b-e23477d4cc75"), "Changamwe", new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9f7b5aea-17d1-426a-be01-6aae14399cad"), "Gatundu North", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a06b89ea-c980-4fa4-a3b4-a841945a3a57"), "Kisauni", new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a238ee4a-e668-4552-82a8-2161f661a0e6"), "Kibwezi West", new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a310829d-ebe3-4b20-9517-e69bd4367632"), "Mogotio", new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a4b373fb-f98e-40bf-bafd-1f1e7cc57130"), "Machakos Town", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a7a095f8-d68e-456d-997d-893f4ba06c05"), "Ruiru", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a7a11db0-75c8-4e3a-84e9-7d44faea2463"), "Yatta", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a82e1d28-d164-4354-87d5-ff62ac2721e7"), "Magarini", new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a8966f51-c1ac-49d4-9078-4cbe577263b4"), "Gatanga", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a93aaacc-5f4d-4508-9bfa-2a7842a06c3d"), "Kangema", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ace27491-92cd-45b0-8c16-08afaa686d5b"), "Loima", new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ae433e0e-e8ce-4f9d-b76d-d1c5425fc949"), "Laikipia North", new Guid("41fb1c23-cbc8-4260-a800-39abae7c48ee"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ae47cd67-909c-49a3-8f24-5d8db83f9b6e"), "Saboti", new Guid("4024e881-7178-459c-a361-2786d2f6feab"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b02c2fd8-643c-4742-8671-0497e295f8f1"), "Marakwet West", new Guid("2b240861-de8d-44e2-8b20-529f033ae0c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b3053185-c247-4f94-be2e-82e426c4599b"), "Nyali", new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b5b356ce-f606-424e-a40b-60e20503a851"), "Kiambaa", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b793b391-2319-4c21-9fb7-f702ef959cf0"), "Kitui Rural", new Guid("ffe65493-42c8-4a18-bb06-225f85464746"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b9ebce56-50d5-44f0-b0f7-9638a0116af3"), "Mbeere South", new Guid("26cfd04a-417e-4618-bbf1-a237f4cff9c5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bba06b2c-a5ee-4de1-93af-cf4a01f60938"), "Masinga", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc73b395-d838-446d-9409-d3d00b80532a"), "Matuga", new Guid("ac674bcc-ec67-42d1-b74c-998b57544a32"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bca299cb-0b92-480e-a679-8112facfe5cd"), "Garsen", new Guid("e9504587-5e5a-4c84-87cf-4422df70a01a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"), "Kasarani", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bdcf3966-d341-49fe-9639-a28a8a114fc0"), "Tetu", new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bf6e2804-2a6a-4226-8945-b296df4c17e9"), "Rabai", new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c70d3642-ff39-4768-9190-0047e020c379"), "Mavoko", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c7396a83-132e-4c3d-8613-14d7e51228ad"), "Mandera East", new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c7b7e38b-5cbb-40be-bf3d-115ef57cce43"), "Mukurweini", new Guid("0efeefb2-806f-4875-b062-fd201f006f07"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c7c9556d-9134-458b-9c2e-21cb2e06d9cd"), "Kilome", new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c8c9ff96-e9a2-4697-8ecf-cc189c4d2070"), "South Imenti", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c9d21c7d-4b2d-4972-aee3-dbdcb729e98d"), "Embakasi East", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ca6ade48-41c1-414e-93af-3497277875cc"), "Eldas", new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caba44c2-88f3-4815-a74f-967ed8ac070c"), "Kibwezi East", new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caef5096-381d-48fa-b760-809996f80b05"), "Githunguri", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("caf347e1-2d80-441f-8cba-3f46ef1738a8"), "Kirinyaga Central", new Guid("0ffd28e0-7457-478a-a256-a29114efe38d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cbf8d8cc-dc3d-4072-869a-8e806f6d54b3"), "Keiyo South", new Guid("2b240861-de8d-44e2-8b20-529f033ae0c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d1d8f543-471b-4a23-af2f-40131e26a3dc"), "Igembe North", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d32a34b0-29f3-4a42-a76b-6e605c26ec35"), "Voi", new Guid("d5169424-54dd-4982-8914-4bde559dc4c4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d380135b-fe00-4f43-909c-ad58de53c212"), "Tinderet", new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d4fe57d3-d499-445b-b154-c53b65793433"), "Turkana West", new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d6031462-46b0-4bb9-a1a7-c195383d78f7"), "Kangundo", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d8602b3c-7d58-42e5-b86d-cc3da66b5080"), "Nandi Hills", new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d9f8ca6f-efbb-4d78-b3c2-d5c4b61e8fab"), "Laikipia West", new Guid("41fb1c23-cbc8-4260-a800-39abae7c48ee"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("da66ee01-7d5b-4dd2-8f36-b1a9f4b1ed1b"), "Embakasi North", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("db878df3-2eaf-485c-b9cc-d0e502e6ffbc"), "Gichugu", new Guid("0ffd28e0-7457-478a-a256-a29114efe38d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("db89ef4a-84e0-43bf-8538-c7f6ce015068"), "Tarbaj", new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dc9e80f8-8f1b-4b11-b7f4-c59dc128c3f8"), "Kesses", new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dd616591-7480-42f3-bb21-44033ae3341b"), "Kuresoi South", new Guid("7745e42b-5072-4c8f-afe5-751522420537"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dd832c41-be84-42ed-a947-4eabee1570de"), "Njoro", new Guid("7745e42b-5072-4c8f-afe5-751522420537"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("deb07bfa-089a-4a66-8d94-cdbc52c07d12"), "Ndia", new Guid("0ffd28e0-7457-478a-a256-a29114efe38d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dfc5971f-ff04-4856-8807-4b1e7987027b"), "Saku", new Guid("a9f01638-d11a-4227-aa94-e50ab80f908b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e0102894-d7eb-4fcd-8df8-51c3ace67309"), "Dagoretti North", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e11a0e47-b7e8-4fe4-af99-f8f32fae1625"), "Gilgil", new Guid("7745e42b-5072-4c8f-afe5-751522420537"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e30a0100-a833-4f58-8860-3232052de22e"), "Igembe Central", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e3619910-46b8-44be-b31f-6d3c45fb6c50"), "Lari", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e77f860a-e8e2-4093-bf5d-f774bca18bc7"), "Kiharu", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eb3505c3-d623-4fe7-b8ec-e232627bb4e4"), "Central Imenti", new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ef807986-70ef-47c1-9cb1-9ddb80d3aee1"), "Banissa", new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f14d51c2-9a53-4bf8-9479-178eebd106f5"), "Mathioya", new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f1d18a24-2c25-4192-8054-39eb0b9e36b7"), "Ndaragwa", new Guid("1848f487-fc9d-4fa8-a51b-bd2d16b98f4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f2a37af5-9ca0-40cf-ba7a-9c95f45ef37f"), "Isiolo North", new Guid("c7d0a597-08ee-4d2e-b081-aabb2f8c3693"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f799fe25-e356-496c-a1db-6e47266573d6"), "Samburu North", new Guid("474febb8-c1c7-4a17-8808-f704b7b4abad"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f7f0eacf-05c6-41f1-b186-2d18c18c0524"), "Turkana Central", new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f99fc6e4-865a-494b-a0f5-0fa20984a075"), "Samburu West", new Guid("474febb8-c1c7-4a17-8808-f704b7b4abad"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fa7a49cb-9a7f-46b2-8041-95f3f49854d2"), "Kathiani", new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fcadc9f4-7fc3-43d3-bbec-986cdc1d7b7e"), "Kikuyu", new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd0735ad-0b65-44f7-b276-afed29f20e96"), "Embakasi Central", new Guid("91280855-873d-4992-b30f-e57e606fe917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd5024cf-4980-4b71-a9ee-dcddd695b3aa"), "Ganze", new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fdc5a158-5507-4542-8663-4ce110a04fb5"), "Lamu East", new Guid("076ea9e2-d1b7-41ae-b007-a1773c54d4d8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fe2b8f0c-c2dc-4faf-a7a7-7f9bd9a047a9"), "Ol Kalou", new Guid("1848f487-fc9d-4fa8-a51b-bd2d16b98f4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fec410e8-cb96-4a5c-bb40-c96aa1e926ff"), "Turkana East", new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fef15fe8-f90a-4998-8fc3-8ccd0bb7a6b5"), "Eldama Ravine", new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Service",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Description", "Name", "ServiceProviderEntityId" },
                values: new object[,]
                {
                    { new Guid("00ecc670-1c99-4ff5-b8ec-348f7e691f04"), new Guid("5e885731-ad6d-406b-9e37-7e9fcf1a2e47"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5445), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5445), "Expert photography and videography services capturing memorable moments at events and creating stunning portraits for individuals and families.", "Photography & Videography (events, portraits)", null },
                    { new Guid("27f1c2ae-0023-4883-b015-f0724b1d1ac1"), new Guid("2b2bc2d5-7a39-4b48-96d0-9f9a40267e13"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5422), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5422), "Convenient ride-hailing services providing safe and reliable transportation within the city for individuals and groups.", "Ride Hailing (in-city transport)", null },
                    { new Guid("330f71d2-e70c-4e20-a5f1-ef18cf7ab42f"), new Guid("0eb1cba5-2ef9-4885-8c55-8365eb74c6e3"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5414), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5415), "Expert painting and decorating services for interior and exterior spaces, enhancing the aesthetic appeal of homes and businesses.", "Painting & Decorating", null },
                    { new Guid("37392753-7983-41f6-9520-6794c51c02fb"), new Guid("5e885731-ad6d-406b-9e37-7e9fcf1a2e47"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5452), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5453), "Reliable ushering and event staffing services to ensure smooth operations and excellent guest experiences at your events.", "Ushering & Event Staffing", null },
                    { new Guid("38d3ef6c-fd90-42a9-94b2-24c9dec84a6c"), new Guid("2b2bc2d5-7a39-4b48-96d0-9f9a40267e13"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5420), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5420), "Efficient food delivery services partnering with local restaurants to bring meals directly to customers' doorsteps.", "Food Delivery", null },
                    { new Guid("461330dc-47af-47af-848d-6d3badbc7739"), new Guid("2b2bc2d5-7a39-4b48-96d0-9f9a40267e13"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5417), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5417), "Reliable parcel delivery services offering door-to-door delivery within the city, ensuring timely and secure transport of packages.", "Parcel Delivery (door-to-door, within city)", null },
                    { new Guid("4dd61f80-7673-4eaf-bc85-b30a8e4a934b"), new Guid("b66eb58d-ae1f-4082-ac44-9b7c39ce2b85"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5398), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5398), "Specialized carpet cleaning services using advanced techniques to remove dirt, stains, and allergens.", "Carpet Cleaning", null },
                    { new Guid("5fbbabdb-0097-4ac7-9ad7-5874533e43aa"), new Guid("b66eb58d-ae1f-4082-ac44-9b7c39ce2b85"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5395), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5395), "Professional office cleaning services tailored to maintain a clean and productive work environment.", "Office Cleaning", null },
                    { new Guid("653c36a1-f4d5-4ff3-b9a6-492d7f8f6456"), new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5430), "Comprehensive digital marketing solutions including SEO, social media management, and online advertising to boost your online presence.", "Digital Marketing Services", null },
                    { new Guid("6c7985d0-97fa-46e6-a307-94a7ab453509"), new Guid("0eb1cba5-2ef9-4885-8c55-8365eb74c6e3"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5409), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5410), "Comprehensive electrical services including repairs, installations, and maintenance for homes and businesses.", "Electrical Repairs & Installations", null },
                    { new Guid("8cf96154-b580-4884-95ca-0e1c59f875ab"), new Guid("5e885731-ad6d-406b-9e37-7e9fcf1a2e47"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5447), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5448), "Professional decorator services for parties and functions, providing creative setups and themes to enhance the event atmosphere.", "Decorator Services (party, function setup)", null },
                    { new Guid("98b8162a-b443-449a-8dfb-c5b51c8b0827"), new Guid("0eb1cba5-2ef9-4885-8c55-8365eb74c6e3"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5407), "Expert plumbing services including leak repairs, fixture installations, and maintenance for residential and commercial properties.", "Plumbing (leak fixes, installations)", null },
                    { new Guid("b1f49884-20fb-433e-b999-9ceaee0b7246"), new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5437), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5438), "Reliable IT support services including troubleshooting, network setup, and maintenance for businesses and individuals.", "IT Support Services", null },
                    { new Guid("b34cf0d8-c576-41c7-8175-bdf19350f150"), new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5435), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5435), "Professional web development services to create responsive, user-friendly websites tailored to your business needs.", "Web Development", null },
                    { new Guid("c7519680-1f67-404b-ab85-7997919e9a5c"), new Guid("5e885731-ad6d-406b-9e37-7e9fcf1a2e47"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5442), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5443), "Professional event catering services for weddings, corporate events, and special occasions, offering customized menus and exceptional service.", "Event Catering (weddings, corporate)", null },
                    { new Guid("ceed3716-2eee-4ab7-a049-a9f1a2f0d1b6"), new Guid("b66eb58d-ae1f-4082-ac44-9b7c39ce2b85"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5400), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5401), "Professional window cleaning services for residential and commercial properties, ensuring streak-free results.", "Window Cleaning", null },
                    { new Guid("d25b597b-2e9e-40bc-9099-62cef05e0c4e"), new Guid("b04a7d6e-73d1-41fe-8879-090b68cdaf77"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5455), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5455), "Professional beauty and spa services including facials, manicure, hairdressing, massages, and skincare treatments to promote relaxation and wellness.", "Beauty & Spa Services", null },
                    { new Guid("d3528422-cf2a-445e-b52e-1cabd382802d"), new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5440), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5440), "Expert social media management services to enhance your brand's online presence and engage with your audience effectively.", "Social Media Management (SMM)", null },
                    { new Guid("df9ccf4c-44b7-45b5-8042-ca1be089af41"), new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5432), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5433), "Creative graphic design services for branding, marketing materials, and digital content to effectively communicate your message.", "Graphic Design", null },
                    { new Guid("e566b9d2-2934-4db8-80e3-cfd1b3749861"), new Guid("0eb1cba5-2ef9-4885-8c55-8365eb74c6e3"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5412), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5412), "Professional carpentry services including furniture making, repairs, and custom woodwork for residential and commercial clients.", "Carpentry Services", null },
                    { new Guid("e6e592bc-e20e-4ebe-9ea5-d62820b0f348"), new Guid("b04a7d6e-73d1-41fe-8879-090b68cdaf77"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5457), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5458), "Comprehensive fitness and wellness services including personal training, yoga & gym classes, and nutrition counseling to help you achieve your health goals.", "Fitness & Wellness Services", null },
                    { new Guid("e9b88e8f-8fb0-432e-aab6-185540126b0d"), new Guid("b66eb58d-ae1f-4082-ac44-9b7c39ce2b85"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5392), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5392), "Comprehensive home cleaning services including dusting, vacuuming, mopping, and sanitizing all rooms.", "Home Cleaning", null },
                    { new Guid("f1bad98b-3314-4b28-9a4d-03d3547c8a17"), new Guid("2b2bc2d5-7a39-4b48-96d0-9f9a40267e13"), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5424), new DateTime(2025, 12, 2, 12, 0, 17, 681, DateTimeKind.Utc).AddTicks(5425), "Fast and reliable grocery delivery services bringing fresh produce and essentials directly to customers' homes.", "Grocery Delivery", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListingsServices_ServiceId",
                schema: "sp",
                table: "SP_ServiceListingsServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListingsServices_ServiceListingId",
                schema: "sp",
                table: "SP_ServiceListingsServices",
                column: "ServiceListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceListingsServices_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_ServiceListingsServices",
                column: "ServiceListingId",
                principalSchema: "sp",
                principalTable: "SP_ServiceListing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceListingsServices_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ServiceListingsServices",
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
                name: "FK_SP_ServiceListingsServices_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_ServiceListingsServices");

            migrationBuilder.DropForeignKey(
                name: "FK_SP_ServiceListingsServices_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ServiceListingsServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SP_ServiceListingsServices",
                schema: "sp",
                table: "SP_ServiceListingsServices");

            migrationBuilder.DropIndex(
                name: "IX_SP_ServiceListingsServices_ServiceId",
                schema: "sp",
                table: "SP_ServiceListingsServices");

            migrationBuilder.DropIndex(
                name: "IX_SP_ServiceListingsServices_ServiceListingId",
                schema: "sp",
                table: "SP_ServiceListingsServices");

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("09a11f4b-07f4-45e0-8439-5ad5060f8348"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("1014b745-a4af-4875-85c1-343d8961ab53"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("ce9510b6-912a-4b6e-947b-167f07be6b4b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("d9b1c7d8-6d24-4098-8201-2349b4cda0e2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("02285c78-f3aa-4c91-9cd3-ed61545fbf45"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("02d18019-9297-4f5b-932c-bbaafb97860d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("04573437-51e4-4323-9dfe-23707cddd02d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("04ed5b9f-2718-45e9-8c8d-8a242375ee0a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0547ee59-178b-4009-b938-db66f2e9f6cc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("055ba4ec-7c87-4df7-80d7-fbc7e8f1a113"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("061a8981-3053-4ebc-8c28-62de780e2f82"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("074a1e37-ed01-4294-9603-6c808ea7be16"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("078c7b37-166f-4da3-a497-782bd1f46ccb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("089cbba0-cebd-4ebc-bd4c-a4f301e179a8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0a543163-622b-4f08-b2b5-97b670f4972b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0f56e20e-1a76-487b-aaec-73952d223229"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("10af6ed1-8f80-4c78-98d3-cfb1b6cfe67e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("11e1af07-2765-40a5-8bd0-82071e94663c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("12da8a09-09ee-4461-91cb-de0d5a9ead4d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("15be0cb7-57b7-4585-adec-ec2706c78f39"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("184f176d-f5a1-4411-aff3-6ba23282c08b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1d0efc4e-0bf6-4980-8a0c-9fd9eea90e1b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1e1d7308-f794-49a6-9bf4-e6eb71b8bbb5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("20bd7138-3dde-42c3-a8fd-a876c1f20ba1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("21e1fb84-8ff6-4e20-947d-19a70a0651aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("25657c02-39ba-4b95-965f-e3f645a03781"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("26c9c648-426d-45e2-bf4b-a30a308f706a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("28630967-f1fe-4496-912b-50fa35ad522e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("287a3b16-7bbc-44c0-b25d-f810f415d72e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("28b31161-1e55-4b72-88f1-3393e0c42e7b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("29829bc8-7770-49b3-8a34-6b4921083d5d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2997bd8e-3dbd-420d-a275-1b0ba1bab3bc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("29d3647d-ccf6-4444-905f-609492a8d990"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2a7f1b31-94bf-4461-94ee-64b7aa19aa45"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2eb3ac46-3f64-4742-90fa-07054345d1bd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2ee57e25-94fb-4232-a4f9-e35087c3c89d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2f4329c7-1005-41d9-bdca-281cfa81f375"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3307179c-99b3-48b5-8d96-e1e8fa5eb8c4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("33430784-e355-4e77-a562-41ef401aaf5e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("374d286d-80a4-40b7-bf8c-db57b43da59f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("398f084d-6acc-4263-b486-0cc7c07bd465"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3c9694ec-8ef6-4770-8ba4-d389f77f82a3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3dac9c13-41c3-4631-94d0-eae830c1cbf4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3ea8b8fd-4bbd-4de9-b0da-6030bd2f780c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("400e6f14-2f88-4ca6-93ce-3fa7a7cf7e6f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("41fa3cd0-a8e0-4646-a221-aac3154fa6e1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("42ff033c-2d8f-4abd-9297-5d99858be056"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("436e6318-a440-4bb6-9b1e-429ee0680f6a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4586cdf7-e77c-4d19-9934-e2d481144d71"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("46de7865-a32f-4a80-9491-372a71643d72"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("47a2e9a6-1fb9-4e15-9837-0cafb3c63826"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4824e7b8-b905-4f0f-8c96-7f7099a1db9f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4885b879-a213-481b-858c-d47875d29b66"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4d073a00-138b-4778-ae54-a7dbf4ee1b72"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4ef4eb1a-936e-491f-9ad0-69f547e27733"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("50842c2a-84c5-4ed0-9076-0ce92885d066"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("521d86bd-1dbf-4025-bf24-38a20e586945"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("53f83da8-d559-43f7-8f64-3c74c64dea98"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("55f69f62-850f-4937-8842-48c1c1421fdf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("57301df1-c954-4db9-99fa-3128838acc69"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("57c255f2-ad29-4304-b10a-e41ace14935b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("57f4ef02-ca50-470f-a33e-f52531af5f73"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("585aec3b-9db6-4d38-87a2-a9c9de4dd92d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("58f90505-0340-4f6f-a011-e5120df87bdb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("591d4aef-7a04-419f-94c4-c117df0bc4d6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("59f0f8c9-d9dd-4c65-b980-f989ef948ac8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5a9e80c3-bd30-4926-9a5a-6bbf12a8b34a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5b48f15b-c6d8-4632-ba9b-f99370152386"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5ee824f7-461c-4e06-8e89-13776e3e88f9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("62af1bac-fa6a-4a15-a8a1-3e75108ffc58"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("631339f2-e365-47ff-8206-d29902a9c402"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("643eface-829b-4d39-a94e-3b9597560fcd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("646ceea3-e68e-45a7-8bb7-c5fc0fc156a6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("64f5af66-a1d4-46bb-b6b4-66e7fbae3ea1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("64fb1e44-1625-47a5-a0b6-eb7b713cc55d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6baa94d5-cf46-42a7-a740-cb9e1a675545"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6c3cf16d-4c38-405d-bd71-f4ac7bd65879"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6ca934c1-e8ac-48fd-940e-2417124c8a83"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6ff0beed-539e-4d36-88aa-e3c88144b2dd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7351e3ac-6e95-4816-8d56-5728b40ae15c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("739d1255-f977-4d8c-af57-393f3688f08c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("73ec2ae3-ef0a-43f9-855c-95ef3d70de05"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("75582d45-9408-49d0-ad02-30f888829fb9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("75869b02-a148-4af4-adc4-190c9664d14f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("759a3b64-415e-4d5e-9d7a-3517dda63749"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("76ef3bf5-089a-4a3c-a07f-4de01d6ea47d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7871476f-0e64-4644-96ea-65306625831b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7a017a89-cced-4f3c-859d-59edd9a2442f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7a553932-5224-48ad-bee4-d94de09445f6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7af6f9bb-9ccb-4987-9be5-9dd0f06ccd7f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7c286fb6-33b9-49d8-b7bc-2967e0a5cc31"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7db428bd-bbe9-4b91-9a84-e540456e72d6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7e350127-f13d-4aab-ab6a-31c501f8c3fe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7ff907df-e429-4d88-af7c-04187664dffd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("80db6991-e27d-4abf-9bf4-b8447a8b9d8f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("81b98366-b1c9-45a2-8d36-28dbf419b47a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82c1a10b-231c-4572-b8de-be948bc5e1e4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("83bb93f1-468e-465e-a256-5d70a4f7e62d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("841e0906-19ff-481b-8672-15216d7f1adc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("864887e6-949c-4dff-9763-3a601767de52"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("86851d56-20e1-44ba-bc18-13590d5ee767"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("87732815-cf9d-4521-9aa2-9027be51ba52"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("87d7d9cf-0a19-4531-8891-fbaeeff685cb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("880d39ef-419f-403f-bab3-d7aecc429e16"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8ae71d6a-4401-42d5-9f2d-91cce9346b94"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8bbf4aff-78f4-43ae-b74a-a90ce640f805"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8c027802-32c5-43c2-a23a-2a9d02dc1c4d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8c5c9179-b208-455e-bca4-3ada6a7ea8b3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("90f7b869-4014-4cbc-b18c-c4b62b7a2aba"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9327306b-a1f1-4811-8cdc-7e5e379e5945"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("95b0324a-4aa5-4fcd-a9f5-e0db25baf7b6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("96dffd7d-375c-493b-a4b2-15b82e2fa2f3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("97ea8400-a93d-4bad-8398-a5a218a4d175"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("987e0c95-c1b5-47f9-9c7d-ffd5db1e61ee"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9c9c6431-b57a-450f-9fc3-e67cce4c4f18"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9e8bc9b2-63b0-4b98-a1b9-715b8ab8333d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9ebef967-7e72-4996-b3e3-afd104cb63aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9f3f2b67-2b8d-4e72-b86b-e23477d4cc75"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9f7b5aea-17d1-426a-be01-6aae14399cad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a06b89ea-c980-4fa4-a3b4-a841945a3a57"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a238ee4a-e668-4552-82a8-2161f661a0e6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a310829d-ebe3-4b20-9517-e69bd4367632"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a4b373fb-f98e-40bf-bafd-1f1e7cc57130"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a7a095f8-d68e-456d-997d-893f4ba06c05"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a7a11db0-75c8-4e3a-84e9-7d44faea2463"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a82e1d28-d164-4354-87d5-ff62ac2721e7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a8966f51-c1ac-49d4-9078-4cbe577263b4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a93aaacc-5f4d-4508-9bfa-2a7842a06c3d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ace27491-92cd-45b0-8c16-08afaa686d5b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ae433e0e-e8ce-4f9d-b76d-d1c5425fc949"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ae47cd67-909c-49a3-8f24-5d8db83f9b6e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b02c2fd8-643c-4742-8671-0497e295f8f1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b3053185-c247-4f94-be2e-82e426c4599b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b5b356ce-f606-424e-a40b-60e20503a851"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b793b391-2319-4c21-9fb7-f702ef959cf0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b9ebce56-50d5-44f0-b0f7-9638a0116af3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bba06b2c-a5ee-4de1-93af-cf4a01f60938"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bc73b395-d838-446d-9409-d3d00b80532a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bca299cb-0b92-480e-a679-8112facfe5cd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bdbd52ea-a312-4e7b-9c2c-96536fba9bbb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bdcf3966-d341-49fe-9639-a28a8a114fc0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bf6e2804-2a6a-4226-8945-b296df4c17e9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c70d3642-ff39-4768-9190-0047e020c379"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c7396a83-132e-4c3d-8613-14d7e51228ad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c7b7e38b-5cbb-40be-bf3d-115ef57cce43"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c7c9556d-9134-458b-9c2e-21cb2e06d9cd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c8c9ff96-e9a2-4697-8ecf-cc189c4d2070"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c9d21c7d-4b2d-4972-aee3-dbdcb729e98d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ca6ade48-41c1-414e-93af-3497277875cc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("caba44c2-88f3-4815-a74f-967ed8ac070c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("caef5096-381d-48fa-b760-809996f80b05"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("caf347e1-2d80-441f-8cba-3f46ef1738a8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cbf8d8cc-dc3d-4072-869a-8e806f6d54b3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d1d8f543-471b-4a23-af2f-40131e26a3dc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d32a34b0-29f3-4a42-a76b-6e605c26ec35"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d380135b-fe00-4f43-909c-ad58de53c212"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d4fe57d3-d499-445b-b154-c53b65793433"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d6031462-46b0-4bb9-a1a7-c195383d78f7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d8602b3c-7d58-42e5-b86d-cc3da66b5080"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d9f8ca6f-efbb-4d78-b3c2-d5c4b61e8fab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("da66ee01-7d5b-4dd2-8f36-b1a9f4b1ed1b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("db878df3-2eaf-485c-b9cc-d0e502e6ffbc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("db89ef4a-84e0-43bf-8538-c7f6ce015068"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dc9e80f8-8f1b-4b11-b7f4-c59dc128c3f8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dd616591-7480-42f3-bb21-44033ae3341b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dd832c41-be84-42ed-a947-4eabee1570de"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("deb07bfa-089a-4a66-8d94-cdbc52c07d12"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dfc5971f-ff04-4856-8807-4b1e7987027b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e0102894-d7eb-4fcd-8df8-51c3ace67309"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e11a0e47-b7e8-4fe4-af99-f8f32fae1625"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e30a0100-a833-4f58-8860-3232052de22e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e3619910-46b8-44be-b31f-6d3c45fb6c50"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e77f860a-e8e2-4093-bf5d-f774bca18bc7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("eb3505c3-d623-4fe7-b8ec-e232627bb4e4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ef807986-70ef-47c1-9cb1-9ddb80d3aee1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f14d51c2-9a53-4bf8-9479-178eebd106f5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f1d18a24-2c25-4192-8054-39eb0b9e36b7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f2a37af5-9ca0-40cf-ba7a-9c95f45ef37f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f799fe25-e356-496c-a1db-6e47266573d6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f7f0eacf-05c6-41f1-b186-2d18c18c0524"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f99fc6e4-865a-494b-a0f5-0fa20984a075"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fa7a49cb-9a7f-46b2-8041-95f3f49854d2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fcadc9f4-7fc3-43d3-bbec-986cdc1d7b7e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fd0735ad-0b65-44f7-b276-afed29f20e96"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fd5024cf-4980-4b71-a9ee-dcddd695b3aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fdc5a158-5507-4542-8663-4ce110a04fb5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fe2b8f0c-c2dc-4faf-a7a7-7f9bd9a047a9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fec410e8-cb96-4a5c-bb40-c96aa1e926ff"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fef15fe8-f90a-4998-8fc3-8ccd0bb7a6b5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("543585bc-27dd-4249-8198-4a48b2c45bbe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("613768ef-c0f5-46b2-bf9d-3f114211d7bc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("65f0cfdf-5a94-42be-8586-0066b903c84f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6640a9b6-d4d1-4214-b569-dc4d842d63ed"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6dacc240-4b36-42aa-8024-733bb6eb5294"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("78ca2d2b-02e8-45bf-90bb-77f1a87d163d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("a1afbf64-5e7c-484e-80ca-ddbfc5907680"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b2ef8747-cb28-4687-bd16-3f1007374f3f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b93b1724-82c9-430b-a1d8-169ba941c0b4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("bcb0bf60-a9db-4bd2-b796-7acd6b9ba9d5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c411ffc2-a0e0-4438-98e1-a52fb4be6ff0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e2ae9ef5-dce7-4606-aacd-9c6a98fd050d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e47e86b0-6bb2-4481-b217-ead5038327df"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f22ced0a-96d0-499a-9d73-02ed131732e4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("39a53e43-d907-4985-84f4-b8b4c2315648"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("8f48f282-a7f9-42e5-ba3f-423cc2a6cff4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("919e2d56-3954-4ba2-9e3d-98483276d4d5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("9bb9749a-d557-490b-b680-dd4c77faf451"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("bc0a8c64-1305-4f1a-b520-3ac7f57a16ab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("00ecc670-1c99-4ff5-b8ec-348f7e691f04"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("27f1c2ae-0023-4883-b015-f0724b1d1ac1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("330f71d2-e70c-4e20-a5f1-ef18cf7ab42f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("37392753-7983-41f6-9520-6794c51c02fb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("38d3ef6c-fd90-42a9-94b2-24c9dec84a6c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("461330dc-47af-47af-848d-6d3badbc7739"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("4dd61f80-7673-4eaf-bc85-b30a8e4a934b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("5fbbabdb-0097-4ac7-9ad7-5874533e43aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("653c36a1-f4d5-4ff3-b9a6-492d7f8f6456"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("6c7985d0-97fa-46e6-a307-94a7ab453509"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("8cf96154-b580-4884-95ca-0e1c59f875ab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("98b8162a-b443-449a-8dfb-c5b51c8b0827"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("b1f49884-20fb-433e-b999-9ceaee0b7246"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("b34cf0d8-c576-41c7-8175-bdf19350f150"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("c7519680-1f67-404b-ab85-7997919e9a5c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("ceed3716-2eee-4ab7-a049-a9f1a2f0d1b6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d25b597b-2e9e-40bc-9099-62cef05e0c4e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d3528422-cf2a-445e-b52e-1cabd382802d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("df9ccf4c-44b7-45b5-8042-ca1be089af41"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("e566b9d2-2934-4db8-80e3-cfd1b3749861"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("e6e592bc-e20e-4ebe-9ea5-d62820b0f348"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("e9b88e8f-8fb0-432e-aab6-185540126b0d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("f1bad98b-3314-4b28-9a4d-03d3547c8a17"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("0eb1cba5-2ef9-4885-8c55-8365eb74c6e3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("2b2bc2d5-7a39-4b48-96d0-9f9a40267e13"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("53f923eb-2257-4854-8d1c-20729aa6c8ca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("5e885731-ad6d-406b-9e37-7e9fcf1a2e47"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("b04a7d6e-73d1-41fe-8879-090b68cdaf77"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("b66eb58d-ae1f-4082-ac44-9b7c39ce2b85"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("05f9a629-6619-4b07-982a-5a08d204bf44"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("076ea9e2-d1b7-41ae-b007-a1773c54d4d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("08fe1685-e5a7-401b-970a-05c3d0e6d76d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0d39d4fc-5afa-45dd-9923-86c0c7b3c347"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0efeefb2-806f-4875-b062-fd201f006f07"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0ffd28e0-7457-478a-a256-a29114efe38d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("174c82a0-69b7-4ff3-aeee-a53363dc0b24"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("1848f487-fc9d-4fa8-a51b-bd2d16b98f4a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("26cfd04a-417e-4618-bbf1-a237f4cff9c5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2b240861-de8d-44e2-8b20-529f033ae0c4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("4024e881-7178-459c-a361-2786d2f6feab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("41fb1c23-cbc8-4260-a800-39abae7c48ee"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("43b46e41-a52a-47a2-b292-a792ca05f90f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("474febb8-c1c7-4a17-8808-f704b7b4abad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5ada6879-6e2b-4297-8a4b-f0eb1eeaaad3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6f1a9b7b-c909-4ade-921a-f07675c2896f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("7745e42b-5072-4c8f-afe5-751522420537"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("902c6f1d-bec8-43d2-818d-b6fc9bae02b7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("91280855-873d-4992-b30f-e57e606fe917"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9f04ef94-4b96-4fbc-8f5a-bac47b9cd94c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("a9f01638-d11a-4227-aa94-e50ab80f908b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ac674bcc-ec67-42d1-b74c-998b57544a32"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b0183a22-44f8-41d9-aa8a-101ded21e9f4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c7d0a597-08ee-4d2e-b081-aabb2f8c3693"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c9baa073-4ef8-466b-976e-b9376f0b7a5c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("cb4900e9-68e1-4399-93a3-903aa6c6b225"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("d5169424-54dd-4982-8914-4bde559dc4c4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e6b47083-b88c-4135-bf99-57d25761abd1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e9504587-5e5a-4c84-87cf-4422df70a01a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ece65964-19ad-4bc5-8fb4-9c32d9f46df4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f32399a7-d640-4cec-90cd-d48fabb031ac"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f7d114a1-937d-48bc-9133-a03e796c8003"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ffe65493-42c8-4a18-bb06-225f85464746"));

            migrationBuilder.AddColumn<Guid>(
                name: "CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_Service",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Time",
                schema: "sp",
                table: "SP_Plan",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SP_ServiceListingsServices",
                schema: "sp",
                table: "SP_ServiceListingsServices",
                columns: new[] { "ServiceListingId", "ServiceId" });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Category",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2977), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2976), "Professional & Digital Services", "" },
                    { new Guid("28c265dc-a7c3-47d1-9388-249b5d792587"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2962), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2961), "Cleaning & Housekeeping", "" },
                    { new Guid("502dd23e-a9f0-4c9d-9e7e-ef1972397895"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2967), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2967), "Ride Hailing & Delivery Services", "" },
                    { new Guid("642de52e-39c6-4912-847e-a8565ed82e76"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2972), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2972), "Fitness & Wellness Services", "" },
                    { new Guid("9c8bef09-0f7e-44ca-a68e-ad7747cb7363"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2964), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2963), "Landscaping & Gardening", "" },
                    { new Guid("a3aaf6e4-1b6d-47d5-9800-9e9f51e2b148"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2975), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2975), "Web & IT Support Services", "" },
                    { new Guid("c53751c3-0dc5-47e2-b7f7-c883fbe97614"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2971), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2970), "Tutoring & Educational Services", "" },
                    { new Guid("dabd7dfe-7e87-4538-a7a1-d3b985621739"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2974), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2973), "Beauty, SPA & Personal Care Services", "" },
                    { new Guid("e1923afa-fcbf-4ac7-bd5d-e1ca6a7d6087"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2965), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2965), "Jua Kali & General Repairs", "" },
                    { new Guid("f7ee0712-5c36-4f48-852f-4e166e5c7e90"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2969), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(2969), "Catering & Event Services", "" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_County",
                columns: new[] { "Id", "CountyName", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), "NAKURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09c5379b-c500-4e12-b9b8-0fc7a63d6557"), "LAMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0b19231e-90ed-4221-8692-66f86d6dc69e"), "KISUMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0bf24f06-5988-4a4d-be47-d9a1f98c7836"), "ELGEYO/MARAKWET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), "WAJIR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1e83f693-b970-40f7-8f80-d503880b2212"), "KAKAMEGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2b0e1c2b-157f-4581-850a-947e56a5cecc"), "MARSABIT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), "MURANG'A", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"), "TRANS NZOIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), "KILIFI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36289aa3-03ad-49f6-a520-2dfe5170efa1"), "BOMET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3af79e1f-bbc8-4365-bdf9-811df2768e70"), "THARAKA-NITHI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), "NYERI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4e0acc24-e1a5-420d-83ca-e0371e01a372"), "BUNGOMA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("537c7657-95a8-4b4c-b5b9-2fde03245a01"), "WEST POKOT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("575777c9-ff19-45b8-9370-a7ceb94f898d"), "LAIKIPIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5c59e543-b9ff-4c8c-9907-51cdde4271c1"), "KERICHO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("605fc00d-bd73-4cae-b7cf-faf5cb662cd5"), "MIGORI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("616e14eb-f04d-42d4-bc51-fd60d0659e74"), "KISII", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), "GARISSA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), "MAKUENI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("70baf021-39f7-4d98-a8f2-afbc6d3e0bd1"), "KAJIADO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("72bb0406-5277-4099-9723-f5631c89bec8"), "ISIOLO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7edce8ab-396c-4b4d-8730-b3d6f78341f0"), "TANA RIVER", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), "TURKANA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), "KITUI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9b2d7b80-4c31-4b0c-8186-80a04859aa0b"), "KWALE", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("af46fa09-5da7-486c-b8a4-e80957870192"), "SIAYA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b32c957d-fdaa-4bdc-9356-840ec99ef588"), "TAITA TAVETA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c6634824-a82d-41ed-8ffd-219147146440"), "BARINGO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c79dc5f4-f3bb-480c-ada6-ffa5213a9623"), "NAROK", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cb1bba0f-bfd9-40f4-9a0d-ef7db92b1716"), "EMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), "NANDI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ce1fa6b3-d97e-4458-ab14-118e61d9ea4c"), "KIRINYAGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d2b086d1-288d-4f3f-8cdb-523908566225"), "BUSIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dba11a97-a798-45d4-af4f-10c4e3f1722c"), "SAMBURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), "KIAMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), "MERU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e611d42a-feff-465a-9752-6aed23493e5d"), "HOMA BAY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e7ee76e4-47b7-438f-9b91-1dade87db902"), "VIHIGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eba90251-1aa0-4d0c-8432-96a1115e0436"), "NYAMIRA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), "UASIN GISHU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), "MANDERA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), "MOMBASA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), "MACHAKOS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), "NAIROBI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fe405cc4-cf41-44d5-ad07-b9d78cefba21"), "NYANDARUA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Location",
                columns: new[] { "Id", "ConstituencyId", "DateCreated", "DateModified", "LocationName" },
                values: new object[,]
                {
                    { new Guid("15f45a3e-30eb-4971-9a59-85905952132c"), new Guid("56b89997-d006-458e-a851-d25a63a52eda"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kasarani" },
                    { new Guid("28b1c5f4-7d38-4b7c-8557-8dd205b95447"), new Guid("56b89997-d006-458e-a851-d25a63a52eda"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ruai" },
                    { new Guid("6455ad05-d89b-4e62-a92e-4d4399ea64e2"), new Guid("56b89997-d006-458e-a851-d25a63a52eda"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mwiki" },
                    { new Guid("81ae0752-c3a6-4cc4-a6e8-d3c4860696a7"), new Guid("56b89997-d006-458e-a851-d25a63a52eda"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Njiru" },
                    { new Guid("cca3cad1-fec0-460c-b1a5-d11a76923964"), new Guid("56b89997-d006-458e-a851-d25a63a52eda"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Claycity" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Constituency",
                columns: new[] { "Id", "ConstituencyName", "CountyId", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("00f2e6d0-e477-4a15-bf5c-081e11b87820"), "Ol Kalou", new Guid("fe405cc4-cf41-44d5-ad07-b9d78cefba21"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("02f2d11e-ce0b-4769-9262-1c19d63344fa"), "Kiminini", new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0351d6f1-4275-4349-bd78-0486b8031f31"), "Mathare", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("055a397c-079f-4845-b956-73b59064774c"), "Masinga", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("060b9812-e498-4f9b-9782-90287200673d"), "Keiyo South", new Guid("0bf24f06-5988-4a4d-be47-d9a1f98c7836"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("06b9dff2-1666-4ee0-b7f7-c200d070b7a6"), "Tigania West", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09794c49-9ca3-4a3c-aee8-d60d48ce5669"), "Kitui South", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09cc580a-480d-4e19-b701-edd9efb67ab7"), "Mwingi North", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("09d25ee4-259d-46c9-bf11-30be9899f654"), "Turkana Central", new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0b32c198-d0b6-4150-b405-40af50d27504"), "Nyali", new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0c2310d9-fd7d-464f-b352-a9c9f0f147e5"), "Ruaraka", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0c67c9fe-0bd0-4bec-b7b2-9ccceb776192"), "Samburu North", new Guid("dba11a97-a798-45d4-af4f-10c4e3f1722c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0ef5cc42-7797-438a-9fd6-f0f4f24fbbc8"), "Manyatta", new Guid("cb1bba0f-bfd9-40f4-9a0d-ef7db92b1716"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1336dff4-9413-441f-b885-ac50b0a058af"), "Ndaragwa", new Guid("fe405cc4-cf41-44d5-ad07-b9d78cefba21"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("15161dff-eb93-4008-a4c9-63a62aab1d91"), "North Horr", new Guid("2b0e1c2b-157f-4581-850a-947e56a5cecc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1542f83f-560e-4adf-a0aa-4f0fa5ea58c2"), "Tharaka", new Guid("3af79e1f-bbc8-4365-bdf9-811df2768e70"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("15856a2b-9bec-4b27-80d7-b2101e23f2a7"), "Garissa Township", new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("174c2e9e-8b31-44ab-af19-d0d617faf4be"), "Soy", new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("174c92f2-f047-4839-8e3d-29afa8db8609"), "Baringo North", new Guid("c6634824-a82d-41ed-8ffd-219147146440"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("185fb642-045a-4d7a-8619-525d675efa06"), "Garsen", new Guid("7edce8ab-396c-4b4d-8730-b3d6f78341f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1aed4f32-c883-4b97-958e-ef6eb68a677f"), "Kapseret", new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1f6a1b41-1df4-42d2-b162-43b335714db0"), "Gatanga", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("216073bd-7853-4a65-8e52-a6c754d107e9"), "Wajir East", new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22516c62-3e05-4493-b879-05e644bf9562"), "Mukurweini", new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22912dfb-8029-4d73-a13d-bb0c0fa5c8f2"), "Turbo", new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2517e9c9-f0b4-4014-8bd0-95ce9d3bf737"), "Gilgil", new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2579da6f-1235-45e6-adaa-d5ca243bb4d8"), "Wundanyi", new Guid("b32c957d-fdaa-4bdc-9356-840ec99ef588"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("25f444e7-e4bd-422d-8cf7-ffff91529136"), "Malindi", new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("26a9c2ad-15b9-4dd6-810a-110a2024bd9e"), "Tinderet", new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("26c56be9-a92a-4740-b253-05cb3478a952"), "Saboti", new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("28699d70-d9b4-492e-9ae3-2877ddcc7bcd"), "Nyeri Town", new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("289e5f8d-c479-4490-9cb1-b5672712e4dd"), "Machakos Town", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2b6c14f6-2152-4185-b3ce-88b7afbf3af3"), "North Imenti", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2cc759cb-7fa3-4bf2-830f-2f68f79cb0d7"), "Kitui East", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("30a1a3a8-0d62-48cc-bf98-03aae08e0410"), "Mavoko", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3151c7e0-4397-4c38-a7b6-a452870d9729"), "Kabete", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3649571a-84c6-4334-874e-4096bcfcba26"), "Embakasi Central", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36512ad1-e7a0-4eac-9dab-7147b60dc031"), "Kuresoi South", new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36605f31-35c3-4142-9c18-9880c6a1a175"), "Banissa", new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36a0b32e-681c-4c7b-b2a1-18e723761b32"), "Kamukunji", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("374e39d9-c4b5-496b-bb25-4b29496ed041"), "Voi", new Guid("b32c957d-fdaa-4bdc-9356-840ec99ef588"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("37a2c883-bab6-4f0e-8d0d-72c2dc43d816"), "Loima", new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("38db608b-8981-4936-bff4-7e71934908f3"), "Sigor", new Guid("537c7657-95a8-4b4c-b5b9-2fde03245a01"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3b3e498f-f019-44a3-b4a0-eef5e1fc26ca"), "Eldama Ravine", new Guid("c6634824-a82d-41ed-8ffd-219147146440"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3d467d8f-07c6-4aff-afd4-83a2b478c925"), "Runyenjes", new Guid("cb1bba0f-bfd9-40f4-9a0d-ef7db92b1716"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3deba142-19b5-4e64-a905-701886ac2b7c"), "Marakwet West", new Guid("0bf24f06-5988-4a4d-be47-d9a1f98c7836"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3e98a75c-06fc-4c89-ac42-2cbd1180149e"), "Ganze", new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3edf7548-f820-4ce3-9bd5-f8442c2949c0"), "Kiambaa", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3f78a17f-34f3-415e-b5e1-245b2b90a808"), "Tetu", new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4050e743-14a4-4c79-9296-07713d22c6aa"), "Kwanza", new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("42a48b27-57e2-483e-b7ce-a3dc59fc37c0"), "Maragwa", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("42b5a2d0-5434-4af8-8bad-6215b5a65569"), "Turkana North", new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("46981384-0b4e-4768-bca9-e70abbedee2a"), "Lungalunga", new Guid("9b2d7b80-4c31-4b0c-8186-80a04859aa0b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("47ca91f4-145f-4c51-b2d8-d454a6392b77"), "Mandera East", new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4801c94a-4f1a-419e-9fe3-9cb0092783ff"), "Tigania East", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4d793e76-bdde-4dbe-94d3-0c9fadf32762"), "Mwatate", new Guid("b32c957d-fdaa-4bdc-9356-840ec99ef588"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4ead04e6-6163-4019-9228-3911589385ff"), "Kiambu", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4f3b452d-3771-4a8f-b82f-2f918efa7d0d"), "Isiolo North", new Guid("72bb0406-5277-4099-9723-f5631c89bec8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4f75c836-7424-46db-9ee3-c5d964028bd5"), "Daadab", new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4fb5eb62-3acd-468d-9b96-f6bb789e2919"), "Eldas", new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50ea6c83-95cc-452e-b9d4-82edc468e3bd"), "Magarini", new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("517de4aa-ae8e-44cb-b4ec-06537d55c692"), "Ol Jorok", new Guid("fe405cc4-cf41-44d5-ad07-b9d78cefba21"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55bbb1a2-6364-43a6-afc3-b9fcf58aa779"), "Nandi Hills", new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("56b89997-d006-458e-a851-d25a63a52eda"), "Kasarani", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57ef3c70-9d72-4db0-8e33-9d9bdd6d34bf"), "Molo", new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("581d3758-1032-41aa-9ec3-6d6d82db2799"), "Ijara", new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("58a26f8d-c1a6-4795-825f-5c16ceabf7be"), "South Imenti", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5961f883-b5cb-4324-beab-6863d9fd328c"), "Marakwet East", new Guid("0bf24f06-5988-4a4d-be47-d9a1f98c7836"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5c773750-3149-43a0-b4a6-69e0030db84f"), "Kilifi South", new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5e686b55-6196-4ea3-b1c5-d934aee83b45"), "Kangema", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("63792bb6-8a6b-4bcb-9db5-d8f6a89e7a8a"), "Ainabkoi", new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6635777a-65ad-4366-8639-62976603a735"), "Saku", new Guid("2b0e1c2b-157f-4581-850a-947e56a5cecc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("666d6f82-9041-4f4d-bd5a-23eee6cd3dc0"), "Kacheliba", new Guid("537c7657-95a8-4b4c-b5b9-2fde03245a01"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("67c0289f-7029-453b-88da-9acd6dada7a0"), "Roysambu", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6a405972-c20d-4161-8c31-319fbea06bc0"), "Fafi", new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6b6bc4c0-04ee-4ef0-85fe-582ce9187a47"), "Wajir West", new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6d820397-07e3-4e9d-8cb5-1c98d2574719"), "Mwala", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6d8610fe-1d0f-440e-8a42-ed8b4a56aaf4"), "Kandara", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6fc9ca01-71b4-4f06-8f8c-fdfa7e6e07f6"), "Mathira", new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("70628a70-e7ac-4273-a7ed-323b076a0aa3"), "Lamu West", new Guid("09c5379b-c500-4e12-b9b8-0fc7a63d6557"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("712e00fb-dd4b-460a-b58e-b24609b9d88f"), "Kisauni", new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("71476f7f-40fa-4e13-8369-3b1b4920b681"), "Gichugu", new Guid("ce1fa6b3-d97e-4458-ab14-118e61d9ea4c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("717ba905-f40e-4f59-bfcb-882ce78ba45d"), "Igembe Central", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("71cb21c6-0c82-4d44-9421-81af1392d1dc"), "Kapenguria", new Guid("537c7657-95a8-4b4c-b5b9-2fde03245a01"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("73daec9d-f1ea-4305-94ae-f95a9e4dffdc"), "Pokot South", new Guid("537c7657-95a8-4b4c-b5b9-2fde03245a01"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("73f2ab48-5457-4a6a-bc5b-8c278784c2b2"), "Msambweni", new Guid("9b2d7b80-4c31-4b0c-8186-80a04859aa0b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("768541fe-a1f8-4b5b-9175-c167b6195950"), "Matungulu", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("76e4e966-008f-4995-8656-97fdbd61a3ea"), "Kieni", new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7701feaf-41a5-4f16-b06e-bedac7797ae9"), "Kibwezi East", new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("777d6586-83c6-4405-9257-56c635695a14"), "Limuru", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7993458b-10c4-44f1-8c5c-adfee8502cf9"), "Gatundu North", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7cb17adb-915c-4840-b211-bcbb62c76275"), "Lagdera", new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7dc462d6-6d9a-4ce1-b222-4b83bdf0fe64"), "Jomvu", new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82134a50-f9cf-4c56-94e7-c9078ff9c656"), "Kangundo", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8217e211-2508-4c7d-bef5-ba5b12ab121f"), "Kigumo", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82b31b11-be43-4a72-b27e-213e40b2155c"), "Turkana West", new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82c21665-8b3c-4cc7-9369-3b6d5f5e3b96"), "Kitui Rural", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82dd43f9-8222-4592-a037-cecb5ccda02e"), "Makadara", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82e1a766-a9df-4281-903a-6fbb9c33c019"), "Embakasi East", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("84c4c2a1-dad2-49f1-8ba4-6e40efa32de0"), "Tarbaj", new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87840d91-1830-4a18-b448-959f2148c9df"), "Lafey", new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8785aedf-9a50-4806-ab3d-4996939ea426"), "Dagoretti South", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("883ef1e4-5502-43b4-8d7f-113adf0e474a"), "Kitui Central", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("89dd6cc6-bf9f-44e4-a307-9cf6610e646b"), "Juja", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8a051adf-c2ea-4def-8c42-d505034a89d8"), "Samburu East", new Guid("dba11a97-a798-45d4-af4f-10c4e3f1722c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8da0085c-d845-47ba-9b30-c7c16ecd1274"), "Yatta", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("90c1f955-8c8a-4740-97d6-c25d153e792c"), "Galole", new Guid("7edce8ab-396c-4b4d-8730-b3d6f78341f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("915bf705-fe0e-46c8-90b4-6182bf3cb1e3"), "Mandera South", new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("92c438b6-7c3f-4e49-bd84-9a9767dee98e"), "Embakasi North", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("92ce1d86-32d6-4645-a651-5475836724a1"), "Langata", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9476f504-1a6c-4e2c-88a8-867a190905db"), "Central Imenti", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("95791121-62c5-4e04-8271-afedf4a34558"), "Mandera North", new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("95fb1421-c056-463a-ad96-46234be9a65b"), "Likoni", new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9dc85c9f-a367-4965-a082-610043116199"), "Igembe South", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9fa3f983-25a1-4406-8335-e6111473bd72"), "Mathioya", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a05854e2-874a-40a8-a9c2-6805dba717c9"), "Mvita", new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a06c834d-dbf7-4822-a872-f846bf1d4e18"), "Turkana East", new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a26718d4-6213-4435-a982-7e04bdac6531"), "Othaya", new Guid("4dd46e4e-e393-4efe-873a-64771fa4d181"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a351053a-145d-41aa-bb17-0e17253fefec"), "Chesumei", new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a4b1c949-d915-4af9-892f-69e94e0c596a"), "Kiharu", new Guid("2b3d5442-f988-4f8a-a568-56188a6bfae5"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a510067d-4ef7-412f-ae94-9fc0c6870abe"), "Wajir South", new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac24dcd8-2a04-4b4c-8e66-101f31ddc3b8"), "Maara", new Guid("3af79e1f-bbc8-4365-bdf9-811df2768e70"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac7e9f27-d0e6-4dd4-8359-e9c0d65aa86c"), "Kilome", new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("acef6d1d-6029-473b-94bb-4c59682baeb7"), "Westlands", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ad3b4011-18eb-4afa-8ba5-242d6e4457bb"), "Rabai", new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("add7ebcc-4a12-4ea5-9561-5060f0ae8de3"), "Gatundu South", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b0550a84-71ea-45b5-bd37-b5cbe89141c3"), "Turkana South", new Guid("8e184c2d-11d0-4a56-b154-ce520439a4c3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b0bb6705-8a80-455d-9049-477cc3897c92"), "Kathiani", new Guid("faeff6b2-ed9a-40a1-9f32-cc56b0431b3c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b2f40da9-6488-4825-976f-fdd7b29b18d4"), "Kikuyu", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b3ef00dd-0529-4f2c-85df-a0fda7e507ac"), "Mwea", new Guid("ce1fa6b3-d97e-4458-ab14-118e61d9ea4c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b5502ba8-911f-452b-9dda-965ec0890470"), "Embakasi West", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b7625719-d1c1-4c53-ae25-292c124a628c"), "Laisamis", new Guid("2b0e1c2b-157f-4581-850a-947e56a5cecc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b765dd01-c7f3-44ef-b2c5-24d8aa8bb173"), "Mosop", new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b86f14d9-d352-459c-986e-813fea3abc60"), "Bura", new Guid("7edce8ab-396c-4b4d-8730-b3d6f78341f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b88a3dac-817a-4746-83bb-801d8e056675"), "Makueni", new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bac3f867-96cf-406e-8098-4994ea309431"), "Kaiti", new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bbf44382-27d9-4919-82b8-b9a74b368ee6"), "Wajir North", new Guid("166b5539-60d1-4e6c-a551-35c1b09b6ce0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bd090c0e-436b-46d3-8816-ece458e6236f"), "Laikipia East", new Guid("575777c9-ff19-45b8-9370-a7ceb94f898d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c0cb361e-688c-45ab-953d-7bf8a1eaf53c"), "Thika Town", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c18c1e40-e34c-44e2-af39-10c4020ca1aa"), "Embakasi South", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c2a63ac0-d954-4a34-b166-e4e0ac8b3138"), "Kibwezi West", new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c30b2866-8684-4f32-9ca6-48a549aa60fe"), "Moyale", new Guid("2b0e1c2b-157f-4581-850a-947e56a5cecc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c66f9a5a-7409-49cf-8382-f5c2d78ca69b"), "Kibra", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c73056ae-36b3-4b5c-91d9-fd7ec0cef5f3"), "Endebess", new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c97c95a7-ea72-4031-8dbe-5f4275795761"), "Ruiru", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cad68b36-151a-4c93-b659-d7a4e749d5fd"), "Lari", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cc4ae899-9c6d-4b81-9197-98ce0996c439"), "Laikipia West", new Guid("575777c9-ff19-45b8-9370-a7ceb94f898d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd2f2870-9386-4d3a-8a9b-c4834493bd85"), "Mbeere South", new Guid("cb1bba0f-bfd9-40f4-9a0d-ef7db92b1716"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd5e0830-5f46-4142-8107-619994dd18d7"), "Chuka/Igambang'ombe", new Guid("3af79e1f-bbc8-4365-bdf9-811df2768e70"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cf5a1767-a12d-4be5-baf0-10ac7f0ab6fe"), "Kesses", new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cfaa5544-0053-450b-8291-a4982c232745"), "Matuga", new Guid("9b2d7b80-4c31-4b0c-8186-80a04859aa0b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cffba51b-98d7-4347-8587-c1985ba4f3d8"), "Kuresoi North", new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d004c0dd-9efd-4945-ae17-ec59143d86d5"), "Kinango", new Guid("9b2d7b80-4c31-4b0c-8186-80a04859aa0b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d21ae405-44b9-47cd-8165-376c95a1fb80"), "Mbooni", new Guid("65405cfc-eab5-4ca7-b10e-e3fa8437629e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d39dab19-5460-402a-aa57-74883772cced"), "Naivasha", new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d3f3748e-c895-4012-8a09-6722eea97726"), "Taveta", new Guid("b32c957d-fdaa-4bdc-9356-840ec99ef588"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d59a741f-86aa-401f-8845-18fc909b9e7d"), "Githunguri", new Guid("e001b827-2812-4a93-8dac-e028fc87b27e"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d778ee17-6db4-45c3-b5c3-dafef0b2528a"), "Mwingi Central", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d7cf1a02-248e-415f-9e65-f900f4598e98"), "Mwingi West", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d9293c86-adb9-4097-bade-e810750f940c"), "Kirinyaga Central", new Guid("ce1fa6b3-d97e-4458-ab14-118e61d9ea4c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dcc8137b-640a-4445-8713-b84e381c40e1"), "Changamwe", new Guid("f6993f55-9959-4005-ad34-5db2d4431c64"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("df0b9210-b106-4319-9cbe-4a7ff309d3a2"), "Lamu East", new Guid("09c5379b-c500-4e12-b9b8-0fc7a63d6557"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e1bd58fc-c636-44b1-8ac6-1996a9fba8b5"), "Baringo South", new Guid("c6634824-a82d-41ed-8ffd-219147146440"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e37a2dda-badf-4581-b849-93fdc9964770"), "Mogotio", new Guid("c6634824-a82d-41ed-8ffd-219147146440"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e62ad177-e20a-4c9c-b096-830c3968b7f0"), "Baringo Central", new Guid("c6634824-a82d-41ed-8ffd-219147146440"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e7384e2c-df7d-47cf-93d0-496f8be2da44"), "Dagoretti North", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e7afec40-bf73-4562-88dc-4302f6ad47ae"), "Njoro", new Guid("00ec656a-62e8-4e16-8b10-6b0438bc9b63"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e90532c7-2510-4d87-9933-06ecd1eabb9a"), "Kipipiri", new Guid("fe405cc4-cf41-44d5-ad07-b9d78cefba21"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e90ec4d2-4fa2-4d93-ba2d-0de0b821d085"), "Emgwen", new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e990bf7d-c60a-4f68-bbeb-12196e1b9f2b"), "Starehe", new Guid("fcb809f7-1ad3-4fa9-b03f-de364186236d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ea379b1a-9cbd-46a6-8b8e-d275761d9184"), "Isiolo South", new Guid("72bb0406-5277-4099-9723-f5631c89bec8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eab71cbe-5d84-4267-a76a-633c60f52f12"), "Ndia", new Guid("ce1fa6b3-d97e-4458-ab14-118e61d9ea4c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ec35dfe0-4c45-480d-9e48-6c77ae7c8ec1"), "Laikipia North", new Guid("575777c9-ff19-45b8-9370-a7ceb94f898d"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ef9785f8-e26e-4072-badf-97eaf3b3233c"), "Kitui West", new Guid("9389cdb2-1467-40cb-a3fd-6b1762742482"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f04da4f8-f3b3-4755-a9ce-df5d8be0e7ad"), "Keiyo North", new Guid("0bf24f06-5988-4a4d-be47-d9a1f98c7836"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f116c308-12a1-4b4f-ae78-597ea70a68df"), "Igembe North", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f3524eac-faad-4193-8577-c2bf81ad4982"), "Mandera West", new Guid("f2ea3621-0471-45a5-bf46-7bbc132b95bb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f6691e6c-c87e-487f-8e54-03784da1c46d"), "Samburu West", new Guid("dba11a97-a798-45d4-af4f-10c4e3f1722c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f6b20a82-e32a-49a3-9348-b3e90e461007"), "Cherangany", new Guid("2bce4ee7-3048-4438-9745-805b8cd175fa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f9366cca-76c9-47f0-87a3-d1a8dbf26534"), "Aldai", new Guid("ccd111d9-80bb-4756-9592-5c1a9ec579fd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fa4d35c5-e788-42b9-abba-a391609b079f"), "Mbeere North", new Guid("cb1bba0f-bfd9-40f4-9a0d-ef7db92b1716"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fc5626b9-066e-447a-9454-185cf9a26166"), "Balambala", new Guid("618b390b-c2b8-450e-8328-9796e166adf3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fcbe2be0-2306-4be1-9849-11e3d3359a09"), "Kilifi North", new Guid("34b7a70c-aa6b-4cf3-b1c9-c8b25f1f149b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fe12a615-1a56-4f48-808f-ca214e7f8f1e"), "Buuri", new Guid("e0428fbb-eb8f-43c7-9b2e-848f3261d025"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fe4cdad2-0a5b-4054-be33-4e4afde6cf39"), "Moiben", new Guid("ef6c8566-9a0b-4f19-a2e6-2ffa826830f3"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Service",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Description", "Name", "ServiceListingId", "ServiceProviderEntityId" },
                values: new object[,]
                {
                    { new Guid("18d983a0-b6b8-4aef-961c-f035ffa44bb0"), new Guid("f7ee0712-5c36-4f48-852f-4e166e5c7e90"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3078), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3079), "Reliable ushering and event staffing services to ensure smooth operations and excellent guest experiences at your events.", "Ushering & Event Staffing", null, null },
                    { new Guid("224520cd-35b4-46eb-993c-d09e65eabe1a"), new Guid("e1923afa-fcbf-4ac7-bd5d-e1ca6a7d6087"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3034), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3034), "Expert plumbing services including leak repairs, fixture installations, and maintenance for residential and commercial properties.", "Plumbing (leak fixes, installations)", null, null },
                    { new Guid("27935e43-0ed4-40e3-9dca-abeb1cf98801"), new Guid("28c265dc-a7c3-47d1-9388-249b5d792587"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3026), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3027), "Professional office cleaning services tailored to maintain a clean and productive work environment.", "Office Cleaning", null, null },
                    { new Guid("298828d6-75bf-4ef7-8bff-2d93603e3b66"), new Guid("dabd7dfe-7e87-4538-a7a1-d3b985621739"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3083), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3084), "Comprehensive fitness and wellness services including personal training, yoga & gym classes, and nutrition counseling to help you achieve your health goals.", "Fitness & Wellness Services", null, null },
                    { new Guid("36f3a6e9-0507-4e95-896a-6cacb7d71f2d"), new Guid("dabd7dfe-7e87-4538-a7a1-d3b985621739"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3081), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3081), "Professional beauty and spa services including facials, manicure, hairdressing, massages, and skincare treatments to promote relaxation and wellness.", "Beauty & Spa Services", null, null },
                    { new Guid("4c165db6-c4d9-4b21-bdea-d76c89a136e9"), new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3069), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3069), "Expert social media management services to enhance your brand's online presence and engage with your audience effectively.", "Social Media Management (SMM)", null, null },
                    { new Guid("583b404f-78cc-404b-a346-c9d83004ac81"), new Guid("e1923afa-fcbf-4ac7-bd5d-e1ca6a7d6087"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3039), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3039), "Professional carpentry services including furniture making, repairs, and custom woodwork for residential and commercial clients.", "Carpentry Services", null, null },
                    { new Guid("65e295bd-b496-43e9-9e87-840a63b101b3"), new Guid("502dd23e-a9f0-4c9d-9e7e-ef1972397895"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3050), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3050), "Efficient food delivery services partnering with local restaurants to bring meals directly to customers' doorsteps.", "Food Delivery", null, null },
                    { new Guid("66cf9499-4485-473c-941b-e30a5dcba2fb"), new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3057), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3057), "Comprehensive digital marketing solutions including SEO, social media management, and online advertising to boost your online presence.", "Digital Marketing Services", null, null },
                    { new Guid("8e07b356-6b30-4996-8819-0528390c2aa2"), new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3062), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3062), "Professional web development services to create responsive, user-friendly websites tailored to your business needs.", "Web Development", null, null },
                    { new Guid("952f5839-f61b-4716-976e-4c8563f19a68"), new Guid("f7ee0712-5c36-4f48-852f-4e166e5c7e90"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3074), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3074), "Expert photography and videography services capturing memorable moments at events and creating stunning portraits for individuals and families.", "Photography & Videography (events, portraits)", null, null },
                    { new Guid("98449cca-1677-43f6-8e2d-0402fa681e70"), new Guid("e1923afa-fcbf-4ac7-bd5d-e1ca6a7d6087"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3044), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3045), "Expert painting and decorating services for interior and exterior spaces, enhancing the aesthetic appeal of homes and businesses.", "Painting & Decorating", null, null },
                    { new Guid("9ba7e92e-c4d4-45f0-afaf-3f997afecf2c"), new Guid("f7ee0712-5c36-4f48-852f-4e166e5c7e90"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3076), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3076), "Professional decorator services for parties and functions, providing creative setups and themes to enhance the event atmosphere.", "Decorator Services (party, function setup)", null, null },
                    { new Guid("9e747cc6-4ecb-4155-b145-f169af026267"), new Guid("28c265dc-a7c3-47d1-9388-249b5d792587"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3023), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3024), "Comprehensive home cleaning services including dusting, vacuuming, mopping, and sanitizing all rooms.", "Home Cleaning", null, null },
                    { new Guid("b19717f1-2579-4b67-8e49-001fa3f7a2a6"), new Guid("e1923afa-fcbf-4ac7-bd5d-e1ca6a7d6087"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3036), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3037), "Comprehensive electrical services including repairs, installations, and maintenance for homes and businesses.", "Electrical Repairs & Installations", null, null },
                    { new Guid("cc0dfa50-a880-4a7d-8139-f244bbcdbc4b"), new Guid("502dd23e-a9f0-4c9d-9e7e-ef1972397895"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3047), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3047), "Reliable parcel delivery services offering door-to-door delivery within the city, ensuring timely and secure transport of packages.", "Parcel Delivery (door-to-door, within city)", null, null },
                    { new Guid("d6fb46c7-a78c-4fd5-a378-b8f4bba076f9"), new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3066), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3067), "Reliable IT support services including troubleshooting, network setup, and maintenance for businesses and individuals.", "IT Support Services", null, null },
                    { new Guid("d9501d32-ea7b-4651-96b5-bbab8e198ca0"), new Guid("502dd23e-a9f0-4c9d-9e7e-ef1972397895"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3054), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3055), "Fast and reliable grocery delivery services bringing fresh produce and essentials directly to customers' homes.", "Grocery Delivery", null, null },
                    { new Guid("dadc106f-031f-4205-8533-1e167d64c02a"), new Guid("502dd23e-a9f0-4c9d-9e7e-ef1972397895"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3052), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3052), "Convenient ride-hailing services providing safe and reliable transportation within the city for individuals and groups.", "Ride Hailing (in-city transport)", null, null },
                    { new Guid("e880be6e-2b43-45a7-996b-bec0919110b7"), new Guid("28c265dc-a7c3-47d1-9388-249b5d792587"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3029), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3029), "Specialized carpet cleaning services using advanced techniques to remove dirt, stains, and allergens.", "Carpet Cleaning", null, null },
                    { new Guid("f3fb2e81-1f53-4575-bf61-5ac65fe059f2"), new Guid("28c265dc-a7c3-47d1-9388-249b5d792587"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3031), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3032), "Professional window cleaning services for residential and commercial properties, ensuring streak-free results.", "Window Cleaning", null, null },
                    { new Guid("f912df0a-e104-48c1-a1b6-5c55042c2a1a"), new Guid("f7ee0712-5c36-4f48-852f-4e166e5c7e90"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3071), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3072), "Professional event catering services for weddings, corporate events, and special occasions, offering customized menus and exceptional service.", "Event Catering (weddings, corporate)", null, null },
                    { new Guid("ff94ddd0-66f5-4b0a-ad3d-7b94e1203dc1"), new Guid("26f38a65-9e3b-4c6b-81c4-0ddc27b9de81"), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3059), new DateTime(2025, 12, 1, 14, 11, 59, 98, DateTimeKind.Utc).AddTicks(3060), "Creative graphic design services for branding, marketing materials, and digital content to effectively communicate your message.", "Graphic Design", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListing_CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "CustomServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SP_Service_ServiceListingId",
                schema: "sp",
                table: "SP_Service",
                column: "ServiceListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_Service_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Service",
                column: "ServiceListingId",
                principalSchema: "sp",
                principalTable: "SP_ServiceListing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceListing_SP_CustomService_CustomServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "CustomServiceId",
                principalSchema: "sp",
                principalTable: "SP_CustomService",
                principalColumn: "Id");
        }
    }
}
