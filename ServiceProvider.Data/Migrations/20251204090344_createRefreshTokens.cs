using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceProvider.Data.Migrations
{
    /// <inheritdoc />
    public partial class createRefreshTokens : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetPasswordExpires",
                schema: "sp",
                table: "SP_User",
                type: "datetime2(3)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ResetPasswordToken",
                schema: "sp",
                table: "SP_User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "SP_RefreshToken",
                schema: "sp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2(3)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SP_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SP_RefreshToken_SP_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "sp",
                        principalTable: "SP_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Category",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("0fcfa655-ba7e-419a-a935-653710e53894"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4336), "Cleaning & Housekeeping", "" },
                    { new Guid("115dcea4-49f8-4b28-b76b-34da65ecf846"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4344), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4344), "Jua Kali & General Repairs", "" },
                    { new Guid("2ba82e5a-7a84-4ebf-afb2-10fe21f94252"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4352), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4351), "Beauty, SPA & Personal Care Services", "" },
                    { new Guid("4484d882-a6cf-4273-8fc1-4f1d5f56ad2a"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4350), "Fitness & Wellness Services", "" },
                    { new Guid("4b72500d-5454-42f5-abca-717103b079ee"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4348), "Tutoring & Educational Services", "" },
                    { new Guid("59ae4c9b-db76-4bba-98f5-d36bed3684a8"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4346), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4345), "Ride Hailing & Delivery Services", "" },
                    { new Guid("6d69ad99-607b-432c-bf35-7929920aa301"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4353), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4353), "Web & IT Support Services", "" },
                    { new Guid("c15cc085-7452-45d8-9bb5-48320d04170e"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4339), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4338), "Landscaping & Gardening", "" },
                    { new Guid("d0538f8a-5f55-4c18-9638-227e41ad2734"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4347), "Catering & Event Services", "" },
                    { new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4355), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4354), "Professional & Digital Services", "" }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_County",
                columns: new[] { "Id", "CountyName", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("01bf1b69-5de8-4a97-984a-9fb801b8b666"), "KAKAMEGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"), "BARINGO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1783b984-3951-4264-9de9-2df75338007f"), "NANDI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1a019351-0b75-4c26-bd5b-4b2a24307d17"), "SAMBURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("21c6d047-ec0f-4285-a7bc-2bb3223d6628"), "NYANDARUA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), "KITUI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2aff320f-dd4c-4020-87d2-462462bc811a"), "TANA RIVER", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2db9b23b-c8a3-455d-adb9-ec1d8c9a3bb8"), "EMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2f22d5c8-3de8-4bd7-8056-0413ea888db9"), "KAJIADO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3114027d-fe42-4589-82f0-4fd3f8b304d9"), "BUSIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("32e38f44-9e40-45b2-82e2-ddaeec6b6e5b"), "KERICHO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("332d9dbf-2c8e-4da2-a27a-938fe275e917"), "ISIOLO", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), "NYERI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("37e9bac8-bcc3-405d-91f0-5945be641a18"), "HOMA BAY", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), "WAJIR", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3c0f1373-28d7-49e4-81ad-e5d6e81b89f5"), "SIAYA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3f2b87d0-7613-4ed7-bc28-f92f9b350fbe"), "NYAMIRA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), "UASIN GISHU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), "NAKURU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), "MANDERA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5695f52c-41a3-4253-8e39-36b6c7b51c87"), "LAMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5a44bc1d-dab6-4ad9-a91a-cf6d07409767"), "WEST POKOT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5f6af2bb-7bad-42af-aafc-d311a77b84e9"), "BUNGOMA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("625d7750-a9a9-4619-a0c9-53b7b44d60e8"), "KISII", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("654823fe-3fef-4ebc-a218-23c9123d292d"), "KISUMU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), "GARISSA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6ae1d248-65f6-4923-8f4c-2536340ea069"), "THARAKA-NITHI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6b62bf76-e92f-4715-93ab-dcd346070618"), "KWALE", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6fe5ac1e-e266-488c-905f-c84043dda638"), "ELGEYO/MARAKWET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("83fd0ae0-0bc5-428f-94dc-3a9b03fec8d8"), "BOMET", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("89f7ad3b-15fa-4975-8f30-c2aa792fa029"), "TAITA TAVETA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9c1261cd-6855-48aa-a06d-b30dc2d17df3"), "MIGORI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), "MAKUENI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc2c889f-9af2-4fde-ac40-9e78bbbe81e2"), "VIHIGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bf3de03c-0f0c-4b68-ab8c-2804b89116dc"), "MARSABIT", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c487c0ef-d780-4602-9c85-ddacea542743"), "NAROK", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), "MACHAKOS", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cffd2db0-ae46-4794-bb35-912acca3555b"), "KIRINYAGA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), "MOMBASA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), "KILIFI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"), "TRANS NZOIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), "MURANG'A", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), "NAIROBI", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), "TURKANA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), "MERU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), "KIAMBU", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f1afbc73-7701-48a9-862f-9b250b559df0"), "LAIKIPIA", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Location",
                columns: new[] { "Id", "ConstituencyId", "DateCreated", "DateModified", "LocationName" },
                values: new object[,]
                {
                    { new Guid("0c4ff226-552e-42ed-b5ba-7d30d5d0210f"), new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kasarani" },
                    { new Guid("3b9a8d1c-db04-41db-8a27-bae7260acfca"), new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Claycity" },
                    { new Guid("9f7707e8-feef-4cdb-acef-fc35cbad9a7f"), new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mwiki" },
                    { new Guid("dbccecb7-ab68-4c29-92cd-6154f9c587f7"), new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ruai" },
                    { new Guid("f9aeff2f-0a8c-4bcf-afad-083c6599bff3"), new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Njiru" }
                });

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("17ff54a6-9d9a-45dc-95ea-10b68b9e6378"),
                columns: new[] { "ResetPasswordExpires", "ResetPasswordToken" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("4315515f-9932-49b7-a01d-7261047ed1c9"),
                columns: new[] { "ResetPasswordExpires", "ResetPasswordToken" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.UpdateData(
                schema: "sp",
                table: "SP_User",
                keyColumn: "Id",
                keyValue: new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"),
                columns: new[] { "ResetPasswordExpires", "ResetPasswordToken" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "" });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Constituency",
                columns: new[] { "Id", "ConstituencyName", "CountyId", "DateCreated", "DateModified" },
                values: new object[,]
                {
                    { new Guid("01d85f31-b653-442e-b162-acfd93e4b5d3"), "Likoni", new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("04c3ec64-69ce-4c7a-94bb-88f67eab7a4b"), "Kwanza", new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("055833aa-3c7e-4dbf-9197-9c87c4d9b875"), "Kibwezi East", new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("065cb9ae-26a8-45c4-a803-d4c8d1b622b4"), "Turkana West", new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("073ce62c-28aa-4c56-a837-17fda15f4b2f"), "Kaiti", new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("097103db-e4cd-458c-b5d8-88a815d0a5cd"), "Rabai", new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0a2e3657-54c9-4272-8e40-24387a8dc865"), "Yatta", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0bd55b9b-7792-46e0-a480-c6843689e268"), "Kiminini", new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0c10f5b6-7c7a-4f94-bc3a-ecedbe59f696"), "Ol Kalou", new Guid("21c6d047-ec0f-4285-a7bc-2bb3223d6628"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("0e6931bd-4e95-46fb-8ff7-a3966c74e8e0"), "Mathira", new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("103afc6b-9a2c-4ab8-acc3-fc8daf96ee90"), "Mbeere North", new Guid("2db9b23b-c8a3-455d-adb9-ec1d8c9a3bb8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1050925f-c79f-4fa7-a283-4317b71b9ba8"), "Turbo", new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("11e7bc32-9fad-4a25-8793-0f600dd11b4d"), "Matungulu", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("148238ca-6a78-4569-b7df-d8e4084babf1"), "Marakwet West", new Guid("6fe5ac1e-e266-488c-905f-c84043dda638"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("16ff73dc-a7d1-4412-b3f2-35d4ad11a3ad"), "Turkana East", new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("177edbb6-4c5e-42f2-8cd9-05ea6ce6007b"), "Gatundu North", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("193a33f9-9570-4d9e-8a40-50eb32cd85e5"), "Kibra", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("195c63eb-8947-4999-be2a-f1eed37caa24"), "Kitui South", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("19a2c6f1-a90b-46e3-9078-a29d1562ba83"), "Juja", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1ba62731-ea38-465d-8904-8c9c2a920ac3"), "Moyale", new Guid("bf3de03c-0f0c-4b68-ab8c-2804b89116dc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1c7db455-c3be-4117-b374-5ff2a89ce718"), "Kibwezi West", new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("1f53acde-f1a6-4352-a249-a29df0366e10"), "Ijara", new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2092f659-039d-40c3-8408-c2016ebc7951"), "Embakasi East", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("219b7933-3c64-4123-9123-53bae567cac3"), "Kinango", new Guid("6b62bf76-e92f-4715-93ab-dcd346070618"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22b5c3a9-d106-4926-aeda-35adb84c8936"), "Mandera West", new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("22bd20da-614e-406b-9b41-5ef1a39cbb07"), "Saboti", new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("236e3925-0938-4e61-be1d-135d13210d42"), "Loima", new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2433a4da-f4c2-41d7-92e7-61eeb98fafcb"), "Garissa Township", new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2676124c-c71e-4639-a95a-a08fdc07ee28"), "Kangundo", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("28887920-df7c-4335-9053-f5546a352b0d"), "Mukurweini", new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("28c6f6cb-8a6e-47c8-9e90-468053469cdc"), "Mwatate", new Guid("89f7ad3b-15fa-4975-8f30-c2aa792fa029"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("29a3f5ac-1f7d-4667-b51d-c66ed2ca60ea"), "Baringo Central", new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2b667953-e268-4957-90ca-878448f66861"), "Kangema", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2c7e7c47-0738-4bee-bf2e-4dc53b6f14a4"), "Voi", new Guid("89f7ad3b-15fa-4975-8f30-c2aa792fa029"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2cd55280-c798-44f1-bd75-6df643f02d18"), "Samburu North", new Guid("1a019351-0b75-4c26-bd5b-4b2a24307d17"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2e03b0ef-2793-4184-9c9c-07dee0157837"), "Tharaka", new Guid("6ae1d248-65f6-4923-8f4c-2536340ea069"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("2e1f05ee-391a-4b2a-a26a-e8e1b50a0041"), "Msambweni", new Guid("6b62bf76-e92f-4715-93ab-dcd346070618"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("32e549bc-13c7-4f07-aabb-d9e58d742290"), "Moiben", new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("32f50954-5012-4996-976d-890a816359da"), "Jomvu", new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("330291f3-dc36-4cb0-8098-9471892df31e"), "Kitui Central", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33874658-9859-448f-9c14-f1364f1b6d9c"), "Keiyo North", new Guid("6fe5ac1e-e266-488c-905f-c84043dda638"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("33fb5d9d-7595-448d-9cf5-f99061d8a6f8"), "Taveta", new Guid("89f7ad3b-15fa-4975-8f30-c2aa792fa029"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3497d076-9574-472a-874e-4965b909cfe2"), "Turkana South", new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3558cd9e-be22-47a0-a685-4b0157504577"), "Laisamis", new Guid("bf3de03c-0f0c-4b68-ab8c-2804b89116dc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36721f1d-a671-4508-a09e-0c8045c10d39"), "Sigor", new Guid("5a44bc1d-dab6-4ad9-a91a-cf6d07409767"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("36ab3b29-5169-4d04-bad9-9423fd1756b8"), "Kathiani", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("37b9a1b9-a121-4cda-a6a9-4af87021c765"), "Kieni", new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("387e58a6-af45-4a75-ad10-3a0c4b7f080b"), "Gatanga", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3ab0ecaa-00b1-4297-bbce-50a9ff76b0b5"), "Masinga", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3aca6865-f670-4d53-b652-6b899272b97d"), "Maragwa", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3b42859f-410c-4df9-a38e-fe4ed6df1e9d"), "Laikipia East", new Guid("f1afbc73-7701-48a9-862f-9b250b559df0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("3f6a3d16-ad66-42c5-b1bb-f38b655a688d"), "Runyenjes", new Guid("2db9b23b-c8a3-455d-adb9-ec1d8c9a3bb8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("42b640d5-a5f8-4edc-a326-974f12d5c73f"), "Wajir East", new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("42c0bd00-00e9-404d-b94e-a881a9b268cd"), "Igembe South", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("457c526e-198e-48a6-a2d4-6906708f1dfc"), "Matuga", new Guid("6b62bf76-e92f-4715-93ab-dcd346070618"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4902354d-64b4-4397-ac44-1e781c926ac1"), "Soy", new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4912817d-4b04-4f48-840d-98788e1d6cb7"), "Mwingi West", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4cc06de9-76d6-49d8-9a9d-73bca00252ca"), "Magarini", new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4d311df3-8776-428a-a1e4-74de34721513"), "Turkana Central", new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4e49dd55-0881-4372-b4f8-39ef893c00f5"), "Ruiru", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("4fc182a5-8ab9-45ca-8491-1d41dc95c677"), "Ainabkoi", new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("50f758a2-44be-4e3e-a1e5-7083d03208e1"), "Nyeri Town", new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("52981a62-efff-4e1c-b6c5-09e1daab72c0"), "Garsen", new Guid("2aff320f-dd4c-4020-87d2-462462bc811a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("553f93a9-6ed2-4c02-a3f0-a87d2e5e9203"), "Kitui West", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("55db1931-20df-4a21-9788-f78221e8ddf6"), "Nandi Hills", new Guid("1783b984-3951-4264-9de9-2df75338007f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("56b4fddd-8d49-4f8e-8ae0-d1c6e416c166"), "Makueni", new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b4be77e-da9a-4894-a056-73ca338d6dfb"), "Embakasi Central", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5b579b32-c8ad-4b8f-825c-1b70f7a96d19"), "Kamukunji", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5bed3ddb-d414-4734-a20f-e0bc8d645ad3"), "Mvita", new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5cb40255-bffb-4a7a-8383-1090bf537c91"), "Keiyo South", new Guid("6fe5ac1e-e266-488c-905f-c84043dda638"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("5e2e0815-0eef-4567-a15a-092c9fd74516"), "Emgwen", new Guid("1783b984-3951-4264-9de9-2df75338007f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("60e26342-7c03-4065-880c-c4003fd94656"), "Dagoretti North", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("63c3e8eb-c945-4d7c-a981-6feb48378daf"), "Eldas", new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6592de52-5aeb-4ef9-b951-264cff8efddb"), "Kacheliba", new Guid("5a44bc1d-dab6-4ad9-a91a-cf6d07409767"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("66a20670-7065-43a5-a717-1b143d6d98a2"), "Kitui Rural", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"), "Kasarani", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6cbe52b9-0481-4e17-b7f9-80f4a48b5221"), "Manyatta", new Guid("2db9b23b-c8a3-455d-adb9-ec1d8c9a3bb8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6f5b22c1-44a8-4528-b8c9-b724a28fc47a"), "Tigania East", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("6fb30a01-f799-432b-ac50-1e8cba3814b8"), "Njoro", new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("712b1935-103a-4704-95c5-3b29d1be50e0"), "Laikipia North", new Guid("f1afbc73-7701-48a9-862f-9b250b559df0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("72583cb2-4e84-4ab1-946b-3552385e28be"), "Mbeere South", new Guid("2db9b23b-c8a3-455d-adb9-ec1d8c9a3bb8"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("74886189-628d-4197-808c-5368f995dbd6"), "Aldai", new Guid("1783b984-3951-4264-9de9-2df75338007f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("764fd442-033b-467c-9236-e684ecfa550c"), "Lafey", new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("789d9569-b97d-4caa-b7a3-854b1cc7f1ac"), "Kitui East", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7968bcc3-cbac-4aa5-999f-fb3ea2b5bb42"), "Tetu", new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("79be1dbc-d84c-40c5-88ab-fd77a7d9ca3e"), "Makadara", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("79e34f9f-d96c-405e-b249-f65335ab1407"), "Kuresoi North", new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7bb09046-9015-4c5b-aac4-4ea7e0270909"), "Daadab", new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("7dc0e484-0a4c-4e6a-9947-2b23470b6c1a"), "Kilome", new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8115398d-becd-48ce-a181-43cc9f320612"), "Eldama Ravine", new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82a16275-bf23-4963-a1fa-c49f1bbea867"), "Wajir West", new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("82a24a29-b1a2-46fa-b9b4-b1de289630ac"), "Mathare", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8380b44e-095c-49e9-8751-16d2d6edde69"), "Machakos Town", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8397ec21-e374-4028-b770-c0c1812d620c"), "Mathioya", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("83c30bce-03ab-4c46-8861-5d77a089b7a9"), "Lungalunga", new Guid("6b62bf76-e92f-4715-93ab-dcd346070618"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("85e60eaa-e58b-4c60-8d34-b5862adb50b4"), "Ndaragwa", new Guid("21c6d047-ec0f-4285-a7bc-2bb3223d6628"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("86634c98-106f-4055-8467-dc4c2f64019e"), "Gichugu", new Guid("cffd2db0-ae46-4794-bb35-912acca3555b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8722ed2d-fc03-4017-8cea-f75feefd0fed"), "Lagdera", new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87c2089a-f679-43e7-a6b6-a6b808d7cbb6"), "Mandera East", new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("87e92b29-ffd0-4381-9e6f-dfd0438ca974"), "Kipipiri", new Guid("21c6d047-ec0f-4285-a7bc-2bb3223d6628"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("89ac32ca-4688-4fb0-a6b3-914f888811cf"), "Mandera North", new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("89bda500-aa7b-4440-92aa-7eed2be402bc"), "Kesses", new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8a672eae-fa84-4ab2-88b1-894138f7f335"), "Maara", new Guid("6ae1d248-65f6-4923-8f4c-2536340ea069"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8b0f0ea1-c7a5-482b-9472-f279241898bd"), "Pokot South", new Guid("5a44bc1d-dab6-4ad9-a91a-cf6d07409767"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8b201c2b-0660-4f31-8bb8-24b2fbde8356"), "Saku", new Guid("bf3de03c-0f0c-4b68-ab8c-2804b89116dc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8c4ab7be-7771-4080-aef1-13f866fd5211"), "Thika Town", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8cab2aa5-3f69-4846-a92b-dc76e15aa4f2"), "Banissa", new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("8fae693a-d6ee-41e5-a2e7-18ee5d5608d5"), "Kikuyu", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("903c7f5e-b9ca-4adb-9ade-a6e226992b04"), "Endebess", new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("96197a39-4cc9-476a-9155-52359183aa53"), "Langata", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("96e10204-cf41-4769-9f4e-cf44ec28fcee"), "Ruaraka", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("97c205a0-52c9-4c76-80b9-0f0ee83727f5"), "North Horr", new Guid("bf3de03c-0f0c-4b68-ab8c-2804b89116dc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("97d68677-7df7-46d0-959f-1b2035a18841"), "North Imenti", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9873fc98-8751-4c53-a768-a80dcd96ca9f"), "Kilifi South", new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9a79fc87-549a-4ac2-b9f9-4c95314f533a"), "Wajir North", new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9ce9c927-2ba0-42ba-9fff-0eda834103ac"), "Tinderet", new Guid("1783b984-3951-4264-9de9-2df75338007f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9d2ff68b-dd41-4904-bb45-e73a73a2cd8a"), "Tigania West", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("9e4c929a-71c3-48c8-b2e3-0391bcc93fae"), "Dagoretti South", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a0ad4c1d-6c1c-4637-b59a-e1a8d6696204"), "Kabete", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a170b70c-13fa-48dc-9ad6-bebda8375574"), "Kisauni", new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a30d9eba-9ca1-44a2-8919-aff6c9ccc34b"), "Baringo South", new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a337b8a7-dad1-4f9b-aef1-eaf42fb55c00"), "Isiolo South", new Guid("332d9dbf-2c8e-4da2-a27a-938fe275e917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a3713378-274b-49e7-99a5-8bf0e39bf7dd"), "Ndia", new Guid("cffd2db0-ae46-4794-bb35-912acca3555b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a3c090fb-ffe4-47c1-8a88-62aa3266c666"), "Ol Jorok", new Guid("21c6d047-ec0f-4285-a7bc-2bb3223d6628"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a5fd8493-2ef0-475a-86c4-bc95da897ce2"), "Laikipia West", new Guid("f1afbc73-7701-48a9-862f-9b250b559df0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a74ff396-455a-4aa6-bed2-6155b7f85275"), "Naivasha", new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("a8103cef-419f-4926-b4fc-d1616a15e1dc"), "Kuresoi South", new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("aabd74d7-618e-410b-b905-81a301508987"), "Roysambu", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("abd95e18-4dce-473b-b3cf-6fd2360056d9"), "Baringo North", new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ac6619ec-3f64-44f0-92f0-1a2195d0c194"), "Mwingi North", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ad1ed4b1-0b38-4161-8ac3-deedd7caa1de"), "Samburu East", new Guid("1a019351-0b75-4c26-bd5b-4b2a24307d17"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b0ccf2b5-4238-4661-befc-882b4b82601a"), "Mbooni", new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b1e976e5-12ca-47e6-8cd8-2107111448f1"), "Marakwet East", new Guid("6fe5ac1e-e266-488c-905f-c84043dda638"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b228050c-1ab3-48e8-a94b-a35c44f6b73b"), "Igembe North", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b304317b-c154-4a18-8a3b-375f97dc31ea"), "Changamwe", new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b59612e8-59eb-4d08-a023-1e1101418b2a"), "Galole", new Guid("2aff320f-dd4c-4020-87d2-462462bc811a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b5a76591-6cc6-4474-91d7-afeb70261e20"), "Bura", new Guid("2aff320f-dd4c-4020-87d2-462462bc811a"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b6085860-4c9f-4b8c-8a5f-794f4631e2e6"), "Kilifi North", new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b86ca1c1-bd6e-4692-881b-dac8eb42f25b"), "Kiambu", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("b90c775d-344c-4f93-ac1b-4e866e3ccf4d"), "Kandara", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bb946450-e7b8-40a7-9d1b-ec0f635ef5de"), "Kiambaa", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bbe865ba-9cbb-48ec-a84f-f2c2e2c06529"), "Othaya", new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bc0e9ec2-fba1-4db4-94b4-e99ef6630011"), "Mavoko", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("bda5a9a6-3f47-48d5-b75d-f72c76a4efe0"), "Buuri", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c0877c61-307a-4a11-b612-390938637783"), "Kiharu", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c0fa1cd6-f0f5-4566-82b6-beaf1fe09411"), "Igembe Central", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c32d616d-868c-4e8f-84e0-a1f6cf61442c"), "Turkana North", new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c360ed2d-826a-4529-ac3b-792b90dbc6c1"), "Cherangany", new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c8381f7d-c909-4239-9b0a-3547b3a3a6e7"), "Kapseret", new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("c86d5793-d348-4824-aedc-9f11004b741f"), "Limuru", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ca758267-f241-45a9-80f5-2204531dd452"), "Fafi", new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cac6cf4b-a703-4886-a801-12ac21453d90"), "South Imenti", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("cc26c3ca-b673-4b2f-ace5-736224eefeb5"), "Githunguri", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d1988d42-de3e-4d5f-9beb-ac87f97b8ba9"), "Kigumo", new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d1fae315-4ce3-438c-bef7-4b9daa2ffd4c"), "Mandera South", new Guid("55da7a73-71e7-437a-a578-738a63c6da42"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d3357a38-0095-440c-a971-05d537f04147"), "Lamu West", new Guid("5695f52c-41a3-4253-8e39-36b6c7b51c87"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d455cb4b-e7ac-43d8-9f37-f43e06e1ca3b"), "Chesumei", new Guid("1783b984-3951-4264-9de9-2df75338007f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d5a293d9-a4cb-4f7f-b79e-5231b5e20939"), "Mosop", new Guid("1783b984-3951-4264-9de9-2df75338007f"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("d80d444f-a76f-4d13-a250-5185b0222c10"), "Embakasi North", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dcc84281-a735-4bd2-9a0a-86ae944b13fc"), "Tarbaj", new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("dd859385-2342-4f80-95ff-0f45dd87bf86"), "Lari", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ddccdeca-b1cd-463b-aecf-15dac42b9d30"), "Mwingi Central", new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ddd0cf76-1b99-4d3f-bf60-f9e54f3d6bcb"), "Starehe", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e3f1450d-781e-4e7f-a069-90bc1c9ef96f"), "Kirinyaga Central", new Guid("cffd2db0-ae46-4794-bb35-912acca3555b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("e8ac6e49-880d-478e-90cb-07a725195380"), "Gatundu South", new Guid("f0786368-59d7-4462-b09a-67fa076683ff"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("eb6c397d-a191-4e50-bfa8-0b676f10852a"), "Mogotio", new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee087437-95c5-498b-b510-a93f3c393cdd"), "Embakasi South", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ee5f29c1-3ee6-4762-ba02-a89032be8e99"), "Malindi", new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ef870c7e-0eee-47cb-a4e5-a88d577d2c2d"), "Nyali", new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("efc8f93d-1299-4e8b-a08a-8ff92e667072"), "Wundanyi", new Guid("89f7ad3b-15fa-4975-8f30-c2aa792fa029"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f0d3225a-3d74-4c22-bfba-1ce8e55eb896"), "Lamu East", new Guid("5695f52c-41a3-4253-8e39-36b6c7b51c87"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f3caac07-9506-4f06-ba4d-adec3a8d6c06"), "Wajir South", new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f40e9dea-e25d-4138-8b3f-f85f8b17e677"), "Chuka/Igambang'ombe", new Guid("6ae1d248-65f6-4923-8f4c-2536340ea069"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f4dbd795-aafa-4f07-ab8d-a91e667712fc"), "Kapenguria", new Guid("5a44bc1d-dab6-4ad9-a91a-cf6d07409767"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f4e777af-68cb-423e-9ec4-4fbc1e4320ed"), "Westlands", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f71cc678-e7c9-47a7-8c14-1ded30040349"), "Central Imenti", new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("f785b726-3b98-4120-a701-f622488184a3"), "Balambala", new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fa6fa6db-826d-446f-9ca5-43d5579cb168"), "Ganze", new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fc274ddf-9938-43c1-a0e3-edb204e79802"), "Embakasi West", new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fc3be935-13b3-444c-b432-bb3709f34ab4"), "Mwea", new Guid("cffd2db0-ae46-4794-bb35-912acca3555b"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd046c3f-0199-412c-87bd-1500e8b4bf77"), "Samburu West", new Guid("1a019351-0b75-4c26-bd5b-4b2a24307d17"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fd2c8a01-89b8-48f5-a4df-08c77d130cd1"), "Molo", new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("fde30345-c0b0-4f37-8f51-8ef9629d570a"), "Mwala", new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff46d9e9-7142-4e5e-91af-ab8dbaab6342"), "Gilgil", new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { new Guid("ff98ec44-67d6-4bb3-9094-82d3d81697b3"), "Isiolo North", new Guid("332d9dbf-2c8e-4da2-a27a-938fe275e917"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                schema: "sp",
                table: "SP_Service",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateModified", "Description", "Name", "ServiceProviderEntityId" },
                values: new object[,]
                {
                    { new Guid("10a7353f-e170-4f05-ac2a-ecb32caf787b"), new Guid("59ae4c9b-db76-4bba-98f5-d36bed3684a8"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4425), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4425), "Reliable parcel delivery services offering door-to-door delivery within the city, ensuring timely and secure transport of packages.", "Parcel Delivery (door-to-door, within city)", null },
                    { new Guid("1d3f3c2d-b888-4ab3-84c0-1136204ce93e"), new Guid("0fcfa655-ba7e-419a-a935-653710e53894"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4402), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4403), "Professional office cleaning services tailored to maintain a clean and productive work environment.", "Office Cleaning", null },
                    { new Guid("39be7a57-8e26-4f36-b321-0d6dcbfefec1"), new Guid("2ba82e5a-7a84-4ebf-afb2-10fe21f94252"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4466), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4466), "Professional beauty and spa services including facials, manicure, hairdressing, massages, and skincare treatments to promote relaxation and wellness.", "Beauty & Spa Services", null },
                    { new Guid("3c8c400a-8120-41ca-8ce7-0e309bba49df"), new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4440), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4441), "Comprehensive digital marketing solutions including SEO, social media management, and online advertising to boost your online presence.", "Digital Marketing Services", null },
                    { new Guid("3db834db-4e10-4ee9-bb53-ffe3e57c3574"), new Guid("59ae4c9b-db76-4bba-98f5-d36bed3684a8"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4438), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4438), "Fast and reliable grocery delivery services bringing fresh produce and essentials directly to customers' homes.", "Grocery Delivery", null },
                    { new Guid("43caee12-7694-46c8-b1d9-74c442e686f9"), new Guid("0fcfa655-ba7e-419a-a935-653710e53894"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4408), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4408), "Professional window cleaning services for residential and commercial properties, ensuring streak-free results.", "Window Cleaning", null },
                    { new Guid("550ff1fe-6315-44bd-8192-8d752964e078"), new Guid("d0538f8a-5f55-4c18-9638-227e41ad2734"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4458), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4458), "Expert photography and videography services capturing memorable moments at events and creating stunning portraits for individuals and families.", "Photography & Videography (events, portraits)", null },
                    { new Guid("623e5ee8-66eb-4c08-850b-6838b5f7bb75"), new Guid("d0538f8a-5f55-4c18-9638-227e41ad2734"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4456), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4456), "Professional event catering services for weddings, corporate events, and special occasions, offering customized menus and exceptional service.", "Event Catering (weddings, corporate)", null },
                    { new Guid("64f05cb0-832b-4f04-b0a4-6743d01bc4fb"), new Guid("59ae4c9b-db76-4bba-98f5-d36bed3684a8"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4435), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4436), "Convenient ride-hailing services providing safe and reliable transportation within the city for individuals and groups.", "Ride Hailing (in-city transport)", null },
                    { new Guid("6e581e10-b159-4eb7-9850-0038f58f3181"), new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4450), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4451), "Reliable IT support services including troubleshooting, network setup, and maintenance for businesses and individuals.", "IT Support Services", null },
                    { new Guid("75e339d3-f254-421b-8f9c-fa4b77e2781e"), new Guid("59ae4c9b-db76-4bba-98f5-d36bed3684a8"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4427), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4427), "Efficient food delivery services partnering with local restaurants to bring meals directly to customers' doorsteps.", "Food Delivery", null },
                    { new Guid("80390b04-5435-4abd-81b8-ac3cf3afa47b"), new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4453), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4453), "Expert social media management services to enhance your brand's online presence and engage with your audience effectively.", "Social Media Management (SMM)", null },
                    { new Guid("84ff53e3-beeb-48b3-806c-173619712b8b"), new Guid("d0538f8a-5f55-4c18-9638-227e41ad2734"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4461), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4461), "Professional decorator services for parties and functions, providing creative setups and themes to enhance the event atmosphere.", "Decorator Services (party, function setup)", null },
                    { new Guid("8bdf3cd6-8563-44ba-9c31-13482ef3ef6b"), new Guid("115dcea4-49f8-4b28-b76b-34da65ecf846"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4422), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4423), "Expert painting and decorating services for interior and exterior spaces, enhancing the aesthetic appeal of homes and businesses.", "Painting & Decorating", null },
                    { new Guid("9ce75b5e-849b-4a30-a652-980dc20627c3"), new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4448), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4448), "Professional web development services to create responsive, user-friendly websites tailored to your business needs.", "Web Development", null },
                    { new Guid("aa98dfdf-0ccc-4515-819c-ff342a110846"), new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4443), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4444), "Creative graphic design services for branding, marketing materials, and digital content to effectively communicate your message.", "Graphic Design", null },
                    { new Guid("acd4fa15-5af2-4d24-a7e4-e890b9a5c347"), new Guid("2ba82e5a-7a84-4ebf-afb2-10fe21f94252"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4470), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4471), "Comprehensive fitness and wellness services including personal training, yoga & gym classes, and nutrition counseling to help you achieve your health goals.", "Fitness & Wellness Services", null },
                    { new Guid("adbb102d-533b-4422-abc1-c278495dac91"), new Guid("0fcfa655-ba7e-419a-a935-653710e53894"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4405), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4405), "Specialized carpet cleaning services using advanced techniques to remove dirt, stains, and allergens.", "Carpet Cleaning", null },
                    { new Guid("b913e14d-606f-4220-a96d-852330110150"), new Guid("115dcea4-49f8-4b28-b76b-34da65ecf846"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4410), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4411), "Expert plumbing services including leak repairs, fixture installations, and maintenance for residential and commercial properties.", "Plumbing (leak fixes, installations)", null },
                    { new Guid("dead6333-8f95-47f2-85c0-4885d151427f"), new Guid("115dcea4-49f8-4b28-b76b-34da65ecf846"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4420), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4420), "Professional carpentry services including furniture making, repairs, and custom woodwork for residential and commercial clients.", "Carpentry Services", null },
                    { new Guid("e7747a0f-f1a3-4976-98f0-77523eb0da20"), new Guid("d0538f8a-5f55-4c18-9638-227e41ad2734"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4464), "Reliable ushering and event staffing services to ensure smooth operations and excellent guest experiences at your events.", "Ushering & Event Staffing", null },
                    { new Guid("ef92c30b-96f1-4b9c-a7c8-b4e4620aca06"), new Guid("115dcea4-49f8-4b28-b76b-34da65ecf846"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4413), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4413), "Comprehensive electrical services including repairs, installations, and maintenance for homes and businesses.", "Electrical Repairs & Installations", null },
                    { new Guid("f6da50c5-3a76-47b5-bf6d-e6c4d046d1be"), new Guid("0fcfa655-ba7e-419a-a935-653710e53894"), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4399), new DateTime(2025, 12, 4, 9, 3, 43, 426, DateTimeKind.Utc).AddTicks(4400), "Comprehensive home cleaning services including dusting, vacuuming, mopping, and sanitizing all rooms.", "Home Cleaning", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SP_RefreshToken_Token",
                schema: "sp",
                table: "SP_RefreshToken",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SP_RefreshToken_UserId",
                schema: "sp",
                table: "SP_RefreshToken",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SP_RefreshToken",
                schema: "sp");

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("4484d882-a6cf-4273-8fc1-4f1d5f56ad2a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("4b72500d-5454-42f5-abca-717103b079ee"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("6d69ad99-607b-432c-bf35-7929920aa301"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("c15cc085-7452-45d8-9bb5-48320d04170e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("01d85f31-b653-442e-b162-acfd93e4b5d3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("04c3ec64-69ce-4c7a-94bb-88f67eab7a4b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("055833aa-3c7e-4dbf-9197-9c87c4d9b875"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("065cb9ae-26a8-45c4-a803-d4c8d1b622b4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("073ce62c-28aa-4c56-a837-17fda15f4b2f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("097103db-e4cd-458c-b5d8-88a815d0a5cd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0a2e3657-54c9-4272-8e40-24387a8dc865"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0bd55b9b-7792-46e0-a480-c6843689e268"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0c10f5b6-7c7a-4f94-bc3a-ecedbe59f696"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("0e6931bd-4e95-46fb-8ff7-a3966c74e8e0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("103afc6b-9a2c-4ab8-acc3-fc8daf96ee90"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1050925f-c79f-4fa7-a283-4317b71b9ba8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("11e7bc32-9fad-4a25-8793-0f600dd11b4d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("148238ca-6a78-4569-b7df-d8e4084babf1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("16ff73dc-a7d1-4412-b3f2-35d4ad11a3ad"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("177edbb6-4c5e-42f2-8cd9-05ea6ce6007b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("193a33f9-9570-4d9e-8a40-50eb32cd85e5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("195c63eb-8947-4999-be2a-f1eed37caa24"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("19a2c6f1-a90b-46e3-9078-a29d1562ba83"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1ba62731-ea38-465d-8904-8c9c2a920ac3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1c7db455-c3be-4117-b374-5ff2a89ce718"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("1f53acde-f1a6-4352-a249-a29df0366e10"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2092f659-039d-40c3-8408-c2016ebc7951"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("219b7933-3c64-4123-9123-53bae567cac3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("22b5c3a9-d106-4926-aeda-35adb84c8936"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("22bd20da-614e-406b-9b41-5ef1a39cbb07"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("236e3925-0938-4e61-be1d-135d13210d42"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2433a4da-f4c2-41d7-92e7-61eeb98fafcb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2676124c-c71e-4639-a95a-a08fdc07ee28"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("28887920-df7c-4335-9053-f5546a352b0d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("28c6f6cb-8a6e-47c8-9e90-468053469cdc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("29a3f5ac-1f7d-4667-b51d-c66ed2ca60ea"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2b667953-e268-4957-90ca-878448f66861"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2c7e7c47-0738-4bee-bf2e-4dc53b6f14a4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2cd55280-c798-44f1-bd75-6df643f02d18"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2e03b0ef-2793-4184-9c9c-07dee0157837"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("2e1f05ee-391a-4b2a-a26a-e8e1b50a0041"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("32e549bc-13c7-4f07-aabb-d9e58d742290"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("32f50954-5012-4996-976d-890a816359da"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("330291f3-dc36-4cb0-8098-9471892df31e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("33874658-9859-448f-9c14-f1364f1b6d9c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("33fb5d9d-7595-448d-9cf5-f99061d8a6f8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3497d076-9574-472a-874e-4965b909cfe2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3558cd9e-be22-47a0-a685-4b0157504577"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("36721f1d-a671-4508-a09e-0c8045c10d39"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("36ab3b29-5169-4d04-bad9-9423fd1756b8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("37b9a1b9-a121-4cda-a6a9-4af87021c765"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("387e58a6-af45-4a75-ad10-3a0c4b7f080b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3ab0ecaa-00b1-4297-bbce-50a9ff76b0b5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3aca6865-f670-4d53-b652-6b899272b97d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3b42859f-410c-4df9-a38e-fe4ed6df1e9d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("3f6a3d16-ad66-42c5-b1bb-f38b655a688d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("42b640d5-a5f8-4edc-a326-974f12d5c73f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("42c0bd00-00e9-404d-b94e-a881a9b268cd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("457c526e-198e-48a6-a2d4-6906708f1dfc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4902354d-64b4-4397-ac44-1e781c926ac1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4912817d-4b04-4f48-840d-98788e1d6cb7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4cc06de9-76d6-49d8-9a9d-73bca00252ca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4d311df3-8776-428a-a1e4-74de34721513"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4e49dd55-0881-4372-b4f8-39ef893c00f5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("4fc182a5-8ab9-45ca-8491-1d41dc95c677"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("50f758a2-44be-4e3e-a1e5-7083d03208e1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("52981a62-efff-4e1c-b6c5-09e1daab72c0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("553f93a9-6ed2-4c02-a3f0-a87d2e5e9203"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("55db1931-20df-4a21-9788-f78221e8ddf6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("56b4fddd-8d49-4f8e-8ae0-d1c6e416c166"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5b4be77e-da9a-4894-a056-73ca338d6dfb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5b579b32-c8ad-4b8f-825c-1b70f7a96d19"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5bed3ddb-d414-4734-a20f-e0bc8d645ad3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5cb40255-bffb-4a7a-8383-1090bf537c91"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("5e2e0815-0eef-4567-a15a-092c9fd74516"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("60e26342-7c03-4065-880c-c4003fd94656"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("63c3e8eb-c945-4d7c-a981-6feb48378daf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6592de52-5aeb-4ef9-b951-264cff8efddb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("66a20670-7065-43a5-a717-1b143d6d98a2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("681bb0e3-d23e-4395-92a2-eb7b6ba8674c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6cbe52b9-0481-4e17-b7f9-80f4a48b5221"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6f5b22c1-44a8-4528-b8c9-b724a28fc47a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("6fb30a01-f799-432b-ac50-1e8cba3814b8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("712b1935-103a-4704-95c5-3b29d1be50e0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("72583cb2-4e84-4ab1-946b-3552385e28be"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("74886189-628d-4197-808c-5368f995dbd6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("764fd442-033b-467c-9236-e684ecfa550c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("789d9569-b97d-4caa-b7a3-854b1cc7f1ac"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7968bcc3-cbac-4aa5-999f-fb3ea2b5bb42"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("79be1dbc-d84c-40c5-88ab-fd77a7d9ca3e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("79e34f9f-d96c-405e-b249-f65335ab1407"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7bb09046-9015-4c5b-aac4-4ea7e0270909"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("7dc0e484-0a4c-4e6a-9947-2b23470b6c1a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8115398d-becd-48ce-a181-43cc9f320612"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82a16275-bf23-4963-a1fa-c49f1bbea867"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("82a24a29-b1a2-46fa-b9b4-b1de289630ac"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8380b44e-095c-49e9-8751-16d2d6edde69"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8397ec21-e374-4028-b770-c0c1812d620c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("83c30bce-03ab-4c46-8861-5d77a089b7a9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("85e60eaa-e58b-4c60-8d34-b5862adb50b4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("86634c98-106f-4055-8467-dc4c2f64019e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8722ed2d-fc03-4017-8cea-f75feefd0fed"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("87c2089a-f679-43e7-a6b6-a6b808d7cbb6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("87e92b29-ffd0-4381-9e6f-dfd0438ca974"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("89ac32ca-4688-4fb0-a6b3-914f888811cf"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("89bda500-aa7b-4440-92aa-7eed2be402bc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8a672eae-fa84-4ab2-88b1-894138f7f335"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8b0f0ea1-c7a5-482b-9472-f279241898bd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8b201c2b-0660-4f31-8bb8-24b2fbde8356"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8c4ab7be-7771-4080-aef1-13f866fd5211"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8cab2aa5-3f69-4846-a92b-dc76e15aa4f2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("8fae693a-d6ee-41e5-a2e7-18ee5d5608d5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("903c7f5e-b9ca-4adb-9ade-a6e226992b04"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("96197a39-4cc9-476a-9155-52359183aa53"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("96e10204-cf41-4769-9f4e-cf44ec28fcee"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("97c205a0-52c9-4c76-80b9-0f0ee83727f5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("97d68677-7df7-46d0-959f-1b2035a18841"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9873fc98-8751-4c53-a768-a80dcd96ca9f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9a79fc87-549a-4ac2-b9f9-4c95314f533a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9ce9c927-2ba0-42ba-9fff-0eda834103ac"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9d2ff68b-dd41-4904-bb45-e73a73a2cd8a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("9e4c929a-71c3-48c8-b2e3-0391bcc93fae"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a0ad4c1d-6c1c-4637-b59a-e1a8d6696204"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a170b70c-13fa-48dc-9ad6-bebda8375574"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a30d9eba-9ca1-44a2-8919-aff6c9ccc34b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a337b8a7-dad1-4f9b-aef1-eaf42fb55c00"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a3713378-274b-49e7-99a5-8bf0e39bf7dd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a3c090fb-ffe4-47c1-8a88-62aa3266c666"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a5fd8493-2ef0-475a-86c4-bc95da897ce2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a74ff396-455a-4aa6-bed2-6155b7f85275"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("a8103cef-419f-4926-b4fc-d1616a15e1dc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("aabd74d7-618e-410b-b905-81a301508987"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("abd95e18-4dce-473b-b3cf-6fd2360056d9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ac6619ec-3f64-44f0-92f0-1a2195d0c194"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ad1ed4b1-0b38-4161-8ac3-deedd7caa1de"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b0ccf2b5-4238-4661-befc-882b4b82601a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b1e976e5-12ca-47e6-8cd8-2107111448f1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b228050c-1ab3-48e8-a94b-a35c44f6b73b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b304317b-c154-4a18-8a3b-375f97dc31ea"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b59612e8-59eb-4d08-a023-1e1101418b2a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b5a76591-6cc6-4474-91d7-afeb70261e20"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b6085860-4c9f-4b8c-8a5f-794f4631e2e6"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b86ca1c1-bd6e-4692-881b-dac8eb42f25b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("b90c775d-344c-4f93-ac1b-4e866e3ccf4d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bb946450-e7b8-40a7-9d1b-ec0f635ef5de"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bbe865ba-9cbb-48ec-a84f-f2c2e2c06529"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bc0e9ec2-fba1-4db4-94b4-e99ef6630011"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("bda5a9a6-3f47-48d5-b75d-f72c76a4efe0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c0877c61-307a-4a11-b612-390938637783"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c0fa1cd6-f0f5-4566-82b6-beaf1fe09411"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c32d616d-868c-4e8f-84e0-a1f6cf61442c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c360ed2d-826a-4529-ac3b-792b90dbc6c1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c8381f7d-c909-4239-9b0a-3547b3a3a6e7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("c86d5793-d348-4824-aedc-9f11004b741f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ca758267-f241-45a9-80f5-2204531dd452"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cac6cf4b-a703-4886-a801-12ac21453d90"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("cc26c3ca-b673-4b2f-ace5-736224eefeb5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d1988d42-de3e-4d5f-9beb-ac87f97b8ba9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d1fae315-4ce3-438c-bef7-4b9daa2ffd4c"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d3357a38-0095-440c-a971-05d537f04147"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d455cb4b-e7ac-43d8-9f37-f43e06e1ca3b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d5a293d9-a4cb-4f7f-b79e-5231b5e20939"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("d80d444f-a76f-4d13-a250-5185b0222c10"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dcc84281-a735-4bd2-9a0a-86ae944b13fc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("dd859385-2342-4f80-95ff-0f45dd87bf86"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ddccdeca-b1cd-463b-aecf-15dac42b9d30"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ddd0cf76-1b99-4d3f-bf60-f9e54f3d6bcb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e3f1450d-781e-4e7f-a069-90bc1c9ef96f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("e8ac6e49-880d-478e-90cb-07a725195380"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("eb6c397d-a191-4e50-bfa8-0b676f10852a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ee087437-95c5-498b-b510-a93f3c393cdd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ee5f29c1-3ee6-4762-ba02-a89032be8e99"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ef870c7e-0eee-47cb-a4e5-a88d577d2c2d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("efc8f93d-1299-4e8b-a08a-8ff92e667072"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f0d3225a-3d74-4c22-bfba-1ce8e55eb896"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f3caac07-9506-4f06-ba4d-adec3a8d6c06"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f40e9dea-e25d-4138-8b3f-f85f8b17e677"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f4dbd795-aafa-4f07-ab8d-a91e667712fc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f4e777af-68cb-423e-9ec4-4fbc1e4320ed"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f71cc678-e7c9-47a7-8c14-1ded30040349"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("f785b726-3b98-4120-a701-f622488184a3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fa6fa6db-826d-446f-9ca5-43d5579cb168"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fc274ddf-9938-43c1-a0e3-edb204e79802"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fc3be935-13b3-444c-b432-bb3709f34ab4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fd046c3f-0199-412c-87bd-1500e8b4bf77"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fd2c8a01-89b8-48f5-a4df-08c77d130cd1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("fde30345-c0b0-4f37-8f51-8ef9629d570a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ff46d9e9-7142-4e5e-91af-ab8dbaab6342"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Constituency",
                keyColumn: "Id",
                keyValue: new Guid("ff98ec44-67d6-4bb3-9094-82d3d81697b3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("01bf1b69-5de8-4a97-984a-9fb801b8b666"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2f22d5c8-3de8-4bd7-8056-0413ea888db9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3114027d-fe42-4589-82f0-4fd3f8b304d9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("32e38f44-9e40-45b2-82e2-ddaeec6b6e5b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("37e9bac8-bcc3-405d-91f0-5945be641a18"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3c0f1373-28d7-49e4-81ad-e5d6e81b89f5"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3f2b87d0-7613-4ed7-bc28-f92f9b350fbe"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5f6af2bb-7bad-42af-aafc-d311a77b84e9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("625d7750-a9a9-4619-a0c9-53b7b44d60e8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("654823fe-3fef-4ebc-a218-23c9123d292d"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("83fd0ae0-0bc5-428f-94dc-3a9b03fec8d8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("9c1261cd-6855-48aa-a06d-b30dc2d17df3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("bc2c889f-9af2-4fde-ac40-9e78bbbe81e2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c487c0ef-d780-4602-9c85-ddacea542743"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("0c4ff226-552e-42ed-b5ba-7d30d5d0210f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("3b9a8d1c-db04-41db-8a27-bae7260acfca"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("9f7707e8-feef-4cdb-acef-fc35cbad9a7f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("dbccecb7-ab68-4c29-92cd-6154f9c587f7"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Location",
                keyColumn: "Id",
                keyValue: new Guid("f9aeff2f-0a8c-4bcf-afad-083c6599bff3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("10a7353f-e170-4f05-ac2a-ecb32caf787b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("1d3f3c2d-b888-4ab3-84c0-1136204ce93e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("39be7a57-8e26-4f36-b321-0d6dcbfefec1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("3c8c400a-8120-41ca-8ce7-0e309bba49df"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("3db834db-4e10-4ee9-bb53-ffe3e57c3574"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("43caee12-7694-46c8-b1d9-74c442e686f9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("550ff1fe-6315-44bd-8192-8d752964e078"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("623e5ee8-66eb-4c08-850b-6838b5f7bb75"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("64f05cb0-832b-4f04-b0a4-6743d01bc4fb"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("6e581e10-b159-4eb7-9850-0038f58f3181"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("75e339d3-f254-421b-8f9c-fa4b77e2781e"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("80390b04-5435-4abd-81b8-ac3cf3afa47b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("84ff53e3-beeb-48b3-806c-173619712b8b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("8bdf3cd6-8563-44ba-9c31-13482ef3ef6b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("9ce75b5e-849b-4a30-a652-980dc20627c3"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("aa98dfdf-0ccc-4515-819c-ff342a110846"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("acd4fa15-5af2-4d24-a7e4-e890b9a5c347"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("adbb102d-533b-4422-abc1-c278495dac91"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("b913e14d-606f-4220-a96d-852330110150"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("dead6333-8f95-47f2-85c0-4885d151427f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("e7747a0f-f1a3-4976-98f0-77523eb0da20"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("ef92c30b-96f1-4b9c-a7c8-b4e4620aca06"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Service",
                keyColumn: "Id",
                keyValue: new Guid("f6da50c5-3a76-47b5-bf6d-e6c4d046d1be"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("0fcfa655-ba7e-419a-a935-653710e53894"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("115dcea4-49f8-4b28-b76b-34da65ecf846"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("2ba82e5a-7a84-4ebf-afb2-10fe21f94252"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("59ae4c9b-db76-4bba-98f5-d36bed3684a8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("d0538f8a-5f55-4c18-9638-227e41ad2734"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_Category",
                keyColumn: "Id",
                keyValue: new Guid("fa38823d-7054-4c3d-9b17-f7351a292773"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("022fbd4a-7bec-4d95-85e8-a58639195505"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("1783b984-3951-4264-9de9-2df75338007f"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("1a019351-0b75-4c26-bd5b-4b2a24307d17"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("21c6d047-ec0f-4285-a7bc-2bb3223d6628"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2635002e-62fb-43c9-ad4c-c5760b910ade"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2aff320f-dd4c-4020-87d2-462462bc811a"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("2db9b23b-c8a3-455d-adb9-ec1d8c9a3bb8"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("332d9dbf-2c8e-4da2-a27a-938fe275e917"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3746aae7-aac7-4fcd-8213-6e82447fbf20"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("3b2e88f1-044b-41ce-8ba8-6e4b9e0a2202"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("51f32344-e9cc-46a1-937b-ee976f84c8f0"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("556bf2d7-9206-4acc-8fc9-3d5aa9387365"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("55da7a73-71e7-437a-a578-738a63c6da42"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5695f52c-41a3-4253-8e39-36b6c7b51c87"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("5a44bc1d-dab6-4ad9-a91a-cf6d07409767"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6895f757-fb23-4746-b0a8-e3f2da0b15f9"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6ae1d248-65f6-4923-8f4c-2536340ea069"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6b62bf76-e92f-4715-93ab-dcd346070618"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("6fe5ac1e-e266-488c-905f-c84043dda638"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("89f7ad3b-15fa-4975-8f30-c2aa792fa029"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("b97dfb2f-eaa4-44cc-b166-01c1fe89bbaa"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("bf3de03c-0f0c-4b68-ab8c-2804b89116dc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("c6f27e49-dfea-4e29-a1a3-65a49e474dc4"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("cffd2db0-ae46-4794-bb35-912acca3555b"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("d0553bf7-53d8-4989-8c41-27cc925eef38"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("d38f0627-a4d0-4f34-b7c7-66b7da1d90fc"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("dc6b24cc-a2ab-44ee-971f-2a9f279b00b1"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e41b8771-84c4-4376-9e5e-e85af734aecd"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e56e070f-ca5e-4b82-9512-a798d8c993e2"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e62ccda9-9ad7-402d-9c98-87d14a388275"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("e99495dc-692d-43dd-b598-fb2a204d6957"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f0786368-59d7-4462-b09a-67fa076683ff"));

            migrationBuilder.DeleteData(
                schema: "sp",
                table: "SP_County",
                keyColumn: "Id",
                keyValue: new Guid("f1afbc73-7701-48a9-862f-9b250b559df0"));

            migrationBuilder.DropColumn(
                name: "ResetPasswordExpires",
                schema: "sp",
                table: "SP_User");

            migrationBuilder.DropColumn(
                name: "ResetPasswordToken",
                schema: "sp",
                table: "SP_User");

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
        }
    }
}
