using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatedmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_ServiceListing_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DropIndex(
                name: "IX_SP_ServiceListing_ServiceId",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("01040697-0db1-4909-80d1-d89a163de7db"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("ae10ddb9-5029-48a6-83fe-7e098ad07e5a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("e768b07a-d356-4893-9a6d-7bb718656631"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("fdcc9027-5ebd-4cb9-b62d-3356dd26744e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("02327ba2-4a8b-40c5-9dec-6eebcc0c8702"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("02faf3fa-f8ff-4805-a5a5-bbec1a0f0334"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0310c9c1-38a1-4068-9f76-e9b40702fb0a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("04769e65-5d23-4f20-b9c8-e77b11dc5231"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("05b8f669-3b88-44e4-850f-3a34b4757a08"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("076d6e5c-a4a8-459f-b758-302b9383572a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0781a632-7bb3-4715-ae14-9051c0e38cd1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("07d9931f-6f39-41bb-b3a0-f63ce33d815c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("08949e8d-02aa-4f6c-b572-4427f7486b34"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0a0c20ad-694f-4be2-b2e4-60ed00a2581d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0b44bf11-b59a-4897-9717-f2b77f1748ca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0b5ca4ec-97c6-42fe-ad5a-475708930bbd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0d840707-03d1-4caa-82ff-02f0d2bcfb16"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0e081d23-bd28-470d-9e40-f3241ca017b7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0e411a56-523c-472a-a1c9-2f3cc69da4d4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0e9a1894-a5cd-46e7-9dd7-f9a52c51a2bc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("118c286c-2f25-4d86-86ae-098e3120c816"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1313ffc4-734c-4309-8bef-0da7a7424ed6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("13e44a40-0e9d-479f-8ee9-93db4a825c29"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("14c93f1c-5ac7-47ca-b37d-3940cbdac1de"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("17d3b982-a8c0-4e02-9437-64aa838c3a91"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1870620f-6da1-4e2e-b57e-ad4b3182187d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1a8a9ec5-f4f6-40ee-aa12-41ce5812c82b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1b4ab78f-8707-4736-82f1-5979a6b905ab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1ca41194-ba77-412f-bde5-b10febb74a0c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1d00cc6d-b32a-45fc-a600-8208993c2983"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1d758646-bb9a-4704-af3b-105b2670b5e3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1dd40953-2db0-4147-be0b-d128fd606b06"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("216132b2-6543-4fd8-a79a-877ab02c707e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("22ce660c-cddf-447f-adf3-280526e0a929"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2378c037-f183-4eed-89a6-b4fae7dfa34b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2505ebb8-b91e-493c-a72c-663d02c2a06a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("29492f0d-100b-4e8f-b573-f1b89cb5705c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("29af965a-4b77-4e3c-bb02-333dde5d594a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2a332a3f-97af-48c7-b9f8-d8ad22a80ed7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2c1dbc43-349c-477d-a57a-7da48b26d513"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2f959d0c-5874-447e-8a13-df3f400d15e7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("330d0687-31d5-463f-bb5b-9eb5553c30d7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("33655cb0-075a-406d-9038-2e36c5fc614a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("34e16036-df47-436a-9582-b2408f1de60d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("37a11158-df5d-4d6c-b9a6-d77714f407ce"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("391a45c2-b88b-4ffb-b557-dc78c6ca6f77"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3bf580ed-6374-450c-88ac-43a9dedf9e05"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3f85938f-a50f-46dc-96e8-981ea3dc0f54"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3f9cfe1b-63d5-46ff-99fa-653278affef2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("402fceba-141a-4818-92ae-5256b9f63a43"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("40d362a4-b41e-4c60-a28a-6d50dca2c648"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("40f667d6-3be1-49b1-bfa4-0075a77e4af7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("410f1c09-c069-4e78-aa7b-d227e80c5d27"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4347f40e-7428-4ef3-81ed-34224d67ac9f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("47168c14-a835-4c44-81ab-d8d06f38547b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("48df939b-1f1c-4310-b16c-6a873c4413e4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("497d73c5-42b7-45a6-be0c-07ac01c966a9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("49eeefaa-12a9-41a6-8f1c-8ca02baadaed"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4cfe5820-a76b-4e9d-b0d8-6b220fa0a867"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("50348e4f-86b8-48f0-bd9e-4bf0eaa95c75"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("51dce45e-142e-4026-a2b9-b06be315c32c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("523c4c78-5538-47cf-8de0-a7b2806a2919"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("548c9779-35cb-44cc-bee9-bbac18daf0c1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("557b921b-99e9-4e7e-aaed-5abf88fff07c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("57917eb1-a932-4959-bade-c37182aa193d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("581dec3a-dc5f-42e2-b9a3-b478e1f07cb4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5b057b86-775f-4dcf-beee-3faefe38f80e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5b8a5b81-f449-47af-893c-65491c98bc5d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5cf47afa-4876-4409-affb-b77a7685470b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5edc8dfa-2b7b-47d9-a5d6-b1b7ef3eb674"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("616f9560-1338-4033-a42f-9f572d7f11d4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("61b70dca-47ac-4ce7-8c7b-3f7bf898cf4b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("63e22a19-512b-4ca8-b29e-d603819ed893"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("642a7580-73ef-4479-abb4-57c579028a02"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("650fe856-365d-4733-9625-4a96a6cc748f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("657d337f-0f54-4e38-8d6b-1c700fd861aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6afa8c36-591c-4367-b735-2cd65f61f82a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6b68180a-3fd9-4452-86b7-35f26961d999"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6ccade8d-761c-4151-a044-18ba30685644"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6e15fb34-d4dd-4b6a-8deb-0f600a5a9a5f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6e18d196-ef51-4745-8de2-c83e8a473197"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("745ef231-96f4-4c5d-8fb6-ec503868ad42"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("74e7676f-fbdb-4b75-a3a1-382a6433d7d5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("795b5531-59f1-4ce3-92ff-f309446dd52b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7a72cd38-e443-4094-93e4-93878f6a69ad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7a8b3d0e-7723-4234-9c26-3f604cbc89e6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7be7ae3c-aaae-4ca1-81b2-b6a4370036da"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7d21802e-8fb9-4afc-8781-376f85c8a17d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7dd9daab-1ae4-48d5-bd75-7a96db38be0e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7e6ef7b8-bd68-49dd-b310-c1ea7dac78f9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7eaab899-081c-4f03-ad37-8d2cf06628bf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("81f00cdf-6121-4920-a629-3a5e949b4c44"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82cc681c-64fa-42db-be3d-2ef41e33a103"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8398cb98-16fd-4ecb-9d4a-b9cbb1468139"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("84e5c163-5a0f-4081-b544-28f56b3f95c2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8746b34c-ef58-4da4-b620-1306366225b2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8872d67f-d7a2-4be1-b4b7-88fed1929e14"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("88c9a3ce-758e-4ced-91dc-c7c45ab362f4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("89f94268-54ed-4f1e-841e-7b63a36c4ea8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8bcccab4-8167-4cda-958e-18b84f29ac5f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8cfe006a-1faa-4d26-bcf2-f74959921935"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8d03f8c6-47bc-4ba1-a750-8f20264ab546"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8eafbbe5-c84c-4c51-bb63-91a4c6f75a5b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8ff28c98-5791-4630-bbb0-a2aa33efe49c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9064f836-a4ac-4d15-8b2b-f4b7aecee6de"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("92924803-0f5b-4d42-8d7f-f896557b9d8e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("929be6c3-c791-4e8a-b50a-51837545ea41"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("939857af-e1a8-49bc-833f-49a29ac08924"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9598b493-b1d6-4b68-a23a-ae5e78ac81d0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("95dae17b-9fae-4766-962a-6f55a3ba247b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9715bc44-c10c-459c-a237-a692f84828e7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9790f0ee-9799-4bb8-b7f2-46eec9787e67"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("987408f4-256e-4422-9a0d-089e447b6959"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("99250a82-e8e5-423c-808d-5063bfbc72fe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9aae0855-dea4-4f77-aef6-d769c9c23978"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9b842dd8-d651-466f-b058-bb7b930392d9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9ed90c67-dad5-4724-af8a-a1b522b1e3bc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9f58213b-d5bc-4a3d-9e30-b277d08add10"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a116c4c6-4b9c-422e-a0ab-4c8e86d84346"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a191ca4f-b0ff-4f8d-8eb5-f166c31f9358"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a1e48e72-5fb0-46ca-9d6b-bedeceeb9bbf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a2fb6f20-66c9-4a57-9ef1-c2a237494688"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a393047b-2618-40e7-be69-dab984230c9a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a47439cf-d70e-4bfb-b016-5b0f74e1c1bb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a54ec868-df67-4a24-b938-d88f4601a238"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a78317f7-4c44-47c8-9164-708be69158b6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a7ea0ee9-a45e-4f8e-9679-5abe375e7b02"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a8a915c2-d445-4e37-9a1f-7573d4511f7a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ab39d3e1-59a9-4c6c-9b26-7e80b068a300"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ac108008-5249-478e-8ccb-e3bd53689831"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ad7f2d6e-0f03-4f75-b820-dc9f628267aa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("af47667b-447e-4703-825c-7d4717ff8b78"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b362c25b-10b4-4f0b-83e2-1c5927ef8a83"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b5615641-e6e6-4c1c-bb11-2dfa8dc554af"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b5ad63eb-193b-4d9c-b88c-ff007c06b576"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b60ca949-6f08-4c94-b1bd-412920c2f381"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b869924a-40b7-423e-843e-d2c2370f237d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b898d786-cc02-4ec9-bfa9-1f73e3ef60ce"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b9c6dbdd-acf0-4318-b71d-28321a1dd7be"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ba748caa-3dcb-48bf-b4f9-c4baab50029c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bac1cb2d-e9f1-4c96-aa43-095332a77cd7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bb1e6331-99b5-4701-a1c6-920590b5ec8b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bbe56efe-b640-40f2-9024-949afe421054"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bc1bf7a9-b3bd-4ed6-9456-ec337fdea6c5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bc3effba-6e11-4c79-893a-68ed2f7f7ce3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bd60f7ee-a5ab-4528-83c7-55624f6d4a09"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bed4f8ac-7dde-4c6f-9db1-011fad6478df"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bf13d4e0-81d4-495f-92be-65387158a73f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c2416f95-238d-4a98-8a51-748916c684c8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c781fb85-ec04-4380-ad19-08ebdff5da97"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cc2821a5-0b5c-4f1d-8498-7f6933cc9c17"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cc4b02e9-0f4a-4bb2-aec8-73b8e62e4b0f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cd57a0b6-e8eb-4a0a-a412-722e1c88860a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cd9f19ce-dc6a-4968-925f-8a96084aedde"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cf9ecf76-bdb2-45f0-815f-3b4b630e7a6b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d15039c7-c501-4259-8b45-8beba05b6da8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d38bacaf-59fd-49d5-95d7-1fb70c1327b9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d4d59c8b-7b74-46c1-a760-1b466a8d2593"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d6a1dcc4-4903-438b-b84d-c6ba511c52e0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d73f8794-a248-4567-bed5-75fe2247cf50"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d8f05240-4ccf-4089-8e1d-75d56bb16a02"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dcb020f3-8aa8-40f2-bd5e-0e4b5a875c67"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e35279a8-5fd6-4bcf-ac6a-bc6ce070d31a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e4c054ea-5a92-4812-adb2-42c201cf0a9e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e51ca2ac-f4d4-4929-8da4-d549ae09c0d6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e5539e0d-d714-4377-affd-ddaf859189ac"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e81bc8a6-b915-4dc6-ac44-83d5786a6fc7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e8ae2b10-e699-4532-8272-f31fe828120a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ea40fd31-499c-4a9c-9d6d-ac8f80a2935b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ebb1151a-8a9e-4a42-89fa-9f02b99c5c0e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ec3d8e49-a7c1-4917-b39e-ae29c3b40a10"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ecd6ec4b-615d-4c6a-92a8-2f6054e2a92b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ed2908b7-6af4-47cc-9072-c9cc02dd2c90"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ed3e4592-26e6-4290-8a18-45d18b14ac08"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ee2854fe-865d-47b0-8cbf-dde5058c4349"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ee83941e-b8dd-4d20-911c-3d19982174eb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f54df1d7-a337-4263-bf65-d9eba65f0ff9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f56fbbf4-9ed2-46e0-989d-9586e03062d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f588bebe-605f-49e3-93bf-1bc4fea1fc2d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f676138c-7996-4008-afee-54cb6fec59a9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f6f85376-502d-4488-83e2-7f6489b0699c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f7854417-2bde-4cb4-8bd1-b2a47500671e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f7dba0d9-d482-45af-abe5-fe979fc4a527"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f86e2835-84d5-40ea-984d-04c16f412092"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fa7d1b2f-6e62-4472-97c0-7951335064a4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fb9ba0d0-c878-449f-bca2-975346cce8b5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fd745fc4-6088-412e-b00b-936f62e5f9b6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fdf3c0c4-efa1-4d01-82f4-71ddef2988d3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0a0b942e-ebff-467f-9dc4-c1524ee2c454"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("135d117e-61ee-45cb-a8c6-aea407235de4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2c3526d3-0f0a-4535-a302-488fd6a54642"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("53945520-2350-44ea-9afd-19650fd6d170"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5813169c-a082-44a5-9bdd-fd5d988b90e5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6565ac9a-9b2c-4779-9094-0ef6c84154d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("78ee35df-3a58-427f-bc69-3f2bbeb4b875"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("83be8afa-3acc-40a1-9952-5aaafa8e7122"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("af175771-bea8-40ca-b1b2-522845014f12"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b0c84a7c-f6c2-44de-8e75-4615abb5cba5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b33ddbb9-5928-4eb1-9794-766eaeb9b57e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ba86034a-9f5f-41d2-935e-2c8e004ee42a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e7380f21-3d11-449a-964e-8469658a0588"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("fe855240-a338-448e-ac7c-f59448b000ff"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("1af4beee-39d1-473a-aed5-a00889a24175"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("38542a6b-c195-453f-9e75-d393ef12938f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("5b7046a3-ddb0-48e0-b99a-5068f350cf48"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("61f9ac97-9f36-4baf-9c5f-e7abedd69e95"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("89f8da98-0c4d-41a6-ac86-06f558d6460b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("0a643d21-dafc-4112-9246-2190dc9417c6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("181630bf-f476-43a4-b4ca-864bf3a6ab27"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("205e1fe5-e491-42a3-9397-cf661fd4d16e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("34997bdf-d67c-44c8-92fb-338804d58e0e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("456a45a8-93a6-4f5c-9786-d9f72e8d8309"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("527cc63a-e9cc-410f-b3cc-c6fd6a3a324c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("5e8244cd-22d3-4454-9dd7-089e89437640"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("6982a435-366a-4835-a767-93723a9a9e20"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("71a7e610-eb00-4f55-88e7-f75152d66913"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("8d8829b0-7557-4a5a-bbda-f25e26d5e120"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("9383aa4e-7fd6-4273-9d8d-82c75599e1f8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("947d0db9-8300-49be-9cf6-8e7e01b4caca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("a2418b4a-219e-49ab-91ae-16ce26596dc5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("a2fa6674-2e01-4849-b22f-d7856880a596"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("b1197b84-b0ee-47bf-bfcd-afede2fd9ef2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("bc249f18-53b0-4c6e-92bc-3db41bdd6e23"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("bfe1d884-52a0-452c-b45d-9670682f9635"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("c87954a1-21b2-478e-941c-ef5b2bf50cab"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d1d2c602-cb27-4e8c-82ad-8519deba46cf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d3b1879b-f672-4b16-a203-2e48d3f1a853"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("d4764355-6777-4872-bcad-df58f643f90e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("db401cc4-e2ff-4f72-ab21-0392832ca795"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("f8bc2328-0d33-49da-bef5-6847154e1fbf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("037385e0-36ca-4f9c-9b9e-06b50776c5d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("060e7588-0162-490d-bdda-04a0fd7f87d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("2748323b-4f11-4d3c-a6a3-e427df5fc366"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("6cd72244-0105-47a1-8eb4-a1ec8f4f3f14"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("8ab5ed73-2800-4d23-8de9-4d815d332c4a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("12fa7566-f440-46f3-9e01-57e35cdbbd09"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("1e076eeb-ac63-4316-8664-77be6aab7ed8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("282fe355-c9a6-45a8-bdcb-d1a3efb936ca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2e0462ee-3a9d-4d32-bf9d-7e51c4de6d88"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("36e4fb39-9f35-4a59-b1ad-e0fa767b5107"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("41f49fcb-2e57-4c1c-9cdd-80b360df6333"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("858c26eb-8b07-4e40-a1f8-73ff18053950"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9a2e941a-dfed-41ae-be5e-3ec7ea117c43"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("a714c603-b0ef-40f1-88f0-0927b181d4a4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c22d4524-6d0c-400f-b636-1342238e3cc7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("d428d1e1-3fa7-47c6-af52-a1a211931552"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("d77f884b-c421-4f43-9921-b280ca808800"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("deee4929-da2f-4619-bf5f-7ac212fe6d3a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e4265d46-a5ce-4b9f-88b6-221139659e4a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e6e7b1a3-858d-488d-aee4-7d13231f4d5a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"));

            migrationBuilder.DropColumn(
                name: "BusinessDescription",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                schema: "sp",
                table: "SP_ServiceProviderEntity");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.AddColumn<string>(
                name: "BusinessDescription",
                schema: "sp",
                table: "SP_ServiceListing",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                schema: "sp",
                table: "SP_ServiceListing",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_Service",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SP_ServiceListingsServices",
                schema: "sp",
                columns: table => new
                {
                    ServiceListingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_ServiceListingsServices", x => new { x.ServiceListingId, x.ServiceId });
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SP_Service_SP_ServiceListing_ServiceListingId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.DropTable(
                name: "SP_ServiceListingsServices",
                schema: "sp");

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
                name: "BusinessDescription",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DropColumn(
                name: "BusinessName",
                schema: "sp",
                table: "SP_ServiceListing");

            migrationBuilder.DropColumn(
                name: "ServiceListingId",
                schema: "sp",
                table: "SP_Service");

            migrationBuilder.AddColumn<string>(
                name: "BusinessDescription",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BusinessName",
                schema: "sp",
                table: "SP_ServiceProviderEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Category",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("01040697-0db1-4909-80d1-d89a163de7db"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7117), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7117), "Web & IT Support Services", "" },
                    { new Guid("037385e0-36ca-4f9c-9b9e-06b50776c5d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7110), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7109), "Catering & Event Services", "" },
                    { new Guid("060e7588-0162-490d-bdda-04a0fd7f87d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7106), "Jua Kali & General Repairs", "" },
                    { new Guid("2748323b-4f11-4d3c-a6a3-e427df5fc366"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7102), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7101), "Cleaning & Housekeeping", "" },
                    { new Guid("6cd72244-0105-47a1-8eb4-a1ec8f4f3f14"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7116), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7115), "Beauty, SPA & Personal Care Services", "" },
                    { new Guid("8ab5ed73-2800-4d23-8de9-4d815d332c4a"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7108), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7108), "Ride Hailing & Delivery Services", "" },
                    { new Guid("ae10ddb9-5029-48a6-83fe-7e098ad07e5a"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7114), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7113), "Fitness & Wellness Services", "" },
                    { new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7119), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7119), "Professional & Digital Services", "" },
                    { new Guid("e768b07a-d356-4893-9a6d-7bb718656631"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7112), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7111), "Tutoring & Educational Services", "" },
                    { new Guid("fdcc9027-5ebd-4cb9-b62d-3356dd26744e"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7104), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7103), "Landscaping & Gardening", "" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_County",
                columns: new[] { "Id", "CountyName", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("0a0b942e-ebff-467f-9dc4-c1524ee2c454"), "KAJIADO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), "MERU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("12fa7566-f440-46f3-9e01-57e35cdbbd09"), "NYANDARUA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("135d117e-61ee-45cb-a8c6-aea407235de4"), "VIHIGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1e076eeb-ac63-4316-8664-77be6aab7ed8"), "KIRINYAGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), "GARISSA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("282fe355-c9a6-45a8-bdcb-d1a3efb936ca"), "ELGEYO/MARAKWET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c3526d3-0f0a-4535-a302-488fd6a54642"), "NYAMIRA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2e0462ee-3a9d-4d32-bf9d-7e51c4de6d88"), "EMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36e4fb39-9f35-4a59-b1ad-e0fa767b5107"), "ISIOLO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), "TURKANA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("41f49fcb-2e57-4c1c-9cdd-80b360df6333"), "WEST POKOT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("53945520-2350-44ea-9afd-19650fd6d170"), "KISII", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5813169c-a082-44a5-9bdd-fd5d988b90e5"), "NAROK", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), "NANDI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6565ac9a-9b2c-4779-9094-0ef6c84154d8"), "SIAYA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), "NAIROBI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), "KIAMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("78ee35df-3a58-427f-bc69-3f2bbeb4b875"), "BUSIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("83be8afa-3acc-40a1-9952-5aaafa8e7122"), "MIGORI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("858c26eb-8b07-4e40-a1f8-73ff18053950"), "MARSABIT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), "MURANG'A", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), "WAJIR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"), "BARINGO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), "NAKURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9a2e941a-dfed-41ae-be5e-3ec7ea117c43"), "LAMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), "KITUI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a714c603-b0ef-40f1-88f0-0927b181d4a4"), "SAMBURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("af175771-bea8-40ca-b1b2-522845014f12"), "KISUMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b0c84a7c-f6c2-44de-8e75-4615abb5cba5"), "BOMET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b33ddbb9-5928-4eb1-9794-766eaeb9b57e"), "KAKAMEGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), "MANDERA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ba86034a-9f5f-41d2-935e-2c8e004ee42a"), "BUNGOMA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), "MAKUENI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c22d4524-6d0c-400f-b636-1342238e3cc7"), "TANA RIVER", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), "MACHAKOS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d428d1e1-3fa7-47c6-af52-a1a211931552"), "KWALE", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d77f884b-c421-4f43-9921-b280ca808800"), "KILIFI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"), "TRANS NZOIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), "MOMBASA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("deee4929-da2f-4619-bf5f-7ac212fe6d3a"), "TAITA TAVETA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), "UASIN GISHU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e4265d46-a5ce-4b9f-88b6-221139659e4a"), "LAIKIPIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e6e7b1a3-858d-488d-aee4-7d13231f4d5a"), "THARAKA-NITHI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e7380f21-3d11-449a-964e-8469658a0588"), "HOMA BAY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), "NYERI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fe855240-a338-448e-ac7c-f59448b000ff"), "KERICHO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Location",
                columns: new[] { "Id", "ConstituencyId", "DateCreated", "DateModified", "LocationName" },
                values: new object[,]
                {
                    { new Guid("1af4beee-39d1-473a-aed5-a00889a24175"), new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ruai" },
                    { new Guid("38542a6b-c195-453f-9e75-d393ef12938f"), new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Claycity" },
                    { new Guid("5b7046a3-ddb0-48e0-b99a-5068f350cf48"), new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mwiki" },
                    { new Guid("61f9ac97-9f36-4baf-9c5f-e7abedd69e95"), new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Njiru" },
                    { new Guid("89f8da98-0c4d-41a6-ac86-06f558d6460b"), new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kasarani" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Constituency",
                columns: new[] { "Id", "ConstituencyName", "CountyId", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("02327ba2-4a8b-40c5-9dec-6eebcc0c8702"), "Kesses", new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("02faf3fa-f8ff-4805-a5a5-bbec1a0f0334"), "Wajir East", new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0310c9c1-38a1-4068-9f76-e9b40702fb0a"), "Ol Jorok", new Guid("12fa7566-f440-46f3-9e01-57e35cdbbd09"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("04769e65-5d23-4f20-b9c8-e77b11dc5231"), "Makueni", new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("05b8f669-3b88-44e4-850f-3a34b4757a08"), "Sigor", new Guid("41f49fcb-2e57-4c1c-9cdd-80b360df6333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("076d6e5c-a4a8-459f-b758-302b9383572a"), "Igembe South", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0781a632-7bb3-4715-ae14-9051c0e38cd1"), "Kwanza", new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("07d9931f-6f39-41bb-b3a0-f63ce33d815c"), "Langata", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("08949e8d-02aa-4f6c-b572-4427f7486b34"), "Kiambaa", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0a0c20ad-694f-4be2-b2e4-60ed00a2581d"), "Ndaragwa", new Guid("12fa7566-f440-46f3-9e01-57e35cdbbd09"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0b44bf11-b59a-4897-9717-f2b77f1748ca"), "Laikipia West", new Guid("e4265d46-a5ce-4b9f-88b6-221139659e4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0b5ca4ec-97c6-42fe-ad5a-475708930bbd"), "Kabete", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0d840707-03d1-4caa-82ff-02f0d2bcfb16"), "Tinderet", new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0e081d23-bd28-470d-9e40-f3241ca017b7"), "Jomvu", new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0e411a56-523c-472a-a1c9-2f3cc69da4d4"), "Chuka/Igambang'ombe", new Guid("e6e7b1a3-858d-488d-aee4-7d13231f4d5a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0e9a1894-a5cd-46e7-9dd7-f9a52c51a2bc"), "Kigumo", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("118c286c-2f25-4d86-86ae-098e3120c816"), "Mandera West", new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1313ffc4-734c-4309-8bef-0da7a7424ed6"), "Turkana South", new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("13e44a40-0e9d-479f-8ee9-93db4a825c29"), "Tharaka", new Guid("e6e7b1a3-858d-488d-aee4-7d13231f4d5a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("14c93f1c-5ac7-47ca-b37d-3940cbdac1de"), "Msambweni", new Guid("d428d1e1-3fa7-47c6-af52-a1a211931552"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("17d3b982-a8c0-4e02-9437-64aa838c3a91"), "Mwingi North", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1870620f-6da1-4e2e-b57e-ad4b3182187d"), "Wajir South", new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1a8a9ec5-f4f6-40ee-aa12-41ce5812c82b"), "Eldas", new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1b4ab78f-8707-4736-82f1-5979a6b905ab"), "Mbeere North", new Guid("2e0462ee-3a9d-4d32-bf9d-7e51c4de6d88"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1ca41194-ba77-412f-bde5-b10febb74a0c"), "Marakwet East", new Guid("282fe355-c9a6-45a8-bdcb-d1a3efb936ca"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1d00cc6d-b32a-45fc-a600-8208993c2983"), "Kitui East", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1d758646-bb9a-4704-af3b-105b2670b5e3"), "Lagdera", new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1dd40953-2db0-4147-be0b-d128fd606b06"), "Embakasi East", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("216132b2-6543-4fd8-a79a-877ab02c707e"), "Wajir West", new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22ce660c-cddf-447f-adf3-280526e0a929"), "Mathira", new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2378c037-f183-4eed-89a6-b4fae7dfa34b"), "Nyeri Town", new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2505ebb8-b91e-493c-a72c-663d02c2a06a"), "Nyali", new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29492f0d-100b-4e8f-b573-f1b89cb5705c"), "Lari", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29af965a-4b77-4e3c-bb02-333dde5d594a"), "Lamu West", new Guid("9a2e941a-dfed-41ae-be5e-3ec7ea117c43"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2a332a3f-97af-48c7-b9f8-d8ad22a80ed7"), "Kibra", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c1dbc43-349c-477d-a57a-7da48b26d513"), "Westlands", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2f959d0c-5874-447e-8a13-df3f400d15e7"), "Isiolo South", new Guid("36e4fb39-9f35-4a59-b1ad-e0fa767b5107"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("330d0687-31d5-463f-bb5b-9eb5553c30d7"), "Voi", new Guid("deee4929-da2f-4619-bf5f-7ac212fe6d3a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33655cb0-075a-406d-9038-2e36c5fc614a"), "Kibwezi East", new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("34e16036-df47-436a-9582-b2408f1de60d"), "Masinga", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("37a11158-df5d-4d6c-b9a6-d77714f407ce"), "Baringo Central", new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("391a45c2-b88b-4ffb-b557-dc78c6ca6f77"), "Maara", new Guid("e6e7b1a3-858d-488d-aee4-7d13231f4d5a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3bf580ed-6374-450c-88ac-43a9dedf9e05"), "Mvita", new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3f85938f-a50f-46dc-96e8-981ea3dc0f54"), "Mwea", new Guid("1e076eeb-ac63-4316-8664-77be6aab7ed8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3f9cfe1b-63d5-46ff-99fa-653278affef2"), "Kuresoi South", new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("402fceba-141a-4818-92ae-5256b9f63a43"), "Turkana Central", new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40d362a4-b41e-4c60-a28a-6d50dca2c648"), "Kirinyaga Central", new Guid("1e076eeb-ac63-4316-8664-77be6aab7ed8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("40f667d6-3be1-49b1-bfa4-0075a77e4af7"), "Kisauni", new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("410f1c09-c069-4e78-aa7b-d227e80c5d27"), "Marakwet West", new Guid("282fe355-c9a6-45a8-bdcb-d1a3efb936ca"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4347f40e-7428-4ef3-81ed-34224d67ac9f"), "Saku", new Guid("858c26eb-8b07-4e40-a1f8-73ff18053950"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("47168c14-a835-4c44-81ab-d8d06f38547b"), "Mavoko", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("48df939b-1f1c-4310-b16c-6a873c4413e4"), "Mbeere South", new Guid("2e0462ee-3a9d-4d32-bf9d-7e51c4de6d88"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("497d73c5-42b7-45a6-be0c-07ac01c966a9"), "Magarini", new Guid("d77f884b-c421-4f43-9921-b280ca808800"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("49eeefaa-12a9-41a6-8f1c-8ca02baadaed"), "Turkana West", new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4cfe5820-a76b-4e9d-b0d8-6b220fa0a867"), "Wundanyi", new Guid("deee4929-da2f-4619-bf5f-7ac212fe6d3a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4fb3524e-bc83-41ec-8c1e-a94f0963464c"), "Kasarani", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50348e4f-86b8-48f0-bd9e-4bf0eaa95c75"), "Ruaraka", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("51dce45e-142e-4026-a2b9-b06be315c32c"), "Lungalunga", new Guid("d428d1e1-3fa7-47c6-af52-a1a211931552"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("523c4c78-5538-47cf-8de0-a7b2806a2919"), "Njoro", new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("548c9779-35cb-44cc-bee9-bbac18daf0c1"), "Embakasi Central", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("557b921b-99e9-4e7e-aaed-5abf88fff07c"), "Tigania East", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("57917eb1-a932-4959-bade-c37182aa193d"), "Soy", new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("581dec3a-dc5f-42e2-b9a3-b478e1f07cb4"), "Mandera East", new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b057b86-775f-4dcf-beee-3faefe38f80e"), "Gatanga", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b8a5b81-f449-47af-893c-65491c98bc5d"), "Tigania West", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5cf47afa-4876-4409-affb-b77a7685470b"), "Mogotio", new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5edc8dfa-2b7b-47d9-a5d6-b1b7ef3eb674"), "Samburu West", new Guid("a714c603-b0ef-40f1-88f0-0927b181d4a4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("616f9560-1338-4033-a42f-9f572d7f11d4"), "Gilgil", new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("61b70dca-47ac-4ce7-8c7b-3f7bf898cf4b"), "Baringo South", new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("63e22a19-512b-4ca8-b29e-d603819ed893"), "Kibwezi West", new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("642a7580-73ef-4479-abb4-57c579028a02"), "Central Imenti", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("650fe856-365d-4733-9625-4a96a6cc748f"), "Changamwe", new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("657d337f-0f54-4e38-8d6b-1c700fd861aa"), "Malindi", new Guid("d77f884b-c421-4f43-9921-b280ca808800"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6afa8c36-591c-4367-b735-2cd65f61f82a"), "Laikipia East", new Guid("e4265d46-a5ce-4b9f-88b6-221139659e4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6b68180a-3fd9-4452-86b7-35f26961d999"), "Taveta", new Guid("deee4929-da2f-4619-bf5f-7ac212fe6d3a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ccade8d-761c-4151-a044-18ba30685644"), "Wajir North", new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6e15fb34-d4dd-4b6a-8deb-0f600a5a9a5f"), "Mathioya", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6e18d196-ef51-4745-8de2-c83e8a473197"), "Machakos Town", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("745ef231-96f4-4c5d-8fb6-ec503868ad42"), "Mwatate", new Guid("deee4929-da2f-4619-bf5f-7ac212fe6d3a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("74e7676f-fbdb-4b75-a3a1-382a6433d7d5"), "Kitui West", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("795b5531-59f1-4ce3-92ff-f309446dd52b"), "Ndia", new Guid("1e076eeb-ac63-4316-8664-77be6aab7ed8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a72cd38-e443-4094-93e4-93878f6a69ad"), "Gatundu North", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7a8b3d0e-7723-4234-9c26-3f604cbc89e6"), "Dagoretti North", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7be7ae3c-aaae-4ca1-81b2-b6a4370036da"), "Kathiani", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7d21802e-8fb9-4afc-8781-376f85c8a17d"), "Buuri", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7dd9daab-1ae4-48d5-bd75-7a96db38be0e"), "Juja", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7e6ef7b8-bd68-49dd-b310-c1ea7dac78f9"), "Manyatta", new Guid("2e0462ee-3a9d-4d32-bf9d-7e51c4de6d88"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7eaab899-081c-4f03-ad37-8d2cf06628bf"), "Kangema", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("81f00cdf-6121-4920-a629-3a5e949b4c44"), "Matungulu", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82cc681c-64fa-42db-be3d-2ef41e33a103"), "Embakasi South", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8398cb98-16fd-4ecb-9d4a-b9cbb1468139"), "Kiambu", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("84e5c163-5a0f-4081-b544-28f56b3f95c2"), "Kacheliba", new Guid("41f49fcb-2e57-4c1c-9cdd-80b360df6333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8746b34c-ef58-4da4-b620-1306366225b2"), "Kitui Rural", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8872d67f-d7a2-4be1-b4b7-88fed1929e14"), "Limuru", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("88c9a3ce-758e-4ced-91dc-c7c45ab362f4"), "Laikipia North", new Guid("e4265d46-a5ce-4b9f-88b6-221139659e4a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("89f94268-54ed-4f1e-841e-7b63a36c4ea8"), "Ruiru", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8bcccab4-8167-4cda-958e-18b84f29ac5f"), "Dagoretti South", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8cfe006a-1faa-4d26-bcf2-f74959921935"), "Igembe North", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8d03f8c6-47bc-4ba1-a750-8f20264ab546"), "Kangundo", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8eafbbe5-c84c-4c51-bb63-91a4c6f75a5b"), "Mandera South", new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8ff28c98-5791-4630-bbb0-a2aa33efe49c"), "Isiolo North", new Guid("36e4fb39-9f35-4a59-b1ad-e0fa767b5107"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9064f836-a4ac-4d15-8b2b-f4b7aecee6de"), "Kuresoi North", new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("92924803-0f5b-4d42-8d7f-f896557b9d8e"), "Lamu East", new Guid("9a2e941a-dfed-41ae-be5e-3ec7ea117c43"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("929be6c3-c791-4e8a-b50a-51837545ea41"), "Nandi Hills", new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("939857af-e1a8-49bc-833f-49a29ac08924"), "Yatta", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9598b493-b1d6-4b68-a23a-ae5e78ac81d0"), "Kitui Central", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("95dae17b-9fae-4766-962a-6f55a3ba247b"), "Emgwen", new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9715bc44-c10c-459c-a237-a692f84828e7"), "Starehe", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9790f0ee-9799-4bb8-b7f2-46eec9787e67"), "South Imenti", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("987408f4-256e-4422-9a0d-089e447b6959"), "Igembe Central", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("99250a82-e8e5-423c-808d-5063bfbc72fe"), "Maragwa", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9aae0855-dea4-4f77-aef6-d769c9c23978"), "Bura", new Guid("c22d4524-6d0c-400f-b636-1342238e3cc7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9b842dd8-d651-466f-b058-bb7b930392d9"), "Loima", new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ed90c67-dad5-4724-af8a-a1b522b1e3bc"), "Mukurweini", new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9f58213b-d5bc-4a3d-9e30-b277d08add10"), "Kinango", new Guid("d428d1e1-3fa7-47c6-af52-a1a211931552"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a116c4c6-4b9c-422e-a0ab-4c8e86d84346"), "Ijara", new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a191ca4f-b0ff-4f8d-8eb5-f166c31f9358"), "Rabai", new Guid("d77f884b-c421-4f43-9921-b280ca808800"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a1e48e72-5fb0-46ca-9d6b-bedeceeb9bbf"), "Thika Town", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a2fb6f20-66c9-4a57-9ef1-c2a237494688"), "Turkana North", new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a393047b-2618-40e7-be69-dab984230c9a"), "Samburu East", new Guid("a714c603-b0ef-40f1-88f0-0927b181d4a4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a47439cf-d70e-4bfb-b016-5b0f74e1c1bb"), "Baringo North", new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a54ec868-df67-4a24-b938-d88f4601a238"), "Othaya", new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a78317f7-4c44-47c8-9164-708be69158b6"), "Mandera North", new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a7ea0ee9-a45e-4f8e-9679-5abe375e7b02"), "Turkana East", new Guid("3c534d3d-dd82-4b8d-bba6-0d2ef4cbe6e1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a8a915c2-d445-4e37-9a1f-7573d4511f7a"), "Kitui South", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ab39d3e1-59a9-4c6c-9b26-7e80b068a300"), "Roysambu", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac108008-5249-478e-8ccb-e3bd53689831"), "Cherangany", new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ad7f2d6e-0f03-4f75-b820-dc9f628267aa"), "North Imenti", new Guid("0fa98dd4-8fb7-49ad-91c5-8245d745bf39"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("af47667b-447e-4703-825c-7d4717ff8b78"), "Ganze", new Guid("d77f884b-c421-4f43-9921-b280ca808800"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b362c25b-10b4-4f0b-83e2-1c5927ef8a83"), "Mwala", new Guid("c8552937-daef-4c4d-b8de-f2e2bffd206b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b5615641-e6e6-4c1c-bb11-2dfa8dc554af"), "Fafi", new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b5ad63eb-193b-4d9c-b88c-ff007c06b576"), "Moiben", new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b60ca949-6f08-4c94-b1bd-412920c2f381"), "Matuga", new Guid("d428d1e1-3fa7-47c6-af52-a1a211931552"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b869924a-40b7-423e-843e-d2c2370f237d"), "Aldai", new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b898d786-cc02-4ec9-bfa9-1f73e3ef60ce"), "Tetu", new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b9c6dbdd-acf0-4318-b71d-28321a1dd7be"), "Keiyo North", new Guid("282fe355-c9a6-45a8-bdcb-d1a3efb936ca"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ba748caa-3dcb-48bf-b4f9-c4baab50029c"), "Saboti", new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bac1cb2d-e9f1-4c96-aa43-095332a77cd7"), "Kieni", new Guid("e7e528f3-1f4a-4847-98ff-6093cae531c7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bb1e6331-99b5-4701-a1c6-920590b5ec8b"), "Samburu North", new Guid("a714c603-b0ef-40f1-88f0-0927b181d4a4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bbe56efe-b640-40f2-9024-949afe421054"), "Githunguri", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc1bf7a9-b3bd-4ed6-9456-ec337fdea6c5"), "Chesumei", new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc3effba-6e11-4c79-893a-68ed2f7f7ce3"), "Balambala", new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bd60f7ee-a5ab-4528-83c7-55624f6d4a09"), "Moyale", new Guid("858c26eb-8b07-4e40-a1f8-73ff18053950"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bed4f8ac-7dde-4c6f-9db1-011fad6478df"), "Naivasha", new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bf13d4e0-81d4-495f-92be-65387158a73f"), "Daadab", new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c2416f95-238d-4a98-8a51-748916c684c8"), "Kiharu", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c781fb85-ec04-4380-ad19-08ebdff5da97"), "Runyenjes", new Guid("2e0462ee-3a9d-4d32-bf9d-7e51c4de6d88"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cc2821a5-0b5c-4f1d-8498-7f6933cc9c17"), "Kikuyu", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cc4b02e9-0f4a-4bb2-aec8-73b8e62e4b0f"), "Eldama Ravine", new Guid("8faf11f2-c2c0-4518-a3cd-e6c71b4707c6"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd57a0b6-e8eb-4a0a-a412-722e1c88860a"), "Mwingi West", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cd9f19ce-dc6a-4968-925f-8a96084aedde"), "Likoni", new Guid("ded61282-eba1-4efe-85b3-0bfe271c62d9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cf9ecf76-bdb2-45f0-815f-3b4b630e7a6b"), "Gichugu", new Guid("1e076eeb-ac63-4316-8664-77be6aab7ed8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d15039c7-c501-4259-8b45-8beba05b6da8"), "Gatundu South", new Guid("7763b3d0-f3ee-4469-8932-1cd78a3af57b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d38bacaf-59fd-49d5-95d7-1fb70c1327b9"), "Galole", new Guid("c22d4524-6d0c-400f-b636-1342238e3cc7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d4d59c8b-7b74-46c1-a760-1b466a8d2593"), "Lafey", new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d6a1dcc4-4903-438b-b84d-c6ba511c52e0"), "Keiyo South", new Guid("282fe355-c9a6-45a8-bdcb-d1a3efb936ca"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d73f8794-a248-4567-bed5-75fe2247cf50"), "Kamukunji", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d8f05240-4ccf-4089-8e1d-75d56bb16a02"), "Makadara", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dcb020f3-8aa8-40f2-bd5e-0e4b5a875c67"), "Pokot South", new Guid("41f49fcb-2e57-4c1c-9cdd-80b360df6333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e35279a8-5fd6-4bcf-ac6a-bc6ce070d31a"), "Kaiti", new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e4c054ea-5a92-4812-adb2-42c201cf0a9e"), "Kapenguria", new Guid("41f49fcb-2e57-4c1c-9cdd-80b360df6333"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e51ca2ac-f4d4-4929-8da4-d549ae09c0d6"), "Kapseret", new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e5539e0d-d714-4377-affd-ddaf859189ac"), "Ol Kalou", new Guid("12fa7566-f440-46f3-9e01-57e35cdbbd09"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e81bc8a6-b915-4dc6-ac44-83d5786a6fc7"), "Tarbaj", new Guid("8f711c32-a1a7-48ae-b1ae-a4b169d6280c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e8ae2b10-e699-4532-8272-f31fe828120a"), "Banissa", new Guid("ba5051cb-b350-4aa0-9010-801a5cb6f741"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ea40fd31-499c-4a9c-9d6d-ac8f80a2935b"), "Molo", new Guid("90da250b-04c8-43ed-a24c-0b1c3ce64cf2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ebb1151a-8a9e-4a42-89fa-9f02b99c5c0e"), "Mathare", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ec3d8e49-a7c1-4917-b39e-ae29c3b40a10"), "Embakasi West", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ecd6ec4b-615d-4c6a-92a8-2f6054e2a92b"), "Laisamis", new Guid("858c26eb-8b07-4e40-a1f8-73ff18053950"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ed2908b7-6af4-47cc-9072-c9cc02dd2c90"), "Kipipiri", new Guid("12fa7566-f440-46f3-9e01-57e35cdbbd09"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ed3e4592-26e6-4290-8a18-45d18b14ac08"), "North Horr", new Guid("858c26eb-8b07-4e40-a1f8-73ff18053950"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee2854fe-865d-47b0-8cbf-dde5058c4349"), "Mosop", new Guid("648a289f-57d2-476b-8f9f-b2d3f340b980"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee83941e-b8dd-4d20-911c-3d19982174eb"), "Kilifi South", new Guid("d77f884b-c421-4f43-9921-b280ca808800"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f54df1d7-a337-4263-bf65-d9eba65f0ff9"), "Garissa Township", new Guid("273180a1-15bd-4159-8bf7-fd63edf67105"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f56fbbf4-9ed2-46e0-989d-9586e03062d8"), "Kiminini", new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f588bebe-605f-49e3-93bf-1bc4fea1fc2d"), "Endebess", new Guid("de82b891-4855-4f23-91a3-214ef9cfddb4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f676138c-7996-4008-afee-54cb6fec59a9"), "Ainabkoi", new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f6f85376-502d-4488-83e2-7f6489b0699c"), "Turbo", new Guid("e1bfa078-e5bf-4539-ad79-b20db5cffa99"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f7854417-2bde-4cb4-8bd1-b2a47500671e"), "Mbooni", new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f7dba0d9-d482-45af-abe5-fe979fc4a527"), "Kilome", new Guid("bde56fb3-8b7f-4646-a2a9-7a9443a52809"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f86e2835-84d5-40ea-984d-04c16f412092"), "Kilifi North", new Guid("d77f884b-c421-4f43-9921-b280ca808800"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fa7d1b2f-6e62-4472-97c0-7951335064a4"), "Kandara", new Guid("8b2cf94b-87b1-49b6-9d0a-35c50b5f48ba"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fb9ba0d0-c878-449f-bca2-975346cce8b5"), "Embakasi North", new Guid("6ea10cce-bbe7-428d-9ee6-e6aaf21c9c62"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd745fc4-6088-412e-b00b-936f62e5f9b6"), "Garsen", new Guid("c22d4524-6d0c-400f-b636-1342238e3cc7"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fdf3c0c4-efa1-4d01-82f4-71ddef2988d3"), "Mwingi Central", new Guid("a51eddeb-fb52-4371-a870-c2f1f48f88ed"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Service",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Description", "Name", "ServiceProviderEntityId" },
                values: new object[,]
                {
                    { new Guid("0a643d21-dafc-4112-9246-2190dc9417c6"), new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7229), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7229), "Comprehensive digital marketing solutions including SEO, social media management, and online advertising to boost your online presence.", "Digital Marketing Services", null },
                    { new Guid("181630bf-f476-43a4-b4ca-864bf3a6ab27"), new Guid("8ab5ed73-2800-4d23-8de9-4d815d332c4a"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7214), "Reliable parcel delivery services offering door-to-door delivery within the city, ensuring timely and secure transport of packages.", "Parcel Delivery (door-to-door, within city)", null },
                    { new Guid("205e1fe5-e491-42a3-9397-cf661fd4d16e"), new Guid("2748323b-4f11-4d3c-a6a3-e427df5fc366"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7182), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7183), "Comprehensive home cleaning services including dusting, vacuuming, mopping, and sanitizing all rooms.", "Home Cleaning", null },
                    { new Guid("34997bdf-d67c-44c8-92fb-338804d58e0e"), new Guid("6cd72244-0105-47a1-8eb4-a1ec8f4f3f14"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7259), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7259), "Comprehensive fitness and wellness services including personal training, yoga & gym classes, and nutrition counseling to help you achieve your health goals.", "Fitness & Wellness Services", null },
                    { new Guid("456a45a8-93a6-4f5c-9786-d9f72e8d8309"), new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7234), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7235), "Professional web development services to create responsive, user-friendly websites tailored to your business needs.", "Web Development", null },
                    { new Guid("527cc63a-e9cc-410f-b3cc-c6fd6a3a324c"), new Guid("060e7588-0162-490d-bdda-04a0fd7f87d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7203), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7203), "Expert plumbing services including leak repairs, fixture installations, and maintenance for residential and commercial properties.", "Plumbing (leak fixes, installations)", null },
                    { new Guid("5e8244cd-22d3-4454-9dd7-089e89437640"), new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7239), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7240), "Expert social media management services to enhance your brand's online presence and engage with your audience effectively.", "Social Media Management (SMM)", null },
                    { new Guid("6982a435-366a-4835-a767-93723a9a9e20"), new Guid("8ab5ed73-2800-4d23-8de9-4d815d332c4a"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7216), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7217), "Efficient food delivery services partnering with local restaurants to bring meals directly to customers' doorsteps.", "Food Delivery", null },
                    { new Guid("71a7e610-eb00-4f55-88e7-f75152d66913"), new Guid("2748323b-4f11-4d3c-a6a3-e427df5fc366"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7185), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7186), "Professional office cleaning services tailored to maintain a clean and productive work environment.", "Office Cleaning", null },
                    { new Guid("8d8829b0-7557-4a5a-bbda-f25e26d5e120"), new Guid("037385e0-36ca-4f9c-9b9e-06b50776c5d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7251), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7251), "Professional decorator services for parties and functions, providing creative setups and themes to enhance the event atmosphere.", "Decorator Services (party, function setup)", null },
                    { new Guid("9383aa4e-7fd6-4273-9d8d-82c75599e1f8"), new Guid("6cd72244-0105-47a1-8eb4-a1ec8f4f3f14"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7256), "Professional beauty and spa services including facials, manicure, hairdressing, massages, and skincare treatments to promote relaxation and wellness.", "Beauty & Spa Services", null },
                    { new Guid("947d0db9-8300-49be-9cf6-8e7e01b4caca"), new Guid("037385e0-36ca-4f9c-9b9e-06b50776c5d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7248), "Expert photography and videography services capturing memorable moments at events and creating stunning portraits for individuals and families.", "Photography & Videography (events, portraits)", null },
                    { new Guid("a2418b4a-219e-49ab-91ae-16ce26596dc5"), new Guid("060e7588-0162-490d-bdda-04a0fd7f87d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7211), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7211), "Expert painting and decorating services for interior and exterior spaces, enhancing the aesthetic appeal of homes and businesses.", "Painting & Decorating", null },
                    { new Guid("a2fa6674-2e01-4849-b22f-d7856880a596"), new Guid("037385e0-36ca-4f9c-9b9e-06b50776c5d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7242), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7243), "Professional event catering services for weddings, corporate events, and special occasions, offering customized menus and exceptional service.", "Event Catering (weddings, corporate)", null },
                    { new Guid("b1197b84-b0ee-47bf-bfcd-afede2fd9ef2"), new Guid("2748323b-4f11-4d3c-a6a3-e427df5fc366"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7200), "Professional window cleaning services for residential and commercial properties, ensuring streak-free results.", "Window Cleaning", null },
                    { new Guid("bc249f18-53b0-4c6e-92bc-3db41bdd6e23"), new Guid("037385e0-36ca-4f9c-9b9e-06b50776c5d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7254), "Reliable ushering and event staffing services to ensure smooth operations and excellent guest experiences at your events.", "Ushering & Event Staffing", null },
                    { new Guid("bfe1d884-52a0-452c-b45d-9670682f9635"), new Guid("8ab5ed73-2800-4d23-8de9-4d815d332c4a"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7223), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7224), "Convenient ride-hailing services providing safe and reliable transportation within the city for individuals and groups.", "Ride Hailing (in-city transport)", null },
                    { new Guid("c87954a1-21b2-478e-941c-ef5b2bf50cab"), new Guid("060e7588-0162-490d-bdda-04a0fd7f87d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7208), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7209), "Professional carpentry services including furniture making, repairs, and custom woodwork for residential and commercial clients.", "Carpentry Services", null },
                    { new Guid("d1d2c602-cb27-4e8c-82ad-8519deba46cf"), new Guid("8ab5ed73-2800-4d23-8de9-4d815d332c4a"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7226), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7226), "Fast and reliable grocery delivery services bringing fresh produce and essentials directly to customers' homes.", "Grocery Delivery", null },
                    { new Guid("d3b1879b-f672-4b16-a203-2e48d3f1a853"), new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7231), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7232), "Creative graphic design services for branding, marketing materials, and digital content to effectively communicate your message.", "Graphic Design", null },
                    { new Guid("d4764355-6777-4872-bcad-df58f643f90e"), new Guid("c31582fa-1ee8-4d00-815c-e0e3aa8d310f"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7237), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7237), "Reliable IT support services including troubleshooting, network setup, and maintenance for businesses and individuals.", "IT Support Services", null },
                    { new Guid("db401cc4-e2ff-4f72-ab21-0392832ca795"), new Guid("060e7588-0162-490d-bdda-04a0fd7f87d8"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7206), "Comprehensive electrical services including repairs, installations, and maintenance for homes and businesses.", "Electrical Repairs & Installations", null },
                    { new Guid("f8bc2328-0d33-49da-bef5-6847154e1fbf"), new Guid("2748323b-4f11-4d3c-a6a3-e427df5fc366"), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 12, 1, 11, 19, 11, 363, DateTimeKind.Utc).AddTicks(7198), "Specialized carpet cleaning services using advanced techniques to remove dirt, stains, and allergens.", "Carpet Cleaning", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_ServiceListing_ServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_SP_ServiceListing_SP_Service_ServiceId",
                schema: "sp",
                table: "SP_ServiceListing",
                column: "ServiceId",
                principalSchema: "sp",
                principalTable: "SP_Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
