using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubAPI.Migrations
{
    /// <inheritdoc />
    public partial class GeneralCodesChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("127c50b0-95f3-4ccd-af5a-b729e4b88d78"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("1ce021b5-1518-46eb-8321-30407f445070"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("5e8173f3-a1c6-4d53-a8cf-20469a50d245"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("892169a5-5194-4fb3-bff8-6a4e1b039185"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("aaeb865d-3b8f-4117-9fda-575a2a943c23"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("c464850e-9059-4c02-a588-2a5793b37b1b"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("ea2f9929-de61-47da-b465-7f1edaa5b051"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("fd1b0949-2190-44b8-aa9b-8b73aa8043cd"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("014e7c54-f872-44b2-829c-b6c852cd7af5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("068db146-ca2f-41a3-9941-aba1cee79830"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("06cba4bd-eb99-46df-b99b-783ff9d8f7b2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("0e9c9db9-5735-4609-8fe0-7480008d8af1"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("13528a60-f47b-4b11-9b70-dffcc90650d0"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("1fe6df7a-7860-4670-b39d-11a2d4ab7ad7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("21a0b93e-b81a-4dca-9a2d-97414015e992"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("25881f9a-0c87-4add-962c-de7be1d3a584"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("29751f63-4052-46ce-98f1-ff72841af538"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("2bbdd217-6a9c-4dfa-8a89-70e1d459ef11"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("3ad4a9de-361d-4f3e-8d14-4d874cd05c40"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("423872f9-9007-47be-b56e-c5f0227efcd6"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("4274ce66-7b53-411d-85d7-48583a054463"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("44abfb06-0f46-41cc-97a1-12dc026ff8c4"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("44d81ac5-a7ae-423f-9fd2-b760607a946a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("470871a0-e656-4fec-b456-e5a302ac11ac"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("4aeedd9e-fe0b-448e-9a69-85567599fd98"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("4bd6b648-8db6-4e0a-bdcd-4876fe5215d8"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("531df614-869f-4c3c-9d93-74eeed98d2c8"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("54471b42-ea7a-40eb-b5f3-0af46123f677"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("572d0365-8bda-46d6-9f3c-54937028924f"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("5ad59e44-8192-4f88-a9e6-52a9282a7cb3"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6509f969-8057-4a86-b3e6-d3c01e418fae"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("673d8930-284f-4207-a633-224ecb8da946"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("683951d1-e153-4093-a496-7a3d7263645c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6953377e-ff19-4d38-9220-816fd1311f04"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6ae11b67-a2a3-457b-98d0-ab1f1a2f2e23"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6bbfb87a-cc3f-4f01-bec9-b0c5f8e8f118"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6d147227-07fe-4563-bf46-6735fe5a5f1c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("73bafe0c-fea6-44ba-9dc8-3524c11791e4"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("757dc3cb-be23-470a-bbcf-e115e35cd96a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("76e79712-edbf-4f2c-b8f2-5d3e6e426324"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("7944278d-9be5-4517-af95-49f6edd706d5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("79cda6aa-5794-4a72-b70e-7435fd3e02d7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("7aefcfc0-dd23-40a6-ae85-92574deb2a4a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("7bb7fdbf-e2cb-479f-8456-4a8ba5c9ade5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("8133624e-c677-493c-8403-fd4bbf9153e5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("8239e143-d0a7-4b5e-91fe-cd82f46c5172"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("82eaa885-a102-41c6-a898-54192fda2405"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("8484d3e0-3fb9-408c-a887-30c02432c965"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("84a89810-a620-4270-9e25-b09b5424f55c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("84c02d9f-e7ca-41d3-b3dd-e365af48053a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("85f5f1b3-606c-479d-ac8b-2bcc8b443992"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("88c42880-5798-4ee0-a47d-c762cf70c8c7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("910cb786-3f3c-4fa0-94a2-a1e87f742249"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("953b356d-56e9-426e-857f-b7a96f38e193"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("96c1960b-c3ab-4659-84b2-5bd83cfc6520"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("985e5d0c-8de2-4c39-b083-6ae9b2d22290"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("99e9c462-f1c5-4d6e-9b28-c23e36d7531e"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9ac55f18-5940-4ecf-9345-425a3dfd4ca8"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9b8c4984-aa9a-4c9a-96b2-19926728aca3"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9bc61c09-c743-45aa-b080-69cd299fadfa"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9c2c90e7-0f02-42e4-8206-0d65b39cf4a9"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9dc91991-c30d-4df2-87d8-23ce11f99916"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9e1a2b80-b5b5-4818-91ee-8974bebb1e63"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9ebf83fb-5706-4495-870b-89993d6cde36"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a656be68-1b0b-4708-8374-608783b2b20b"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a74a894d-1aa0-41db-8edc-266c7d4e2166"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a8ac35be-bc9e-4c18-8b56-e2f4f23c656a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ab378d74-29d5-4f28-b44b-d62c132073d5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("af954ef5-9503-46bf-b0c9-d957fdcc2da0"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b355548d-77b3-458d-bf3a-9ccb0aadb294"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b36e9b3f-6760-4f3d-b6a7-16e935e258e7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b3d3c54d-b8df-4a9d-b633-c63ba02a1091"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b3de94ad-1ddf-4475-a650-7c56e8e70eaa"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b48ed898-dc22-4889-aac2-06bf2e09fc0e"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b7f13ed4-c5e2-48e7-bf6d-acf7f3525a67"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b8073380-6363-419f-adb6-61b55f70e19f"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ba50a91c-3684-4f5a-8f52-7907bab29943"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("bc5a0d65-4cb7-4a2a-8355-ecfccbd88f1a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("c3e904b4-196e-48cb-9df3-eb153d916440"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("c7887a3b-cc40-4f0c-880d-adcdd775f1eb"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("c92608e6-1f90-4fd2-978e-0a488b9ea71e"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("c9e72297-bef4-4a96-beb7-4cb72726793a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ce50713f-cdac-48fe-863a-35d502f26dbb"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("cfbd065e-8a87-465d-a50e-2501f2b6b166"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("d561339d-ca59-4ba6-9393-97e6772cbec2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("e212265b-f883-44f1-96d4-7ee5475f2cfa"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("e507b0c4-0600-4ba5-aee3-270b3e12d109"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("e7738fc7-5229-426c-a330-277b63b301d2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ea06e3ec-0aaf-4f52-a160-7a60f4d1b1b5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ea6d1ee0-5b85-43a1-a81b-ca97a687349d"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ead8eb5d-565d-43b9-b3ad-1a9828dd2711"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ec46a654-4f17-4a1d-a71f-6f5b58b63af7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("f10c4934-22d4-4926-80e6-885b270a861e"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("f4ccc50b-253a-4f2c-b4ef-7d178a90f29a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("fb2a0894-d45a-413e-924e-ae3a3c7bff1d"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("2fd40f35-a9d9-4940-909a-9b113803a834"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("50904027-59a8-484a-95fa-e613aeea51a3"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("67484eff-1864-4a26-b5b1-34ebb9a68bf1"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("7ac5674c-c3a0-4610-92fe-14189e54c2bb"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("82630ad6-e01d-4cac-b113-44a1b8f993c1"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("fcbf248e-f616-473a-93ab-e0cd02292a35"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("feb59821-1e5c-4248-ad7a-b7b3a175eb5b"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("009541de-d482-4522-9fd0-b22c2c872bf0"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("06dcf5cd-0a3f-4f96-9eb9-56f0190c53e3"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("07240bde-4e8f-4ebc-ac27-54502500b5fb"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("10d447e0-1185-4cbe-852d-34ace2b4bb76"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("18cfc55b-c89a-44e6-a4b4-0d116dde5096"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("18da8b77-bbd0-4f97-965e-610339b088ed"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("1a715319-6bb5-4ef1-a332-55280e099894"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("24c418e7-86d8-4834-82e3-19ec2e4094d4"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("267bbbe3-a007-4478-8965-7d0646a37c20"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("2958e058-f4f7-487c-a2fd-ad088903e2f3"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("29c38916-a083-4cba-8260-0baa7517a782"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("2eea0440-d110-430a-90bf-6d6798595898"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("3722ac05-4590-4c91-8958-488850847ff1"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("45378d93-09d1-4a63-91fa-48cbd416f0a9"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("46f9a402-6504-429f-b8d7-c6d9a5baf0a8"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("4d115be2-fde6-489d-869a-e54337df436e"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("525820bb-6a1d-4875-8824-59dd00ac1412"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("5e1df4ff-fa4f-4d06-bbc1-e40639ab5374"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("634cd61a-7a14-4a29-9816-c8274de8be71"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("636a12f7-5b0a-404c-8485-5ed677716e71"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("6c3dd9eb-6000-4469-8795-8b680edcb80b"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("6e9dfb6e-f153-4958-8213-143f633cc14c"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("7536bc70-8ac5-4728-9a4f-59124aae6293"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("778e620b-2c3a-4b08-a799-f97674b164a5"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("82bd8a78-940f-46ee-a240-85de6a76de4a"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("82d4e3b6-fb60-4719-b529-5c628e27ff4f"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("93e45f77-9914-4e17-abe4-2122d85ce7d6"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("9844498a-33c0-4ca4-a605-25c3f228000c"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("9c381cc6-8344-4314-9437-bbeb11a81291"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("ae8d5e41-9a1f-4920-a117-eb8b0de7e525"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("b88b57e3-9cde-4a75-b06c-95d7947b0053"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("ba1ec23c-3c49-4ec7-b5c9-91150334b87c"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("bdbbe8c9-f77d-4ad7-b193-706ebcc39616"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("c814befe-1fd2-458e-86c1-4c9c1dd4c793"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("cdd40b00-6995-4a1f-9431-4645ed7d1cbb"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("ce36d38f-13b6-4d6f-bf97-32dd1b29c6fa"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("dfd2e4c3-6581-4e2d-829b-ad74a3363ce8"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("e01e75cb-e663-4728-8e3e-f99d5916c350"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("e0a69a1b-25f4-4f81-8078-4f5b90f0bdaf"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("e226e5ae-59a1-4c97-a48c-d9a5cc945018"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("e9a6ff1e-5ee2-4d6e-94ec-826ada54534c"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("f51dd3e8-3c98-4017-8aa0-62a3a2c1e594"));

            migrationBuilder.DeleteData(
                table: "genderCodes",
                keyColumn: "GenderId",
                keyValue: new Guid("38eff8ef-adb0-4b2f-85a3-f37164fb2ce1"));

            migrationBuilder.DeleteData(
                table: "genderCodes",
                keyColumn: "GenderId",
                keyValue: new Guid("a01bb913-31c8-4e5d-848b-c9e288310a3c"));

            migrationBuilder.DeleteData(
                table: "genderCodes",
                keyColumn: "GenderId",
                keyValue: new Guid("b6cacf0e-eec4-4b08-a92c-9359d287cf36"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("0783984f-b961-454a-aca9-442ed5369fa9"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("0a2dd510-285e-456e-81ca-0258160d2f2d"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("0b46df92-a8c9-41ff-8cd3-dd67ccdb3537"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("11560d59-b426-4147-a24d-6af60525e7d6"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1358577c-2be9-40de-87c8-9c07c4828f11"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1cc344c9-8f3b-4fae-a050-ee48a4be3948"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1cd19904-a616-48e2-a2ea-54ebc583bc19"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1cefb3a0-6939-4b7d-a87c-bb0841c801f0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1ea2e84a-74f0-4eb5-b7a3-699e7a623671"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("2923f60e-e820-491a-9d8c-b230822e2398"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("3f06b295-ccdd-4503-b794-b84f89c85575"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("4559f67d-d1b4-4416-98dc-2824f3ea125b"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("4baf9798-396e-4267-8475-6b9ef519707b"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("4bb8ba36-0b44-42ba-8a8d-7a86e5f83e14"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("537e4c22-d1c9-49bf-ab45-03c369094ed3"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("57eb5078-3a41-4771-a8a7-5724de11e7fd"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("5af163cf-4257-4630-80ca-6ab58373d773"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("5b19aa4b-2fa2-49fc-b1cf-108173460057"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("5b232db8-9ef6-4dc9-997d-c62754461a26"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("5cd941e1-f8d1-4cca-a002-ba1c7de1f9ae"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("5e105c5c-c2cd-4aa8-9772-fe19a0b3b409"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("66cfa577-ed8f-4722-adf7-a2a3764263a5"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("68f28c85-cf7c-46a0-8e21-41f6654ecbea"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("7a3abca0-e4db-4bed-91de-5074cbe745a0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("7b7ad2e3-1763-4b4b-ba34-b23a42b56cd5"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("7f1d7c8b-b9c1-4d5a-b7fd-4107ea1cba8c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("82c9b89d-ada7-4c2e-b062-d255aa6d81f6"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("84ade46d-4349-45e3-9949-a8ba5b30ec4c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("8845c82d-c9d9-420e-b48f-f8936194bac2"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("88a57bb9-ebf8-4b00-a48d-5ce7f64b6093"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("8cae9526-edd6-4b6e-bf74-7f9c0f5c42c8"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("8f2b6104-b509-4803-96f8-63a0deb1b25b"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("90a34396-44bf-4b4d-8dae-3414e0acbc29"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("92c1a1a9-68fa-4782-9ab1-9deb54b354a0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("94c21495-3687-49f4-bce7-6baed26d1d16"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("95c4a099-bdef-4aad-8c1d-a179f0e14252"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9bfbc900-9521-4882-b556-389d9b97f0b6"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9ebe15a5-5cca-49e3-b961-b08ca7614c10"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9fa16568-9d27-4da9-893c-e97a8469b592"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("a01494dc-472c-4dc1-a307-e2bc3e41bf8b"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("a62afa78-f26c-44a2-bc09-5ee8daab2f8c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("aa53f520-4cc5-453b-a480-e1dcf945370e"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("ac31dc5a-3b54-48b2-a613-e45eeafdaf6f"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("b3bb4e81-d128-445d-af31-58c71ff196b6"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("b7a359a8-68ab-4d05-b8b0-2398d643a98f"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c20b3336-0e26-4a05-87c3-cc8ee5cf86e8"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c25447e2-ed26-4505-b1ee-db50d7428596"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c255ac95-1f88-4b6d-ad15-3097182f867c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("d48d7dae-032c-461a-a85c-6890128b24ba"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("d4e60bf8-3e9b-4340-a400-e78bc5021544"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("d828e2b3-09a7-4a72-872a-5819deffafb6"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("e2c1868e-a240-4f8e-9e90-0f8d89060005"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("e4e1cb9d-137a-4c2f-bf80-275418caf551"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("e8092075-ee75-43e8-ae85-ddcb56cc999f"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("f7d52487-9c6e-443e-93c6-8b2bddc592ed"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("feadcab5-94cc-4a12-8229-a0df3e1e24f3"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("0ea4f976-1178-482d-818c-81edb1cd7184"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("3beffca8-e182-486e-82ad-1bb89bd6142e"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("c39918dc-ee43-4d6d-88b6-9e13f338d9a9"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("d1a67026-f19c-4521-ae7b-4cf2a425f20e"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("0e907e7a-e30e-4ad7-8335-54fea461958f"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("1b3cecc4-cbab-40b2-9eb6-f6fd4ee32adf"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("6f96f34f-c1ab-4fcb-83cb-503ab24d912f"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("84f2e487-f82a-4a67-8cf6-4475fa29cbd4"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("958ddaeb-3f45-402d-8000-84d7b0cf9e37"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("a9e48d2c-99e0-46cb-8105-e24c2d684508"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("13e9c482-421e-465e-88e0-1a36bec29b83"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("6b80e1fe-be90-480d-869b-5d0efaeb4b61"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("85422937-2c0b-4a90-8a9f-3a842b573b03"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("b56380cf-662f-4d8f-87f3-180b4b12aac7"));

            migrationBuilder.DeleteData(
                table: "religionCodes",
                keyColumn: "ReligionId",
                keyValue: new Guid("4e11b66c-8c42-4639-a91d-6b8d83d86cd7"));

            migrationBuilder.DeleteData(
                table: "religionCodes",
                keyColumn: "ReligionId",
                keyValue: new Guid("5ee4ce09-ff48-4127-88f3-2ecc9d832f0a"));

            migrationBuilder.DeleteData(
                table: "religionCodes",
                keyColumn: "ReligionId",
                keyValue: new Guid("ea0a357a-a5fe-4310-a219-0edcd3aa8430"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("0371dad7-0d20-4661-9ec3-593b17b16117"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("05e86262-b9cf-41c2-8d16-32d0eb1fa1e0"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("08bc35d3-b658-4e36-ad8e-41e8ea8111b3"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("0dc94d17-605d-4e98-9cbf-02cc82287061"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("0ee39414-b979-4793-975f-3fc8bc3ddddf"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("170703ed-3503-4f5b-b8b4-f9142176e12d"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("27c56576-9e45-4d33-b012-29e89b2796f0"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("2ac92fb5-a0bd-45cc-a6d2-eb7cc28ae2ba"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("2bac4d63-cdd8-471d-bd6c-312c4fb388a8"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("2d580936-44d0-46bd-b80d-9647c49ee1ca"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("32792757-c916-4567-bff5-f67ee2fa33b3"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("3a802710-2ae0-4803-9630-9c1761cc7cf9"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("41ec20d0-c492-4b93-afb3-d2ffa543ae2a"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("45d9fd16-892b-4575-baf6-e98cc54d6a27"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("46a3ca2e-54fd-4d17-b41e-99880848809b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("46eb5f88-f222-4f6e-b1b4-667c35ce71d6"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("4a785eeb-0b0e-43a5-b8cb-d017f3830781"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("4d86058a-8d38-416d-aa09-d5690579417c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("57b1ee02-116d-44fe-897c-ded5b31e4867"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("5f2d0008-39e9-4868-8dc2-7c18af14c386"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("621dc6bd-d113-4721-8505-6fb81b1c0a26"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("650cc4a7-0415-44df-b93a-c70a00fa74ed"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("689cd469-b920-438b-9778-1064c71a19ae"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("705668f0-b995-4779-bb4c-5a4a37919872"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("74153a71-74d3-4083-b90f-df2d716b11cd"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("7838f77f-a101-49c9-b8b3-4f4a611d3992"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("7cb2dfe6-d214-42a0-a639-a9e626ecbb1e"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("80f821ef-0eb0-4611-870c-f50f10fb225a"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("83cb08a0-f618-46f2-bf2a-47ff40a83ce1"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("841a2a53-f8cd-4d26-882f-8c968ccaa53b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("85a3c64a-6106-44df-837c-c712c5a12385"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("86f5ea25-dc44-402e-b3e9-a4bc6aa12d3d"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("88551076-4e79-4ebe-b13b-1f44a835d34b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("89080a94-5f0a-46cc-a416-3bacb51044c4"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("8bfc30c7-3bd1-4e4c-8205-d6c5608bd14b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("8c12a4d5-bd28-472d-8b3a-8750745975b6"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("8e9cdf45-c951-4076-9608-4e34eb874b7e"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("9419207d-c4f0-4cfe-b368-065c6edb69df"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("95067bb9-b07e-4cb5-86d1-d14a531f072e"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("96728ab8-ed48-4ce2-8faa-6a540859b23b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("9e39bf4d-4101-4fcb-9ad6-9cb9ca2cecca"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("a103fd87-4679-47f9-b962-f23c8ecf4000"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("a6dc5b48-67db-4a26-9205-3cb8ea5f4a68"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("a72bb318-c83e-4fe5-89fb-2d91262f38dc"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("a78e1059-8d0c-4191-93d4-b009658d5ced"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("aa89b371-c234-42cf-80a2-99911c60a7c6"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("ab3a8eaf-4292-4be4-89df-35cd47de7a29"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("ab8a6f4a-34aa-4ccb-a1c5-db3e8ced6ff4"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("b18675bb-934c-4a71-a399-4b5ccfdf836e"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("b5c656fb-d338-487a-b79c-9b2a94d13b9d"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("b8211d60-24de-413a-81db-307f744d02c3"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("b9994ccb-2ff2-4300-804d-3f4a85642596"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c0126381-e254-4f76-bcf3-589dcb03357f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c02c704d-a475-4be0-88ea-f66cfcd0aa5c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c409cd9d-49f5-4aa2-ac2c-b297ef773b2c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c610f69c-bb44-48fc-b3b6-ac0355f5dcb2"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c73d30f4-4908-4a1a-ad13-405c8f5cf993"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("cd62f919-1901-4e11-8983-cf61e7ae2911"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("d5e0c048-d78f-43e7-b811-eacf90569a11"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("db94ee0e-5756-413b-8a3d-7f501a9bbb51"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("dba99fe3-5006-4cd6-838b-46f47ab99b24"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e67fe84d-2952-4ec5-888d-41cb9e5f566c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e7b2e57f-d401-4a28-aa45-773c3a0307cd"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e829b8d2-71f0-4e30-8b64-b961d81a379f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("ea8ad93d-9816-411f-b75f-27172f3263a3"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("efc2d9dc-e0a4-4897-bd65-6c366cd0d0cf"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("f0d48b5d-0ba5-44dd-b8d2-d26cc9e3960d"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("f4056bab-7e63-4c07-a0a4-1c4485dc07ea"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("f52bbeb6-e0e9-4b18-8da3-1911acf83cfa"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("fe7b823e-914a-4d16-943d-e0af65299c66"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("ffcd9db6-e01f-4239-a340-3e70c3ab5d2f"));

            migrationBuilder.DeleteData(
                table: "titleCodes",
                keyColumn: "TitleId",
                keyValue: new Guid("118bc7ee-d5d0-4b08-98a8-0bc51494f4ba"));

            migrationBuilder.DeleteData(
                table: "titleCodes",
                keyColumn: "TitleId",
                keyValue: new Guid("95f32e89-54d4-40fb-a61c-4b2c11a35043"));

            migrationBuilder.DeleteData(
                table: "titleCodes",
                keyColumn: "TitleId",
                keyValue: new Guid("da0b2927-37f0-4bd8-9038-75662ea78bbe"));

            migrationBuilder.InsertData(
                table: "QualCodes",
                columns: new[] { "QualId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0beae64d-1c92-4783-aece-539656f2ec40"), 300, "محامي" },
                    { new Guid("596bdbb0-584b-4fc8-b1f3-1cfa54998b40"), 5, "بدون مؤهل" },
                    { new Guid("7af6d34f-db0d-41c2-80c5-8ca7a17cc206"), 3, "مؤهل فوق المتوسط" },
                    { new Guid("8c5ceb84-fbc7-4581-9ac1-86bb2446dd72"), 2, "مؤهل عالى" },
                    { new Guid("aa1a0d93-8924-46d9-9cbf-5ca3a101eaac"), 4, "مؤهل متوسط" },
                    { new Guid("aab97268-1eda-42c8-ba83-24ee745df96a"), 1, "مؤهل فوق عالى" },
                    { new Guid("bfbe1e65-6127-4151-b719-c52c9695355a"), 6, "طالب" },
                    { new Guid("deb5c556-07cd-403f-aaa5-5835db300c5c"), 7, "طالبة" }
                });

            migrationBuilder.InsertData(
                table: "RefCodes",
                columns: new[] { "RefId", "AgeFlag", "Code", "Name", "RefFee" },
                values: new object[,]
                {
                    { new Guid("01b163c8-2ea8-4f9a-88a9-5780b4d0e0c3"), false, 3, "زوجة", 15.0m },
                    { new Guid("13b6bbe5-8739-4515-8b76-a20a9cbe5abd"), false, 59, "عمه تخفيض", 11.0m },
                    { new Guid("13d5c03e-b7f5-447a-8027-1945a0ff93e7"), true, 52, "ابن اخ تخفيض", 11.0m },
                    { new Guid("1c470b33-8b59-44f0-ab71-a82ce74d8428"), true, 15, "بنت اخت", 22.0m },
                    { new Guid("1c4d8983-2bf0-4c84-81fa-3404b4ee64e4"), true, 14, "ابن اخت", 22.0m },
                    { new Guid("1e99b411-db24-402a-beaf-910419924e38"), true, 53, "بنت اخ تخفيض", 11.0m },
                    { new Guid("22a53004-a7e1-4559-8b33-b4cc83429e6a"), true, 80, "أخ الزوجه تخفيض", 11.0m },
                    { new Guid("233e7488-57a6-4bcf-bb66-a9e2b27a39a0"), true, 27, "بنت بالتبنى", 22.0m },
                    { new Guid("2e27b8d9-0e6a-4418-b08a-fbcd59ebb509"), false, 41, "والد تخفيض", 11.0m },
                    { new Guid("35c56d49-502d-43bc-8860-a4d667e8dcdf"), true, 50, "اخ تخفيض", 11.0m },
                    { new Guid("35d4cb2a-7b32-439a-bdd8-f597b2736bc6"), true, 74, "ابن الزوج فوق 16 تخفيض", 3.0m },
                    { new Guid("379436fb-04d1-43d3-9bac-2fa378220d4b"), true, 61, "بنت عم تخفيض", 11.0m },
                    { new Guid("3a290d93-40ea-4d52-9a01-4f5f7538ecec"), true, 20, "ابن عم", 22.0m },
                    { new Guid("3c4cb539-a0ca-43a2-be23-1f26e91afad8"), false, 85, "ابنه فوق 25 سنة استثناء", 22.0m },
                    { new Guid("41b43e56-7ee0-46c2-a78e-e127ed87a9d4"), false, 71, "ابن الزوجه تحت الـ 16 تخفيض", 1.5m },
                    { new Guid("4218c8be-239e-4364-ba06-489caa274fd1"), true, 64, "حفيد تخفيض", 11.0m },
                    { new Guid("42832812-6581-4694-a56d-ed507de6dc8f"), true, 45, "ابن فوق ال 16 تخفيض", 3.0m },
                    { new Guid("42f1f9a8-0fe2-4b66-a9b1-dfbadf71fe06"), false, 51, "اخت تخفيض", 11.0m },
                    { new Guid("48d672fd-c7e5-4a55-a100-b4d9324d28e5"), false, 57, "خاله تخفيض", 11.0m },
                    { new Guid("48feddec-1c4b-4f45-828c-b058f547025c"), false, 40, "ابن فوق 25 سنه استثناء", 22.0m },
                    { new Guid("4be9cadf-4e35-44f3-8cb0-bd13edec58a9"), false, 18, "عم", 22.0m },
                    { new Guid("4bf83cb4-59eb-4155-b91d-d264e3e9df02"), true, 82, "اخ الزوج تخفيض", 11.0m },
                    { new Guid("52744c05-5f63-4fcf-94c1-4c74d3109f38"), true, 78, "بنت الزوج فوق ال 16 تخفيض", 3.0m },
                    { new Guid("535dc9c3-c8dc-4c01-a070-fd920865ec9a"), true, 13, "بنت أخ", 22.0m },
                    { new Guid("568fdcae-b169-4e25-8a60-72ffca3e882d"), true, 36, "اخو الزوجه", 22.0m },
                    { new Guid("5ab970f0-5e7e-4ec6-8470-aecd908b6b87"), false, 87, "ابنه فوق ال 25 استثناء تخفيض", 11.0m },
                    { new Guid("5db17be9-c102-4f78-8d96-b685b8154fa8"), true, 72, "ابن الزوجه فوق الـ 16 تخفيض", 3.0m },
                    { new Guid("5f3d86bf-128b-4578-b505-c4afaf417dff"), false, 56, "خال تخفيض", 11.0m },
                    { new Guid("61cef87b-fb3a-44b5-a269-fde74d4f3eff"), false, 46, "ابن تحت ال 16 تخفيض", 1.5m },
                    { new Guid("652d0dbb-e5f0-4bd8-ab9a-e21071d6c398"), false, 16, "خال", 22.0m },
                    { new Guid("67f5b46d-d298-4ce2-9a49-a3e995797bcb"), false, 70, "زوجه محاربين قدماء", 0.0m },
                    { new Guid("6a01962a-3942-424f-a962-c9b70b03592c"), false, 69, "زوج عضوه فوق ال 60", 2.0m },
                    { new Guid("6a1b402d-5f9b-46c5-800a-684a30a467a5"), false, 4, "زوج", 15.0m },
                    { new Guid("6bf60b39-ef4c-468e-9518-75c9cf5aa3b0"), false, 79, "زوجه شباب ورياضه", 0.0m },
                    { new Guid("739729e3-969d-456b-8f85-16dab8663b9c"), true, 12, "أخت مطلقة", 15.0m },
                    { new Guid("753ffc0b-8710-4b0f-a4f3-806cf95dd5c8"), false, 68, "زوجه عضو فوق ال 60", 2.0m },
                    { new Guid("757ec334-555b-4734-9484-3245acc12776"), false, 37, "اخت الزوجه", 22.0m },
                    { new Guid("76a6573f-6a10-419c-8049-f53a1eb41ad2"), true, 67, "بنت بالتبنى تخفيض", 11.0m },
                    { new Guid("7b7a17bf-9423-498b-832c-bffe59c55531"), true, 22, "ابن خاله", 22.0m },
                    { new Guid("7db56418-3d84-4612-a34c-1fc4686fddb2"), false, 34, "بنت الزوج تحت ال 16", 3.0m },
                    { new Guid("801d1693-d747-4267-ac8e-c7c42edea9b3"), false, 43, "زوجه تخفيض", 4.0m },
                    { new Guid("8124eabd-83e7-4718-9552-744745496eb5"), false, 9, "زوجة ثانية", 40.0m },
                    { new Guid("859a48e0-7559-46f3-ab53-e97de3124b42"), false, 1, "والد", 15.0m },
                    { new Guid("87e6163b-cbe8-49d4-a5ed-ac47446c86bf"), false, 28, "ابن الزوجه تحت 16", 3.0m },
                    { new Guid("89c17bb1-c78d-4223-9ff3-376a37f6fd9f"), false, 58, "عم تخفيض", 11.0m },
                    { new Guid("8c316aab-6b88-44db-a72e-a4afec71aaf7"), false, 32, "بنت الزوجه تحت 16", 3.0m },
                    { new Guid("92bc20be-9831-42ad-9a3a-9775b5d144e2"), true, 24, "حفيد", 22.0m },
                    { new Guid("94c30c3c-e662-4abe-a9dd-3eeb6147dbfc"), false, 10, "أخ", 0.0m },
                    { new Guid("95c182ac-948e-47f4-bd62-0db6000ac2ad"), false, 44, "زوج تخفيض", 4.0m },
                    { new Guid("972d8c71-e2a8-4d27-b947-aae64e52fb14"), false, 49, "زوجه ثانيه تخفيض", 11.0m },
                    { new Guid("9900b3c0-ee53-41ee-b81f-cf69307e3700"), true, 23, "بنت خاله", 22.0m },
                    { new Guid("9d3c82b2-0d18-4915-ac37-e9a0b0b0f78d"), false, 75, "بنت الزوجه تحت الـ 16 تخفيض", 1.5m },
                    { new Guid("9e83130e-d217-49a3-bf22-db10d8028fcd"), true, 35, "بنت الزوج فوق ال 16", 6.0m },
                    { new Guid("a06e2175-cc4d-4736-9a59-4024f9a74393"), true, 66, "ابن بالتبنى تخفيض", 11.0m },
                    { new Guid("a4337818-52a4-497f-860f-1ac8b45ca098"), true, 55, "بنت اخت تخفيض", 11.0m },
                    { new Guid("a63dbbda-c48a-4671-988f-74866c5bb2b9"), false, 19, "عمه", 22.0m },
                    { new Guid("a68edccb-422d-42ba-80aa-fabddc42d8b3"), true, 31, "ابن الزوج فوق ال 16", 6.0m },
                    { new Guid("a8451aa4-77bd-43c0-b2eb-5349056a3cf1"), true, 33, "بنت الزوجه فوق 16", 6.0m },
                    { new Guid("ad1f06fa-739c-424f-b681-b25fa7c5fc74"), false, 84, "زوج عضوه شباب ورياضه", 0.0m },
                    { new Guid("ad91b037-41b2-4a67-8de4-b392107ceb16"), true, 60, "ابن عم تخفيض", 11.0m },
                    { new Guid("af0e6b5a-9424-4ea0-9575-afc18495873d"), true, 63, "بنت خاله تخفيض", 11.0m },
                    { new Guid("af6eefd7-7846-489f-a40b-ad18ee7dc92a"), true, 76, "بنت الزوجه فوق الـ 16 تخفيض", 3.0m },
                    { new Guid("b08c1c2a-3715-4e7e-aeb4-822453c4bb76"), true, 38, "اخ الزوج", 22.0m },
                    { new Guid("b14e9255-aba4-4563-80c6-f1965a9bed7d"), true, 65, "حفيده تخفيض", 11.0m },
                    { new Guid("b2a63c73-6248-4b0a-b056-b5aefcd0bf94"), true, 21, "بنت عم", 22.0m },
                    { new Guid("b4da4b07-4a10-4e33-8b8e-3c757542bf74"), true, 26, "ابن بالتبنى", 22.0m },
                    { new Guid("bbf47344-2d91-4560-af8c-b69049b4dd4f"), false, 73, "ابن الزوج تحت 16 تخفيض", 1.5m },
                    { new Guid("c25fa2ea-43c2-4877-b523-63184119be0a"), false, 11, "أخت", 15.0m },
                    { new Guid("cb0e23ba-d98d-416d-a80a-de77a63306e4"), true, 47, "بنت فوق الـ 16 تخفيض", 3.0m },
                    { new Guid("ce3f1212-776c-4a2f-afcf-b6fcbaa7869a"), true, 8, "بنت", 10.0m },
                    { new Guid("cec7b3c3-92b8-4cbf-8b41-f709a78f9284"), true, 6, "إبن", 10.0m },
                    { new Guid("cf3f04da-5105-43ca-9956-9c83c3f314c3"), true, 54, "ابن اخت تخفيض", 22.0m },
                    { new Guid("d1122e52-5f88-49bb-949b-7578b40826ec"), true, 5, "إبن", 10.0m },
                    { new Guid("d5157858-7f7e-4f3c-89ff-dd04629e07f4"), false, 17, "خاله", 22.0m },
                    { new Guid("d90c802b-7311-4fc2-9be2-6e715fc238d0"), false, 48, "بنت تحت الـ 16 تخفيض", 1.5m },
                    { new Guid("d9871098-0ec2-4428-9065-23e4efb080bf"), false, 86, "ابن فوق ال 25 استثناء تخفيض", 11.0m },
                    { new Guid("db2a3b82-a592-400b-a58c-56feed94dabf"), true, 62, "ابن خاله تخفيض", 11.0m },
                    { new Guid("dbaafd52-658d-411e-9bb0-34e52439afd9"), false, 83, "اخت الزوج تخفيض", 11.0m },
                    { new Guid("e22d8941-25ce-4721-aef1-1f0a82dc6559"), true, 7, "بنت", 10.0m },
                    { new Guid("ec974e7a-4b5a-4684-8d2c-6729c3fee1a5"), false, 30, "ابن الزوج تحت ال 16", 3.0m },
                    { new Guid("ef9621ee-0ebc-450f-a923-2e718fec96cc"), false, 77, "بنت الزوج تحت 16 تخفيض", 1.5m },
                    { new Guid("f0baa4a3-fd33-45c9-868b-53b850e26a01"), false, 39, "اخت الزوج", 22.0m },
                    { new Guid("f434e51c-0f81-4c1e-a08d-2a4d2ad7b97a"), false, 2, "والدة", 15.0m },
                    { new Guid("f803c2f5-db87-4d4d-a82a-1300164e5834"), true, 25, "حفيده", 22.0m },
                    { new Guid("fae9ecbc-9ae3-4dee-8a78-a36aefb28e67"), true, 29, "ابن الزوجه فوق ال 16", 6.0m },
                    { new Guid("fdf8d19a-53ae-4a39-8eb9-a6882894ebf2"), false, 81, "اخت الزوجه تخفيض", 11.0m },
                    { new Guid("feecbbd0-f4dc-4761-bb04-0bb669563e62"), false, 42, "والده تخفيض", 11.0m }
                });

            migrationBuilder.InsertData(
                table: "TransCodes",
                columns: new[] { "TransId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0d019147-312c-45f7-829e-f15ce5bd6215"), 7, "طبقاً للائحه" },
                    { new Guid("2e6e84e0-34d7-49aa-9ad7-c28b6f5372b0"), 2, "الزواج" },
                    { new Guid("7d41e4db-a9d3-4af5-b4e7-673879e143d3"), 3, "الطلاق" },
                    { new Guid("81c75da6-9580-467b-8efb-1d48c22da2c9"), 6, "بناء على رغبة صاحب العضوية" },
                    { new Guid("9bd7c534-39b5-4bd4-8444-4063594e7700"), 4, "الوفاة" },
                    { new Guid("d60606be-ef3c-415b-864e-3ab7371ac4df"), 1, "بلوغ السن القانونية" },
                    { new Guid("d9839bc1-d6d6-4738-b1e2-0ef1a0eda58b"), 5, "التخرج" }
                });

            migrationBuilder.InsertData(
                table: "cityCodes",
                columns: new[] { "CityId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("027b3e9f-a5b6-44f3-b3a5-60ac8d1863b9"), 27, "الوادى الجديد" },
                    { new Guid("0798ec22-f3e0-43cf-a91d-c1d64462e862"), 15, "الفيوم" },
                    { new Guid("0e1033b3-cab3-4c07-af38-c8a5874c65ae"), 42, "القاهرة" },
                    { new Guid("14887124-afe6-49f4-8c53-8cb2cf554d34"), 14, "بنى سويف" },
                    { new Guid("19d12cdc-a9dd-48ae-9776-0f5a9991ff29"), 9, "البساتين" },
                    { new Guid("1b18fc82-a6fb-4024-bfe4-52dd5bf46c53"), 28, "الاقصر" },
                    { new Guid("1e95f851-bbad-4633-b0a6-89d87ca051f9"), 22, "قليوب" },
                    { new Guid("21befe01-1aa6-4933-a4c7-10a3ce91f723"), 32, "قنا" },
                    { new Guid("2505437c-9238-43c2-9b51-5789d71bb034"), 6, "مرسى مطروح" },
                    { new Guid("254e0d25-0453-4a81-95a4-d81791a3c41c"), 31, "المنصوره" },
                    { new Guid("25b19694-baf5-456f-8441-08062ac11171"), 26, "دمنهور" },
                    { new Guid("29df8c98-8737-41bb-9054-e49c09c4d8a1"), 8, "امبابه" },
                    { new Guid("3315fd7c-d368-4e15-a62e-22b3b8af2c20"), 41, "البحر الاحمر" },
                    { new Guid("348c35ba-faeb-47c1-88d2-5213501daeae"), 4, "الشرقية" },
                    { new Guid("3d04a836-64db-4ac6-8840-71d66253d34d"), 37, "القاهره" },
                    { new Guid("3d207422-3648-434e-b233-0911b65b8b75"), 29, "المحله" },
                    { new Guid("401a9620-1056-46c9-a04e-caeef9cdd13d"), 38, "طهران" },
                    { new Guid("44d7e52c-d127-401c-8eba-94d3a8b767ea"), 10, "القليوبية" },
                    { new Guid("44eb6f22-15d2-4cc3-8110-35e36fb5a01b"), 21, "الدقهليه" },
                    { new Guid("47f53832-9b24-41a1-b385-fcdf22e9ccd3"), 5, "المنوفية" },
                    { new Guid("4aefdc72-0dcf-4ea8-8392-d7fa32cc0838"), 19, "الغربيه" },
                    { new Guid("60a4211e-0d6a-48c8-af50-001183ef4b76"), 18, "الفيوم" },
                    { new Guid("649905db-b41a-46dc-83d0-45cffa32ea55"), 30, "كفر الشيخ" },
                    { new Guid("6cb61b47-9ef1-480d-b785-6ab5ecbdde84"), 11, "شبرا الخيمه" },
                    { new Guid("6ee51c15-4a93-4793-89b7-35e9f4a6165f"), 2, "الجيزة" },
                    { new Guid("75acee07-0566-4a59-a11e-28ee415d47db"), 24, "طنطا" },
                    { new Guid("7d79f7a0-1c91-4276-9aec-cd5c6fce2f86"), 23, "بورسعيد" },
                    { new Guid("828ae459-878d-4cc4-ab9f-430c722fb1c0"), 20, "الاسماعلية" },
                    { new Guid("91626097-4a00-40d8-b0e8-847a9c464c43"), 16, "اسيوط" },
                    { new Guid("9581a979-2d69-4220-9997-69a047ea8faf"), 13, "ميت غمرة" },
                    { new Guid("a94df28d-2fea-4584-ab8e-b4b7f1fcf435"), 3, "البحيرة" },
                    { new Guid("ae386773-d8ba-42da-b92a-acbda2993305"), 33, "بنها" },
                    { new Guid("bc959461-dcc7-4823-b262-2635c05e6630"), 36, "شبين الكوم" },
                    { new Guid("c5467ca5-122d-48c7-8171-acd36facd6a5"), 17, "المنيا" },
                    { new Guid("c5ad5da5-4eab-457c-9746-ed777c6fe468"), 35, "اسوان" },
                    { new Guid("c9a54dcc-9a5f-4026-a9a2-3aa1648e5fb2"), 7, "دمياط" },
                    { new Guid("cc2e6c1b-5d2a-425a-be21-e284d583410d"), 34, "السويس" },
                    { new Guid("ce86cc0d-b2d1-4512-8415-9a7ff18a5d11"), 12, "سوهاج" },
                    { new Guid("db2361e0-e9bd-43d2-80f6-4666dbd00678"), 40, "الامارات" },
                    { new Guid("dcb7eaaa-4125-44b3-8ea8-bd6a2c02281d"), 1, "القاهرة" },
                    { new Guid("e27b2323-3b80-46fc-995b-ddc8b78afb84"), 39, "جنوب سيناء" },
                    { new Guid("f0b5c37a-715f-4f1e-8f12-a64e86c3b406"), 25, "الاسكندريه" }
                });

            migrationBuilder.InsertData(
                table: "genderCodes",
                columns: new[] { "GenderId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("8fb0a526-7d42-4237-aa91-a73bdfce747a"), 2, "أنثى" },
                    { new Guid("904b5247-c2b8-423e-aa1e-7b5949a4dfcc"), 3, "غير معروف" },
                    { new Guid("9382c8d7-af15-4829-8e61-6068fb4fa617"), 1, "ذكر" }
                });

            migrationBuilder.InsertData(
                table: "jobCodes",
                columns: new[] { "JobId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0067f9c0-0b8a-4f26-8363-5d77651bff1d"), 400, "مدير ادارة" },
                    { new Guid("1162267b-ef71-4f6b-b78b-62e9d2eafeb9"), 203, "طباع" },
                    { new Guid("14729f31-3d48-41fb-996d-ebb4daf42f20"), 30, "ملاحظ" },
                    { new Guid("1609a2ab-eaa5-4118-80c7-8d4358947ccc"), 300, "اداري" },
                    { new Guid("1aa33314-565f-4b73-9c23-00af3ae0b866"), 121, "بناء افران" },
                    { new Guid("26fcf39a-cddc-4030-9f4a-24b927bbe62c"), 60, "ناظر محطه" },
                    { new Guid("27dbefdc-1936-46c6-a14e-cef661c4e6ac"), 180, "عامل" },
                    { new Guid("2a40e832-7064-4073-b0cf-ecd6fc0e32c0"), 157, "حداد" },
                    { new Guid("2baf134a-cbc3-49ab-a25c-80439d575e3a"), 59, "مشرف قطار" },
                    { new Guid("2d64bc41-b808-4d22-b654-5f25154eb6ae"), 111, "رئيس حركه" },
                    { new Guid("32f033a5-a1e7-4624-958e-45f1a9df97d0"), 55, "لحام" },
                    { new Guid("3a9de387-3f50-4967-a1b1-602e6f0b989e"), 396, "قائد قطار" },
                    { new Guid("3aee6eb1-d493-4741-9742-34e32ed71ce7"), 56, "صراف تذاكر" },
                    { new Guid("3cf40689-a231-4991-8945-4810f562b0cf"), 0, "خدمات معاونه" },
                    { new Guid("3f9f091e-cc8f-48b7-9d47-00d700469dd0"), 200, "مراقب ابراج" },
                    { new Guid("432d5763-69b9-4522-885d-bb7874274234"), 104, "هندسة الاشارات" },
                    { new Guid("4e7b4978-c584-4cc1-83a3-9856b1840bc4"), 100, "كاتب" },
                    { new Guid("505a3ce1-b60b-49f2-a6e7-e3a8e907828c"), 102, "امين مخزن" },
                    { new Guid("59863baa-0380-4506-a857-f0db78c12301"), 81, "ن . مالية" },
                    { new Guid("5fab3384-2d2c-4246-af72-955468dcb5ae"), 201, "سروجى" },
                    { new Guid("66c7a5a7-b407-4d11-9490-c4a2e4b682cc"), 107, "كاتبة" },
                    { new Guid("6818dd28-90c4-42c4-9797-28f9181c98ad"), 70, "مراقب" },
                    { new Guid("68c8511f-d564-4e9b-8de9-4a9dedf53f26"), 2, "الموارد البشريه" },
                    { new Guid("699878f5-8764-4d62-b45a-abfd37d7cdac"), 4, "معاش" },
                    { new Guid("6c4ffaf3-3eef-4241-b25f-c0bdcf3f312d"), 103, "اشارات مصر" },
                    { new Guid("76c5ba01-dc9f-4aa6-bc85-e424c30907a5"), 101, "مدير عام" },
                    { new Guid("77db9cb7-4726-4346-a1ee-58a6add6eb85"), 106, "كاتبة" },
                    { new Guid("87f4c7e0-d20b-4328-93ee-bb23058df2c0"), 500, "مفتش" },
                    { new Guid("9ab11a68-0ab4-4ba9-bdf0-4678e83dcb05"), 57, "تمريض" },
                    { new Guid("9b7ef9d6-2518-4c0b-ad83-0359bf45fe3f"), 1, "المالية" },
                    { new Guid("9cfe6029-e5bf-4561-9e5f-9f18911532c2"), 110, "براد" },
                    { new Guid("9e69cfe7-f438-4c0b-9b15-4f090be344a7"), 80, "أخرى" },
                    { new Guid("9ede9408-1c9d-41d7-b888-197511fe5b54"), 21, "خراط" },
                    { new Guid("b2847b9a-6346-4953-838f-31d01628f544"), 267, "رئيس قطار" },
                    { new Guid("c07e03db-bb91-47e0-b862-a092ea5a2426"), 7, "دكتور" },
                    { new Guid("c14c3cea-172c-4a94-b94c-21c3fe4e379e"), 5, "محاسب" },
                    { new Guid("c70ec817-9ee1-4d9b-91e8-2cf7c3f3eb58"), 26, "ملاحظ" },
                    { new Guid("c9c197d1-686a-449e-8b35-196eb11cae0c"), 158, "حرفى" },
                    { new Guid("cb7f7a24-1d9e-4cec-866b-1b1e7c4af358"), 61, "فحص مالى" },
                    { new Guid("ce66460a-e86e-4dd9-9c38-e935b1d89977"), 58, "موظف" },
                    { new Guid("d20c20b4-dfdd-4c60-b85d-9cd801dd7b81"), 3, "قطاع البضائع" },
                    { new Guid("d7e9675b-dfde-44b5-89ed-fb9376fd6357"), 52, "نقاش" },
                    { new Guid("dab2b3b6-a9d1-43bc-9a0e-350769ec7d9d"), 50, "سائق" },
                    { new Guid("dae47734-8b57-487f-bfe6-53090b80b3c8"), 202, "مضيف قطار" },
                    { new Guid("de068203-d687-44c5-8d08-28609bd066b9"), 401, "محقق قانوني" },
                    { new Guid("e37c6557-2a56-4f59-b3d8-00ff8760ac02"), 301, "محامي" },
                    { new Guid("e87fff44-67a3-4832-b2a2-ac042af2c97a"), 389, "مساعد قائد قطار" },
                    { new Guid("e8b16001-9eab-42a8-96a3-6050dc9fed2c"), 20, "ميكانيكى" },
                    { new Guid("f2071ea4-25fd-4af7-8cb1-74263c3c6792"), 54, "نجار" },
                    { new Guid("f34e9a22-fa45-4b4b-a3e0-3e0391079152"), 6, "مهندس" },
                    { new Guid("f4644503-cfdd-48bf-a8d5-d471a0fa6668"), 403, "رئيس إدارة مركزية" },
                    { new Guid("f6ee1664-216f-45e8-b3d6-148de5730944"), 109, "رئيس قسم" },
                    { new Guid("fa920432-b62a-40ba-b1a0-0cf8945a5170"), 402, "نائب رئيس مجلس الاداره" },
                    { new Guid("fb75c8e7-d7f0-4e21-81b7-0e7e2c1cbacd"), 51, "كهربائي" },
                    { new Guid("fbf76714-5f2d-4f04-9c70-2283f3f5453f"), 23, "فنى" },
                    { new Guid("fd2c6d54-21ca-4e56-bd3d-67080670b2a9"), 53, "سباك" }
                });

            migrationBuilder.InsertData(
                table: "martialStatusCodes",
                columns: new[] { "MartialStatusId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("1d0915ec-8837-4567-99cd-9629fb7ec8d6"), 1, "أعزب" },
                    { new Guid("409bb595-a921-4903-98e4-5f16e1ad328b"), 2, "متزوج/ة" },
                    { new Guid("7f2f177b-028f-4d38-b586-4a6693687f77"), 4, "أرمل/ة" },
                    { new Guid("86f119b3-b970-413e-9447-98a1a930a056"), 3, "مطلق/ة" }
                });

            migrationBuilder.InsertData(
                table: "membershipCodes",
                columns: new[] { "MembershipId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("01bdcb52-1beb-4a48-8024-e8c11e286472"), 8, "عضويه موسمية" },
                    { new Guid("16012a9c-f57b-48e9-a333-e9334d68bd8f"), 10, "عضو زائر" },
                    { new Guid("17b4ec99-6748-450c-841e-31ec0724f828"), 9, "عضو زائر  (مؤقت)" },
                    { new Guid("1f00ba9b-cd8c-444d-9f8c-b8bd8b3109dd"), 1, "عضو عامل" },
                    { new Guid("a8818135-0ead-4893-8472-6310054147dd"), 3, "عضوية فخرية" },
                    { new Guid("d98d87b6-d264-40e9-8c69-9e4d4a806d7c"), 2, "عضو عامل خ" }
                });

            migrationBuilder.InsertData(
                table: "nationalityCodes",
                columns: new[] { "NationalityId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("1e09c88f-e57d-4d3b-a853-fe6c11845bdf"), 1, "مصرى/ة" },
                    { new Guid("874c4c02-bf5f-472c-b8a1-728be2bed86c"), 4, "إماراتى/ة" },
                    { new Guid("9e559bfb-51db-4600-8c3a-318a77278546"), 3, "كويتى/ة" },
                    { new Guid("b43e31ae-18d8-47c8-a262-e9682a252e5e"), 2, "سعودى/ة" }
                });

            migrationBuilder.InsertData(
                table: "religionCodes",
                columns: new[] { "ReligionId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("3a40324f-0fd4-4014-9cb3-769c069a261e"), 2, "مسيحى/ة" },
                    { new Guid("7f05fb6a-ccac-456d-a798-db00cbaf2ed6"), 1, "مسلم/ة" },
                    { new Guid("9c6011d8-0ae0-457d-abc6-5095a3f16380"), 3, "أخرى" }
                });

            migrationBuilder.InsertData(
                table: "sectionCodes",
                columns: new[] { "SectionId", "Annual", "Code", "ComPenalty", "Donation", "Improve", "Init", "Id", "Maintenance", "Name", "Office", "Penalty", "Player", "Pool", "Post", "Reg", "ReserveFee", "River", "Society", "Stamp", "Worker" },
                values: new object[,]
                {
                    { new Guid("003b778c-cfd6-4a45-a743-73805c425879"), false, 34, false, false, false, false, false, false, "المسافات القصيرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("007f187f-dc94-4169-91d9-b22902b50baa"), false, 95, false, false, false, false, false, false, "حاسب الى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("01f4c3ad-d74f-4b6e-a009-5f09ac87317a"), false, 63, false, false, false, false, false, false, "مراقب ابراج", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("02fd0dbe-07b7-4dc1-9a80-f88feafa4982"), false, 66, false, false, false, false, false, false, "اداره السيارات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("0feaa534-3123-4c23-a843-ce48cb4b4ae5"), false, 28, false, false, false, false, false, false, "الخدمات المشتركه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("1110ead7-1568-4533-8268-48465fa9f482"), false, 30, false, false, false, false, false, false, "المنشأت", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("11b6d5e6-7a8a-474a-bfd7-fb247d3a823f"), false, 84, false, false, false, false, false, false, "المعدات الثقيلة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("11bec621-e3fc-4f78-ab77-b5068f6d9853"), false, 25, false, false, false, false, false, false, "الاشارات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("12ce8e13-84a6-46c1-934f-6b6d07c5f136"), false, 77, false, false, false, false, false, false, "ديزل كوبري الليمون", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("14553a7d-c855-4936-8834-1975554be455"), false, 16, false, false, false, false, false, false, "عباسية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("16d6576d-d3d1-4064-9e87-941f1a3bebd0"), false, 71, false, false, false, false, false, false, "بنك القاهرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("1e4e9221-0c94-44bf-ac99-ecae6b6a4ba7"), false, 4, false, false, false, false, false, false, "مستشار الوزير", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("1fdf49d4-2b1c-4db4-bf9d-ad952a967476"), false, 6, false, false, false, false, false, false, "رئاسة الهيئة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("23c2f031-9168-4d39-b3cc-bcd1528e685a"), false, 5, false, false, false, false, false, false, "مترو", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("2ad4d705-e9ad-4d6e-9447-9f38d80cb39f"), false, 81, false, false, false, false, false, false, "رئيس الشئون القانونية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("2b2cce63-131d-4232-8da6-a3d01801e4fc"), false, 33, false, false, false, false, false, false, "المسافات الطويلة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("2f2b1f07-5bc0-4f82-849e-6538c6c7b506"), false, 87, false, false, false, false, false, false, "عنابر بولاق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("338ba79f-ebd4-4862-af59-71c39673ff7c"), false, 85, false, false, false, false, false, false, "شئون قانونيه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("369c8b80-34f3-4ef5-a0d0-b4f863e58cb3"), false, 60, false, false, false, false, false, false, "نائب رئيس مجلس إداره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("396482ff-4536-4b9f-bc34-695b2459ed16"), false, 24, false, false, false, false, false, false, "مدير هيئة سابق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("3bd7eebf-6ece-42c8-8614-962f4c569ba2"), false, 55, false, false, false, false, false, false, "اداره التنسيق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("3d0f0ee7-7116-4021-ab86-e16fccf6c351"), false, 29, false, false, false, false, false, false, "ادارة المحطات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("3e3db4f5-81e7-4108-a02e-87bc1cdf8231"), false, 42, false, false, false, false, false, false, "د.بولاق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("407ee1e7-662c-4670-a3d2-c83b1033b478"), false, 19, false, false, false, false, false, false, "موسميه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("43aa3707-654f-40c1-9cb7-5dd0c1588fb9"), false, 44, false, false, false, false, false, false, "مخازن", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("4815a999-9672-4bfd-8e8b-3e3edba07537"), false, 64, false, false, false, false, false, false, "الموارد البشرية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("4ff72d79-f4d0-43ad-bf66-20b0472b39df"), false, 74, false, false, false, false, false, false, "الادارة المركزية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("544a1b30-9579-4a14-aa35-5819ec21198c"), false, 27, false, false, false, false, false, false, "ادارة مالية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("564b9036-442f-4726-a453-94962199fcf3"), false, 18, false, false, false, false, false, false, "المشروعات والتطوير", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("59a1ad17-8471-4aa6-9b02-366755176f73"), false, 41, false, false, false, false, false, false, "د.طرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("5b6b842e-bf9e-47ec-9972-c73a04c2c345"), false, 51, false, false, false, false, false, false, "مؤقته", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("5cdb2821-2b3f-42fc-9942-12e1b398fcd1"), false, 76, false, false, false, false, false, false, "دعم فنى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("601408b1-ee87-4626-aef2-7b48fab8d099"), false, 1, false, false, false, false, false, false, "عضوية زائرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("60d2283b-b7ee-4b06-8c51-05a04f590c54"), false, 8, false, false, false, false, false, false, "مطابع", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("68a36293-a23c-4612-ad05-ea5355330d92"), false, 86, false, false, false, false, false, false, "اداره النقل", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("68bfcdad-6ef1-48cb-b87d-f5a5a0b7315c"), false, 35, false, false, false, false, false, false, "خدمه العملاء", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("69d743f5-bb8b-4518-bc0d-fc6a6e8bb2bd"), false, 9, false, false, false, false, false, false, "ابو زعبل", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("74e59692-6b7d-45be-b462-59ed305e0fb9"), false, 61, false, false, false, false, false, false, "ابى غاطس", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("79f2ce13-9825-46f0-9722-210c29362f45"), false, 54, false, false, false, false, false, false, "مخازن", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("7c8b936f-cf07-4628-9e63-b3aeca20a28b"), false, 20, false, false, false, false, false, false, "بولاق الدكرور", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("7fc46427-b812-413b-ac92-8e07124b2af6"), false, 13, false, false, false, false, false, false, "هندسه السكه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("81fd7cb4-c14f-494a-b09c-af96cc69ee42"), false, 2, false, false, false, false, false, false, "رئيس مجس الإدارة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("82b95211-190b-4601-9686-b9eff5faca46"), false, 43, false, false, false, false, false, false, "السلامه و الجوده", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("86bc4dad-bf6c-46f2-a64d-e1ee4a8ace34"), false, 31, false, false, false, false, false, false, "الكبارى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("874e1613-9099-467d-b26b-3435a76cbae8"), false, 75, false, false, false, false, false, false, "قطاع البضائع", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("94238321-fd85-4b62-af9e-c69e1db5cbfa"), false, 73, false, false, false, false, false, false, "كهرباء السبتية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("9c071ebe-9701-4356-809a-a2c159de567f"), false, 89, false, false, false, false, false, false, "الاملاك", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("a4a345ec-2021-499c-930a-188f8267e213"), false, 7, false, false, false, false, false, false, "ورش", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("a9f98722-97d7-4c7b-a757-13e5e19332b6"), false, 17, false, false, false, false, false, false, "م.الالكتروني", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("aa26b64a-959d-495d-93ae-11ce725eaa04"), false, 40, false, false, false, false, false, false, "ابي غاطس", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("b262130e-7041-423d-a457-404a9338fc2f"), false, 80, false, false, false, false, false, false, "سيارات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("b29632f7-3cf0-4449-8a9f-c92ae4c6380e"), false, 70, false, false, false, false, false, false, "البنيه الاساسيه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("bc103075-6099-44ae-a6c3-6d3307e05a1d"), false, 88, false, false, false, false, false, false, "اداره الهيئه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("be9cd3d9-7435-40f0-9a65-ee6258ae0076"), false, 11, false, false, false, false, false, false, "ديزل القاهره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c10da81d-fc94-4f27-90c8-034b973e2e9e"), false, 79, false, false, false, false, false, false, "عربات الركاب", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c6a879b1-ec25-4628-b4ee-5d7e8f7c4e57"), false, 12, false, false, false, false, false, false, "فرز القاهره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c816656e-1842-4285-8013-ccd953dca868"), false, 52, false, false, false, false, false, false, "مخازن", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("ca39ea6d-84b7-48cf-8e33-d12304512b92"), false, 99, false, false, false, false, false, false, "مبيعات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("d4333ca5-0808-495b-9a7e-58722b737582"), false, 93, false, false, false, false, false, false, "الفحص", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("d92cc85a-5e96-4b48-a9f3-37a37672a823"), false, 0, false, false, false, false, false, false, "0", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("dbe75545-662d-4c79-9268-80d4095894a9"), false, 15, false, false, false, false, false, false, "حركه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("de118396-bc60-41ab-8634-d4597c92e4d1"), false, 14, false, false, false, false, false, false, "منطقه القاهره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e0944487-2f77-4a00-aabb-1ee40e1cc84f"), false, 26, false, false, false, false, false, false, "المركز الطبي", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e3af7a28-1f33-466c-9b46-f8739267e8e0"), false, 94, false, false, false, false, false, false, "قطاع الصيانه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e457e44b-5f70-4b7a-834d-d6d98f2351db"), false, 50, false, false, false, false, false, false, "الادارة القانونية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e7973b7d-33a9-439b-8b9b-a2bfee318244"), false, 3, false, false, false, false, false, false, "معاشات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("f49e1ba0-07a5-414d-8a97-c1b0af4133de"), false, 21, false, false, false, false, false, false, "الوحدات المتحركة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("f5f2e22e-15f3-47e8-9965-2d03ea7f6f8b"), false, 32, false, false, false, false, false, false, "التشغيل", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("fc2c95d0-e07b-401b-bdd5-cd07ca3316f5"), false, 10, false, false, false, false, false, false, "التبين", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("fef0577a-f741-45ae-a102-259b1b9fb0ea"), false, 83, false, false, false, false, false, false, "ابو راضى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("ffbae245-6f0e-4d96-a11d-b8c75a5655cc"), false, 90, false, false, false, false, false, false, "ديزل الزقازيق", false, false, false, false, false, false, false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "titleCodes",
                columns: new[] { "TitleId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("22c48ac3-0baf-4540-afcd-456ba610e505"), 1, "السيد/ة" },
                    { new Guid("326b838c-d276-46d1-9651-f65637390ac1"), 2, "أستاذ/ة" },
                    { new Guid("b4110f2d-db6a-4805-b188-f8c3c91b6413"), 3, "دكتور/ة" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("0beae64d-1c92-4783-aece-539656f2ec40"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("596bdbb0-584b-4fc8-b1f3-1cfa54998b40"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("7af6d34f-db0d-41c2-80c5-8ca7a17cc206"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("8c5ceb84-fbc7-4581-9ac1-86bb2446dd72"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("aa1a0d93-8924-46d9-9cbf-5ca3a101eaac"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("aab97268-1eda-42c8-ba83-24ee745df96a"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("bfbe1e65-6127-4151-b719-c52c9695355a"));

            migrationBuilder.DeleteData(
                table: "QualCodes",
                keyColumn: "QualId",
                keyValue: new Guid("deb5c556-07cd-403f-aaa5-5835db300c5c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("01b163c8-2ea8-4f9a-88a9-5780b4d0e0c3"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("13b6bbe5-8739-4515-8b76-a20a9cbe5abd"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("13d5c03e-b7f5-447a-8027-1945a0ff93e7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("1c470b33-8b59-44f0-ab71-a82ce74d8428"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("1c4d8983-2bf0-4c84-81fa-3404b4ee64e4"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("1e99b411-db24-402a-beaf-910419924e38"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("22a53004-a7e1-4559-8b33-b4cc83429e6a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("233e7488-57a6-4bcf-bb66-a9e2b27a39a0"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("2e27b8d9-0e6a-4418-b08a-fbcd59ebb509"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("35c56d49-502d-43bc-8860-a4d667e8dcdf"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("35d4cb2a-7b32-439a-bdd8-f597b2736bc6"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("379436fb-04d1-43d3-9bac-2fa378220d4b"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("3a290d93-40ea-4d52-9a01-4f5f7538ecec"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("3c4cb539-a0ca-43a2-be23-1f26e91afad8"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("41b43e56-7ee0-46c2-a78e-e127ed87a9d4"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("4218c8be-239e-4364-ba06-489caa274fd1"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("42832812-6581-4694-a56d-ed507de6dc8f"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("42f1f9a8-0fe2-4b66-a9b1-dfbadf71fe06"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("48d672fd-c7e5-4a55-a100-b4d9324d28e5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("48feddec-1c4b-4f45-828c-b058f547025c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("4be9cadf-4e35-44f3-8cb0-bd13edec58a9"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("4bf83cb4-59eb-4155-b91d-d264e3e9df02"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("52744c05-5f63-4fcf-94c1-4c74d3109f38"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("535dc9c3-c8dc-4c01-a070-fd920865ec9a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("568fdcae-b169-4e25-8a60-72ffca3e882d"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("5ab970f0-5e7e-4ec6-8470-aecd908b6b87"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("5db17be9-c102-4f78-8d96-b685b8154fa8"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("5f3d86bf-128b-4578-b505-c4afaf417dff"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("61cef87b-fb3a-44b5-a269-fde74d4f3eff"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("652d0dbb-e5f0-4bd8-ab9a-e21071d6c398"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("67f5b46d-d298-4ce2-9a49-a3e995797bcb"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6a01962a-3942-424f-a962-c9b70b03592c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6a1b402d-5f9b-46c5-800a-684a30a467a5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("6bf60b39-ef4c-468e-9518-75c9cf5aa3b0"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("739729e3-969d-456b-8f85-16dab8663b9c"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("753ffc0b-8710-4b0f-a4f3-806cf95dd5c8"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("757ec334-555b-4734-9484-3245acc12776"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("76a6573f-6a10-419c-8049-f53a1eb41ad2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("7b7a17bf-9423-498b-832c-bffe59c55531"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("7db56418-3d84-4612-a34c-1fc4686fddb2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("801d1693-d747-4267-ac8e-c7c42edea9b3"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("8124eabd-83e7-4718-9552-744745496eb5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("859a48e0-7559-46f3-ab53-e97de3124b42"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("87e6163b-cbe8-49d4-a5ed-ac47446c86bf"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("89c17bb1-c78d-4223-9ff3-376a37f6fd9f"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("8c316aab-6b88-44db-a72e-a4afec71aaf7"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("92bc20be-9831-42ad-9a3a-9775b5d144e2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("94c30c3c-e662-4abe-a9dd-3eeb6147dbfc"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("95c182ac-948e-47f4-bd62-0db6000ac2ad"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("972d8c71-e2a8-4d27-b947-aae64e52fb14"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9900b3c0-ee53-41ee-b81f-cf69307e3700"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9d3c82b2-0d18-4915-ac37-e9a0b0b0f78d"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("9e83130e-d217-49a3-bf22-db10d8028fcd"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a06e2175-cc4d-4736-9a59-4024f9a74393"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a4337818-52a4-497f-860f-1ac8b45ca098"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a63dbbda-c48a-4671-988f-74866c5bb2b9"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a68edccb-422d-42ba-80aa-fabddc42d8b3"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("a8451aa4-77bd-43c0-b2eb-5349056a3cf1"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ad1f06fa-739c-424f-b681-b25fa7c5fc74"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ad91b037-41b2-4a67-8de4-b392107ceb16"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("af0e6b5a-9424-4ea0-9575-afc18495873d"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("af6eefd7-7846-489f-a40b-ad18ee7dc92a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b08c1c2a-3715-4e7e-aeb4-822453c4bb76"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b14e9255-aba4-4563-80c6-f1965a9bed7d"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b2a63c73-6248-4b0a-b056-b5aefcd0bf94"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("b4da4b07-4a10-4e33-8b8e-3c757542bf74"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("bbf47344-2d91-4560-af8c-b69049b4dd4f"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("c25fa2ea-43c2-4877-b523-63184119be0a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("cb0e23ba-d98d-416d-a80a-de77a63306e4"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ce3f1212-776c-4a2f-afcf-b6fcbaa7869a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("cec7b3c3-92b8-4cbf-8b41-f709a78f9284"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("cf3f04da-5105-43ca-9956-9c83c3f314c3"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("d1122e52-5f88-49bb-949b-7578b40826ec"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("d5157858-7f7e-4f3c-89ff-dd04629e07f4"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("d90c802b-7311-4fc2-9be2-6e715fc238d0"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("d9871098-0ec2-4428-9065-23e4efb080bf"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("db2a3b82-a592-400b-a58c-56feed94dabf"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("dbaafd52-658d-411e-9bb0-34e52439afd9"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("e22d8941-25ce-4721-aef1-1f0a82dc6559"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ec974e7a-4b5a-4684-8d2c-6729c3fee1a5"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("ef9621ee-0ebc-450f-a923-2e718fec96cc"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("f0baa4a3-fd33-45c9-868b-53b850e26a01"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("f434e51c-0f81-4c1e-a08d-2a4d2ad7b97a"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("f803c2f5-db87-4d4d-a82a-1300164e5834"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("fae9ecbc-9ae3-4dee-8a78-a36aefb28e67"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("fdf8d19a-53ae-4a39-8eb9-a6882894ebf2"));

            migrationBuilder.DeleteData(
                table: "RefCodes",
                keyColumn: "RefId",
                keyValue: new Guid("feecbbd0-f4dc-4761-bb04-0bb669563e62"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("0d019147-312c-45f7-829e-f15ce5bd6215"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("2e6e84e0-34d7-49aa-9ad7-c28b6f5372b0"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("7d41e4db-a9d3-4af5-b4e7-673879e143d3"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("81c75da6-9580-467b-8efb-1d48c22da2c9"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("9bd7c534-39b5-4bd4-8444-4063594e7700"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("d60606be-ef3c-415b-864e-3ab7371ac4df"));

            migrationBuilder.DeleteData(
                table: "TransCodes",
                keyColumn: "TransId",
                keyValue: new Guid("d9839bc1-d6d6-4738-b1e2-0ef1a0eda58b"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("027b3e9f-a5b6-44f3-b3a5-60ac8d1863b9"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("0798ec22-f3e0-43cf-a91d-c1d64462e862"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("0e1033b3-cab3-4c07-af38-c8a5874c65ae"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("14887124-afe6-49f4-8c53-8cb2cf554d34"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("19d12cdc-a9dd-48ae-9776-0f5a9991ff29"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("1b18fc82-a6fb-4024-bfe4-52dd5bf46c53"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("1e95f851-bbad-4633-b0a6-89d87ca051f9"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("21befe01-1aa6-4933-a4c7-10a3ce91f723"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("2505437c-9238-43c2-9b51-5789d71bb034"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("254e0d25-0453-4a81-95a4-d81791a3c41c"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("25b19694-baf5-456f-8441-08062ac11171"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("29df8c98-8737-41bb-9054-e49c09c4d8a1"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("3315fd7c-d368-4e15-a62e-22b3b8af2c20"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("348c35ba-faeb-47c1-88d2-5213501daeae"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("3d04a836-64db-4ac6-8840-71d66253d34d"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("3d207422-3648-434e-b233-0911b65b8b75"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("401a9620-1056-46c9-a04e-caeef9cdd13d"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("44d7e52c-d127-401c-8eba-94d3a8b767ea"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("44eb6f22-15d2-4cc3-8110-35e36fb5a01b"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("47f53832-9b24-41a1-b385-fcdf22e9ccd3"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("4aefdc72-0dcf-4ea8-8392-d7fa32cc0838"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("60a4211e-0d6a-48c8-af50-001183ef4b76"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("649905db-b41a-46dc-83d0-45cffa32ea55"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("6cb61b47-9ef1-480d-b785-6ab5ecbdde84"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("6ee51c15-4a93-4793-89b7-35e9f4a6165f"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("75acee07-0566-4a59-a11e-28ee415d47db"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("7d79f7a0-1c91-4276-9aec-cd5c6fce2f86"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("828ae459-878d-4cc4-ab9f-430c722fb1c0"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("91626097-4a00-40d8-b0e8-847a9c464c43"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("9581a979-2d69-4220-9997-69a047ea8faf"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("a94df28d-2fea-4584-ab8e-b4b7f1fcf435"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("ae386773-d8ba-42da-b92a-acbda2993305"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("bc959461-dcc7-4823-b262-2635c05e6630"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("c5467ca5-122d-48c7-8171-acd36facd6a5"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("c5ad5da5-4eab-457c-9746-ed777c6fe468"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("c9a54dcc-9a5f-4026-a9a2-3aa1648e5fb2"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("cc2e6c1b-5d2a-425a-be21-e284d583410d"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("ce86cc0d-b2d1-4512-8415-9a7ff18a5d11"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("db2361e0-e9bd-43d2-80f6-4666dbd00678"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("dcb7eaaa-4125-44b3-8ea8-bd6a2c02281d"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("e27b2323-3b80-46fc-995b-ddc8b78afb84"));

            migrationBuilder.DeleteData(
                table: "cityCodes",
                keyColumn: "CityId",
                keyValue: new Guid("f0b5c37a-715f-4f1e-8f12-a64e86c3b406"));

            migrationBuilder.DeleteData(
                table: "genderCodes",
                keyColumn: "GenderId",
                keyValue: new Guid("8fb0a526-7d42-4237-aa91-a73bdfce747a"));

            migrationBuilder.DeleteData(
                table: "genderCodes",
                keyColumn: "GenderId",
                keyValue: new Guid("904b5247-c2b8-423e-aa1e-7b5949a4dfcc"));

            migrationBuilder.DeleteData(
                table: "genderCodes",
                keyColumn: "GenderId",
                keyValue: new Guid("9382c8d7-af15-4829-8e61-6068fb4fa617"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("0067f9c0-0b8a-4f26-8363-5d77651bff1d"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1162267b-ef71-4f6b-b78b-62e9d2eafeb9"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("14729f31-3d48-41fb-996d-ebb4daf42f20"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1609a2ab-eaa5-4118-80c7-8d4358947ccc"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("1aa33314-565f-4b73-9c23-00af3ae0b866"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("26fcf39a-cddc-4030-9f4a-24b927bbe62c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("27dbefdc-1936-46c6-a14e-cef661c4e6ac"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("2a40e832-7064-4073-b0cf-ecd6fc0e32c0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("2baf134a-cbc3-49ab-a25c-80439d575e3a"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("2d64bc41-b808-4d22-b654-5f25154eb6ae"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("32f033a5-a1e7-4624-958e-45f1a9df97d0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("3a9de387-3f50-4967-a1b1-602e6f0b989e"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("3aee6eb1-d493-4741-9742-34e32ed71ce7"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("3cf40689-a231-4991-8945-4810f562b0cf"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("3f9f091e-cc8f-48b7-9d47-00d700469dd0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("432d5763-69b9-4522-885d-bb7874274234"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("4e7b4978-c584-4cc1-83a3-9856b1840bc4"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("505a3ce1-b60b-49f2-a6e7-e3a8e907828c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("59863baa-0380-4506-a857-f0db78c12301"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("5fab3384-2d2c-4246-af72-955468dcb5ae"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("66c7a5a7-b407-4d11-9490-c4a2e4b682cc"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("6818dd28-90c4-42c4-9797-28f9181c98ad"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("68c8511f-d564-4e9b-8de9-4a9dedf53f26"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("699878f5-8764-4d62-b45a-abfd37d7cdac"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("6c4ffaf3-3eef-4241-b25f-c0bdcf3f312d"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("76c5ba01-dc9f-4aa6-bc85-e424c30907a5"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("77db9cb7-4726-4346-a1ee-58a6add6eb85"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("87f4c7e0-d20b-4328-93ee-bb23058df2c0"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9ab11a68-0ab4-4ba9-bdf0-4678e83dcb05"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9b7ef9d6-2518-4c0b-ad83-0359bf45fe3f"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9cfe6029-e5bf-4561-9e5f-9f18911532c2"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9e69cfe7-f438-4c0b-9b15-4f090be344a7"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("9ede9408-1c9d-41d7-b888-197511fe5b54"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("b2847b9a-6346-4953-838f-31d01628f544"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c07e03db-bb91-47e0-b862-a092ea5a2426"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c14c3cea-172c-4a94-b94c-21c3fe4e379e"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c70ec817-9ee1-4d9b-91e8-2cf7c3f3eb58"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("c9c197d1-686a-449e-8b35-196eb11cae0c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("cb7f7a24-1d9e-4cec-866b-1b1e7c4af358"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("ce66460a-e86e-4dd9-9c38-e935b1d89977"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("d20c20b4-dfdd-4c60-b85d-9cd801dd7b81"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("d7e9675b-dfde-44b5-89ed-fb9376fd6357"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("dab2b3b6-a9d1-43bc-9a0e-350769ec7d9d"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("dae47734-8b57-487f-bfe6-53090b80b3c8"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("de068203-d687-44c5-8d08-28609bd066b9"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("e37c6557-2a56-4f59-b3d8-00ff8760ac02"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("e87fff44-67a3-4832-b2a2-ac042af2c97a"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("e8b16001-9eab-42a8-96a3-6050dc9fed2c"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("f2071ea4-25fd-4af7-8cb1-74263c3c6792"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("f34e9a22-fa45-4b4b-a3e0-3e0391079152"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("f4644503-cfdd-48bf-a8d5-d471a0fa6668"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("f6ee1664-216f-45e8-b3d6-148de5730944"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("fa920432-b62a-40ba-b1a0-0cf8945a5170"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("fb75c8e7-d7f0-4e21-81b7-0e7e2c1cbacd"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("fbf76714-5f2d-4f04-9c70-2283f3f5453f"));

            migrationBuilder.DeleteData(
                table: "jobCodes",
                keyColumn: "JobId",
                keyValue: new Guid("fd2c6d54-21ca-4e56-bd3d-67080670b2a9"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("1d0915ec-8837-4567-99cd-9629fb7ec8d6"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("409bb595-a921-4903-98e4-5f16e1ad328b"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("7f2f177b-028f-4d38-b586-4a6693687f77"));

            migrationBuilder.DeleteData(
                table: "martialStatusCodes",
                keyColumn: "MartialStatusId",
                keyValue: new Guid("86f119b3-b970-413e-9447-98a1a930a056"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("01bdcb52-1beb-4a48-8024-e8c11e286472"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("16012a9c-f57b-48e9-a333-e9334d68bd8f"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("17b4ec99-6748-450c-841e-31ec0724f828"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("1f00ba9b-cd8c-444d-9f8c-b8bd8b3109dd"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("a8818135-0ead-4893-8472-6310054147dd"));

            migrationBuilder.DeleteData(
                table: "membershipCodes",
                keyColumn: "MembershipId",
                keyValue: new Guid("d98d87b6-d264-40e9-8c69-9e4d4a806d7c"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("1e09c88f-e57d-4d3b-a853-fe6c11845bdf"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("874c4c02-bf5f-472c-b8a1-728be2bed86c"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("9e559bfb-51db-4600-8c3a-318a77278546"));

            migrationBuilder.DeleteData(
                table: "nationalityCodes",
                keyColumn: "NationalityId",
                keyValue: new Guid("b43e31ae-18d8-47c8-a262-e9682a252e5e"));

            migrationBuilder.DeleteData(
                table: "religionCodes",
                keyColumn: "ReligionId",
                keyValue: new Guid("3a40324f-0fd4-4014-9cb3-769c069a261e"));

            migrationBuilder.DeleteData(
                table: "religionCodes",
                keyColumn: "ReligionId",
                keyValue: new Guid("7f05fb6a-ccac-456d-a798-db00cbaf2ed6"));

            migrationBuilder.DeleteData(
                table: "religionCodes",
                keyColumn: "ReligionId",
                keyValue: new Guid("9c6011d8-0ae0-457d-abc6-5095a3f16380"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("003b778c-cfd6-4a45-a743-73805c425879"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("007f187f-dc94-4169-91d9-b22902b50baa"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("01f4c3ad-d74f-4b6e-a009-5f09ac87317a"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("02fd0dbe-07b7-4dc1-9a80-f88feafa4982"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("0feaa534-3123-4c23-a843-ce48cb4b4ae5"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("1110ead7-1568-4533-8268-48465fa9f482"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("11b6d5e6-7a8a-474a-bfd7-fb247d3a823f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("11bec621-e3fc-4f78-ab77-b5068f6d9853"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("12ce8e13-84a6-46c1-934f-6b6d07c5f136"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("14553a7d-c855-4936-8834-1975554be455"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("16d6576d-d3d1-4064-9e87-941f1a3bebd0"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("1e4e9221-0c94-44bf-ac99-ecae6b6a4ba7"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("1fdf49d4-2b1c-4db4-bf9d-ad952a967476"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("23c2f031-9168-4d39-b3cc-bcd1528e685a"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("2ad4d705-e9ad-4d6e-9447-9f38d80cb39f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("2b2cce63-131d-4232-8da6-a3d01801e4fc"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("2f2b1f07-5bc0-4f82-849e-6538c6c7b506"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("338ba79f-ebd4-4862-af59-71c39673ff7c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("369c8b80-34f3-4ef5-a0d0-b4f863e58cb3"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("396482ff-4536-4b9f-bc34-695b2459ed16"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("3bd7eebf-6ece-42c8-8614-962f4c569ba2"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("3d0f0ee7-7116-4021-ab86-e16fccf6c351"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("3e3db4f5-81e7-4108-a02e-87bc1cdf8231"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("407ee1e7-662c-4670-a3d2-c83b1033b478"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("43aa3707-654f-40c1-9cb7-5dd0c1588fb9"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("4815a999-9672-4bfd-8e8b-3e3edba07537"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("4ff72d79-f4d0-43ad-bf66-20b0472b39df"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("544a1b30-9579-4a14-aa35-5819ec21198c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("564b9036-442f-4726-a453-94962199fcf3"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("59a1ad17-8471-4aa6-9b02-366755176f73"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("5b6b842e-bf9e-47ec-9972-c73a04c2c345"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("5cdb2821-2b3f-42fc-9942-12e1b398fcd1"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("601408b1-ee87-4626-aef2-7b48fab8d099"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("60d2283b-b7ee-4b06-8c51-05a04f590c54"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("68a36293-a23c-4612-ad05-ea5355330d92"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("68bfcdad-6ef1-48cb-b87d-f5a5a0b7315c"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("69d743f5-bb8b-4518-bc0d-fc6a6e8bb2bd"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("74e59692-6b7d-45be-b462-59ed305e0fb9"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("79f2ce13-9825-46f0-9722-210c29362f45"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("7c8b936f-cf07-4628-9e63-b3aeca20a28b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("7fc46427-b812-413b-ac92-8e07124b2af6"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("81fd7cb4-c14f-494a-b09c-af96cc69ee42"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("82b95211-190b-4601-9686-b9eff5faca46"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("86bc4dad-bf6c-46f2-a64d-e1ee4a8ace34"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("874e1613-9099-467d-b26b-3435a76cbae8"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("94238321-fd85-4b62-af9e-c69e1db5cbfa"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("9c071ebe-9701-4356-809a-a2c159de567f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("a4a345ec-2021-499c-930a-188f8267e213"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("a9f98722-97d7-4c7b-a757-13e5e19332b6"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("aa26b64a-959d-495d-93ae-11ce725eaa04"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("b262130e-7041-423d-a457-404a9338fc2f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("b29632f7-3cf0-4449-8a9f-c92ae4c6380e"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("bc103075-6099-44ae-a6c3-6d3307e05a1d"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("be9cd3d9-7435-40f0-9a65-ee6258ae0076"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c10da81d-fc94-4f27-90c8-034b973e2e9e"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c6a879b1-ec25-4628-b4ee-5d7e8f7c4e57"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("c816656e-1842-4285-8013-ccd953dca868"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("ca39ea6d-84b7-48cf-8e33-d12304512b92"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("d4333ca5-0808-495b-9a7e-58722b737582"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("d92cc85a-5e96-4b48-a9f3-37a37672a823"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("dbe75545-662d-4c79-9268-80d4095894a9"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("de118396-bc60-41ab-8634-d4597c92e4d1"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e0944487-2f77-4a00-aabb-1ee40e1cc84f"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e3af7a28-1f33-466c-9b46-f8739267e8e0"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e457e44b-5f70-4b7a-834d-d6d98f2351db"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("e7973b7d-33a9-439b-8b9b-a2bfee318244"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("f49e1ba0-07a5-414d-8a97-c1b0af4133de"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("f5f2e22e-15f3-47e8-9965-2d03ea7f6f8b"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("fc2c95d0-e07b-401b-bdd5-cd07ca3316f5"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("fef0577a-f741-45ae-a102-259b1b9fb0ea"));

            migrationBuilder.DeleteData(
                table: "sectionCodes",
                keyColumn: "SectionId",
                keyValue: new Guid("ffbae245-6f0e-4d96-a11d-b8c75a5655cc"));

            migrationBuilder.DeleteData(
                table: "titleCodes",
                keyColumn: "TitleId",
                keyValue: new Guid("22c48ac3-0baf-4540-afcd-456ba610e505"));

            migrationBuilder.DeleteData(
                table: "titleCodes",
                keyColumn: "TitleId",
                keyValue: new Guid("326b838c-d276-46d1-9651-f65637390ac1"));

            migrationBuilder.DeleteData(
                table: "titleCodes",
                keyColumn: "TitleId",
                keyValue: new Guid("b4110f2d-db6a-4805-b188-f8c3c91b6413"));

            migrationBuilder.InsertData(
                table: "QualCodes",
                columns: new[] { "QualId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("127c50b0-95f3-4ccd-af5a-b729e4b88d78"), 2, "مؤهل عالى" },
                    { new Guid("1ce021b5-1518-46eb-8321-30407f445070"), 4, "مؤهل متوسط" },
                    { new Guid("5e8173f3-a1c6-4d53-a8cf-20469a50d245"), 300, "محامي" },
                    { new Guid("892169a5-5194-4fb3-bff8-6a4e1b039185"), 3, "مؤهل فوق المتوسط" },
                    { new Guid("aaeb865d-3b8f-4117-9fda-575a2a943c23"), 5, "بدون مؤهل" },
                    { new Guid("c464850e-9059-4c02-a588-2a5793b37b1b"), 7, "طالبة" },
                    { new Guid("ea2f9929-de61-47da-b465-7f1edaa5b051"), 6, "طالب" },
                    { new Guid("fd1b0949-2190-44b8-aa9b-8b73aa8043cd"), 1, "مؤهل فوق عالى" }
                });

            migrationBuilder.InsertData(
                table: "RefCodes",
                columns: new[] { "RefId", "AgeFlag", "Code", "Name", "RefFee" },
                values: new object[,]
                {
                    { new Guid("014e7c54-f872-44b2-829c-b6c852cd7af5"), false, 3, "زوجة", 15.0m },
                    { new Guid("068db146-ca2f-41a3-9941-aba1cee79830"), false, 57, "خاله تخفيض", 11.0m },
                    { new Guid("06cba4bd-eb99-46df-b99b-783ff9d8f7b2"), false, 39, "اخت الزوج", 22.0m },
                    { new Guid("0e9c9db9-5735-4609-8fe0-7480008d8af1"), false, 83, "اخت الزوج تخفيض", 11.0m },
                    { new Guid("13528a60-f47b-4b11-9b70-dffcc90650d0"), true, 13, "بنت أخ", 22.0m },
                    { new Guid("1fe6df7a-7860-4670-b39d-11a2d4ab7ad7"), true, 82, "اخ الزوج تخفيض", 11.0m },
                    { new Guid("21a0b93e-b81a-4dca-9a2d-97414015e992"), false, 87, "ابنه فوق ال 25 استثناء تخفيض", 11.0m },
                    { new Guid("25881f9a-0c87-4add-962c-de7be1d3a584"), false, 79, "زوجه شباب ورياضه", 0.0m },
                    { new Guid("29751f63-4052-46ce-98f1-ff72841af538"), false, 28, "ابن الزوجه تحت 16", 3.0m },
                    { new Guid("2bbdd217-6a9c-4dfa-8a89-70e1d459ef11"), true, 52, "ابن اخ تخفيض", 11.0m },
                    { new Guid("3ad4a9de-361d-4f3e-8d14-4d874cd05c40"), false, 37, "اخت الزوجه", 22.0m },
                    { new Guid("423872f9-9007-47be-b56e-c5f0227efcd6"), false, 68, "زوجه عضو فوق ال 60", 2.0m },
                    { new Guid("4274ce66-7b53-411d-85d7-48583a054463"), false, 58, "عم تخفيض", 11.0m },
                    { new Guid("44abfb06-0f46-41cc-97a1-12dc026ff8c4"), true, 65, "حفيده تخفيض", 11.0m },
                    { new Guid("44d81ac5-a7ae-423f-9fd2-b760607a946a"), true, 31, "ابن الزوج فوق ال 16", 6.0m },
                    { new Guid("470871a0-e656-4fec-b456-e5a302ac11ac"), false, 18, "عم", 22.0m },
                    { new Guid("4aeedd9e-fe0b-448e-9a69-85567599fd98"), true, 14, "ابن اخت", 22.0m },
                    { new Guid("4bd6b648-8db6-4e0a-bdcd-4876fe5215d8"), true, 47, "بنت فوق الـ 16 تخفيض", 3.0m },
                    { new Guid("531df614-869f-4c3c-9d93-74eeed98d2c8"), false, 73, "ابن الزوج تحت 16 تخفيض", 1.5m },
                    { new Guid("54471b42-ea7a-40eb-b5f3-0af46123f677"), false, 49, "زوجه ثانيه تخفيض", 11.0m },
                    { new Guid("572d0365-8bda-46d6-9f3c-54937028924f"), false, 69, "زوج عضوه فوق ال 60", 2.0m },
                    { new Guid("5ad59e44-8192-4f88-a9e6-52a9282a7cb3"), true, 33, "بنت الزوجه فوق 16", 6.0m },
                    { new Guid("6509f969-8057-4a86-b3e6-d3c01e418fae"), true, 24, "حفيد", 22.0m },
                    { new Guid("673d8930-284f-4207-a633-224ecb8da946"), true, 74, "ابن الزوج فوق 16 تخفيض", 3.0m },
                    { new Guid("683951d1-e153-4093-a496-7a3d7263645c"), true, 54, "ابن اخت تخفيض", 22.0m },
                    { new Guid("6953377e-ff19-4d38-9220-816fd1311f04"), true, 35, "بنت الزوج فوق ال 16", 6.0m },
                    { new Guid("6ae11b67-a2a3-457b-98d0-ab1f1a2f2e23"), false, 48, "بنت تحت الـ 16 تخفيض", 1.5m },
                    { new Guid("6bbfb87a-cc3f-4f01-bec9-b0c5f8e8f118"), true, 5, "إبن", 10.0m },
                    { new Guid("6d147227-07fe-4563-bf46-6735fe5a5f1c"), true, 26, "ابن بالتبنى", 22.0m },
                    { new Guid("73bafe0c-fea6-44ba-9dc8-3524c11791e4"), false, 17, "خاله", 22.0m },
                    { new Guid("757dc3cb-be23-470a-bbcf-e115e35cd96a"), false, 16, "خال", 22.0m },
                    { new Guid("76e79712-edbf-4f2c-b8f2-5d3e6e426324"), false, 42, "والده تخفيض", 11.0m },
                    { new Guid("7944278d-9be5-4517-af95-49f6edd706d5"), true, 66, "ابن بالتبنى تخفيض", 11.0m },
                    { new Guid("79cda6aa-5794-4a72-b70e-7435fd3e02d7"), false, 86, "ابن فوق ال 25 استثناء تخفيض", 11.0m },
                    { new Guid("7aefcfc0-dd23-40a6-ae85-92574deb2a4a"), true, 50, "اخ تخفيض", 11.0m },
                    { new Guid("7bb7fdbf-e2cb-479f-8456-4a8ba5c9ade5"), false, 44, "زوج تخفيض", 4.0m },
                    { new Guid("8133624e-c677-493c-8403-fd4bbf9153e5"), true, 21, "بنت عم", 22.0m },
                    { new Guid("8239e143-d0a7-4b5e-91fe-cd82f46c5172"), true, 64, "حفيد تخفيض", 11.0m },
                    { new Guid("82eaa885-a102-41c6-a898-54192fda2405"), true, 67, "بنت بالتبنى تخفيض", 11.0m },
                    { new Guid("8484d3e0-3fb9-408c-a887-30c02432c965"), false, 30, "ابن الزوج تحت ال 16", 3.0m },
                    { new Guid("84a89810-a620-4270-9e25-b09b5424f55c"), true, 72, "ابن الزوجه فوق الـ 16 تخفيض", 3.0m },
                    { new Guid("84c02d9f-e7ca-41d3-b3dd-e365af48053a"), true, 23, "بنت خاله", 22.0m },
                    { new Guid("85f5f1b3-606c-479d-ac8b-2bcc8b443992"), false, 84, "زوج عضوه شباب ورياضه", 0.0m },
                    { new Guid("88c42880-5798-4ee0-a47d-c762cf70c8c7"), false, 19, "عمه", 22.0m },
                    { new Guid("910cb786-3f3c-4fa0-94a2-a1e87f742249"), false, 46, "ابن تحت ال 16 تخفيض", 1.5m },
                    { new Guid("953b356d-56e9-426e-857f-b7a96f38e193"), true, 7, "بنت", 10.0m },
                    { new Guid("96c1960b-c3ab-4659-84b2-5bd83cfc6520"), true, 6, "إبن", 10.0m },
                    { new Guid("985e5d0c-8de2-4c39-b083-6ae9b2d22290"), true, 80, "أخ الزوجه تخفيض", 11.0m },
                    { new Guid("99e9c462-f1c5-4d6e-9b28-c23e36d7531e"), false, 43, "زوجه تخفيض", 4.0m },
                    { new Guid("9ac55f18-5940-4ecf-9345-425a3dfd4ca8"), false, 75, "بنت الزوجه تحت الـ 16 تخفيض", 1.5m },
                    { new Guid("9b8c4984-aa9a-4c9a-96b2-19926728aca3"), true, 38, "اخ الزوج", 22.0m },
                    { new Guid("9bc61c09-c743-45aa-b080-69cd299fadfa"), false, 41, "والد تخفيض", 11.0m },
                    { new Guid("9c2c90e7-0f02-42e4-8206-0d65b39cf4a9"), false, 56, "خال تخفيض", 11.0m },
                    { new Guid("9dc91991-c30d-4df2-87d8-23ce11f99916"), false, 34, "بنت الزوج تحت ال 16", 3.0m },
                    { new Guid("9e1a2b80-b5b5-4818-91ee-8974bebb1e63"), false, 32, "بنت الزوجه تحت 16", 3.0m },
                    { new Guid("9ebf83fb-5706-4495-870b-89993d6cde36"), true, 45, "ابن فوق ال 16 تخفيض", 3.0m },
                    { new Guid("a656be68-1b0b-4708-8374-608783b2b20b"), false, 59, "عمه تخفيض", 11.0m },
                    { new Guid("a74a894d-1aa0-41db-8edc-266c7d4e2166"), true, 8, "بنت", 10.0m },
                    { new Guid("a8ac35be-bc9e-4c18-8b56-e2f4f23c656a"), true, 76, "بنت الزوجه فوق الـ 16 تخفيض", 3.0m },
                    { new Guid("ab378d74-29d5-4f28-b44b-d62c132073d5"), false, 2, "والدة", 15.0m },
                    { new Guid("af954ef5-9503-46bf-b0c9-d957fdcc2da0"), true, 78, "بنت الزوج فوق ال 16 تخفيض", 3.0m },
                    { new Guid("b355548d-77b3-458d-bf3a-9ccb0aadb294"), false, 9, "زوجة ثانية", 40.0m },
                    { new Guid("b36e9b3f-6760-4f3d-b6a7-16e935e258e7"), false, 81, "اخت الزوجه تخفيض", 11.0m },
                    { new Guid("b3d3c54d-b8df-4a9d-b633-c63ba02a1091"), false, 4, "زوج", 15.0m },
                    { new Guid("b3de94ad-1ddf-4475-a650-7c56e8e70eaa"), false, 70, "زوجه محاربين قدماء", 0.0m },
                    { new Guid("b48ed898-dc22-4889-aac2-06bf2e09fc0e"), true, 12, "أخت مطلقة", 15.0m },
                    { new Guid("b7f13ed4-c5e2-48e7-bf6d-acf7f3525a67"), true, 27, "بنت بالتبنى", 22.0m },
                    { new Guid("b8073380-6363-419f-adb6-61b55f70e19f"), true, 55, "بنت اخت تخفيض", 11.0m },
                    { new Guid("ba50a91c-3684-4f5a-8f52-7907bab29943"), true, 53, "بنت اخ تخفيض", 11.0m },
                    { new Guid("bc5a0d65-4cb7-4a2a-8355-ecfccbd88f1a"), true, 62, "ابن خاله تخفيض", 11.0m },
                    { new Guid("c3e904b4-196e-48cb-9df3-eb153d916440"), false, 51, "اخت تخفيض", 11.0m },
                    { new Guid("c7887a3b-cc40-4f0c-880d-adcdd775f1eb"), true, 22, "ابن خاله", 22.0m },
                    { new Guid("c92608e6-1f90-4fd2-978e-0a488b9ea71e"), true, 25, "حفيده", 22.0m },
                    { new Guid("c9e72297-bef4-4a96-beb7-4cb72726793a"), true, 63, "بنت خاله تخفيض", 11.0m },
                    { new Guid("ce50713f-cdac-48fe-863a-35d502f26dbb"), false, 10, "أخ", 0.0m },
                    { new Guid("cfbd065e-8a87-465d-a50e-2501f2b6b166"), false, 77, "بنت الزوج تحت 16 تخفيض", 1.5m },
                    { new Guid("d561339d-ca59-4ba6-9393-97e6772cbec2"), true, 20, "ابن عم", 22.0m },
                    { new Guid("e212265b-f883-44f1-96d4-7ee5475f2cfa"), true, 15, "بنت اخت", 22.0m },
                    { new Guid("e507b0c4-0600-4ba5-aee3-270b3e12d109"), false, 11, "أخت", 15.0m },
                    { new Guid("e7738fc7-5229-426c-a330-277b63b301d2"), false, 85, "ابنه فوق 25 سنة استثناء", 22.0m },
                    { new Guid("ea06e3ec-0aaf-4f52-a160-7a60f4d1b1b5"), false, 40, "ابن فوق 25 سنه استثناء", 22.0m },
                    { new Guid("ea6d1ee0-5b85-43a1-a81b-ca97a687349d"), false, 71, "ابن الزوجه تحت الـ 16 تخفيض", 1.5m },
                    { new Guid("ead8eb5d-565d-43b9-b3ad-1a9828dd2711"), true, 36, "اخو الزوجه", 22.0m },
                    { new Guid("ec46a654-4f17-4a1d-a71f-6f5b58b63af7"), true, 60, "ابن عم تخفيض", 11.0m },
                    { new Guid("f10c4934-22d4-4926-80e6-885b270a861e"), true, 61, "بنت عم تخفيض", 11.0m },
                    { new Guid("f4ccc50b-253a-4f2c-b4ef-7d178a90f29a"), false, 1, "والد", 15.0m },
                    { new Guid("fb2a0894-d45a-413e-924e-ae3a3c7bff1d"), true, 29, "ابن الزوجه فوق ال 16", 6.0m }
                });

            migrationBuilder.InsertData(
                table: "TransCodes",
                columns: new[] { "TransId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("2fd40f35-a9d9-4940-909a-9b113803a834"), 2, "الزواج" },
                    { new Guid("50904027-59a8-484a-95fa-e613aeea51a3"), 3, "الطلاق" },
                    { new Guid("67484eff-1864-4a26-b5b1-34ebb9a68bf1"), 5, "التخرج" },
                    { new Guid("7ac5674c-c3a0-4610-92fe-14189e54c2bb"), 1, "بلوغ السن القانونية" },
                    { new Guid("82630ad6-e01d-4cac-b113-44a1b8f993c1"), 7, "طبقاً للائحه" },
                    { new Guid("fcbf248e-f616-473a-93ab-e0cd02292a35"), 6, "بناء على رغبة صاحب العضوية" },
                    { new Guid("feb59821-1e5c-4248-ad7a-b7b3a175eb5b"), 4, "الوفاة" }
                });

            migrationBuilder.InsertData(
                table: "cityCodes",
                columns: new[] { "CityId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("009541de-d482-4522-9fd0-b22c2c872bf0"), 39, "جنوب سيناء" },
                    { new Guid("06dcf5cd-0a3f-4f96-9eb9-56f0190c53e3"), 15, "الفيوم" },
                    { new Guid("07240bde-4e8f-4ebc-ac27-54502500b5fb"), 11, "شبرا الخيمه" },
                    { new Guid("10d447e0-1185-4cbe-852d-34ace2b4bb76"), 33, "بنها" },
                    { new Guid("18cfc55b-c89a-44e6-a4b4-0d116dde5096"), 12, "سوهاج" },
                    { new Guid("18da8b77-bbd0-4f97-965e-610339b088ed"), 20, "الاسماعلية" },
                    { new Guid("1a715319-6bb5-4ef1-a332-55280e099894"), 34, "السويس" },
                    { new Guid("24c418e7-86d8-4834-82e3-19ec2e4094d4"), 18, "الفيوم" },
                    { new Guid("267bbbe3-a007-4478-8965-7d0646a37c20"), 23, "بورسعيد" },
                    { new Guid("2958e058-f4f7-487c-a2fd-ad088903e2f3"), 30, "كفر الشيخ" },
                    { new Guid("29c38916-a083-4cba-8260-0baa7517a782"), 21, "الدقهليه" },
                    { new Guid("2eea0440-d110-430a-90bf-6d6798595898"), 28, "الاقصر" },
                    { new Guid("3722ac05-4590-4c91-8958-488850847ff1"), 31, "المنصوره" },
                    { new Guid("45378d93-09d1-4a63-91fa-48cbd416f0a9"), 35, "اسوان" },
                    { new Guid("46f9a402-6504-429f-b8d7-c6d9a5baf0a8"), 6, "مرسى مطروح" },
                    { new Guid("4d115be2-fde6-489d-869a-e54337df436e"), 24, "طنطا" },
                    { new Guid("525820bb-6a1d-4875-8824-59dd00ac1412"), 32, "قنا" },
                    { new Guid("5e1df4ff-fa4f-4d06-bbc1-e40639ab5374"), 29, "المحله" },
                    { new Guid("634cd61a-7a14-4a29-9816-c8274de8be71"), 2, "الجيزة" },
                    { new Guid("636a12f7-5b0a-404c-8485-5ed677716e71"), 36, "شبين الكوم" },
                    { new Guid("6c3dd9eb-6000-4469-8795-8b680edcb80b"), 4, "الشرقية" },
                    { new Guid("6e9dfb6e-f153-4958-8213-143f633cc14c"), 40, "الامارات" },
                    { new Guid("7536bc70-8ac5-4728-9a4f-59124aae6293"), 1, "القاهرة" },
                    { new Guid("778e620b-2c3a-4b08-a799-f97674b164a5"), 37, "القاهره" },
                    { new Guid("82bd8a78-940f-46ee-a240-85de6a76de4a"), 27, "الوادى الجديد" },
                    { new Guid("82d4e3b6-fb60-4719-b529-5c628e27ff4f"), 17, "المنيا" },
                    { new Guid("93e45f77-9914-4e17-abe4-2122d85ce7d6"), 38, "طهران" },
                    { new Guid("9844498a-33c0-4ca4-a605-25c3f228000c"), 22, "قليوب" },
                    { new Guid("9c381cc6-8344-4314-9437-bbeb11a81291"), 7, "دمياط" },
                    { new Guid("ae8d5e41-9a1f-4920-a117-eb8b0de7e525"), 14, "بنى سويف" },
                    { new Guid("b88b57e3-9cde-4a75-b06c-95d7947b0053"), 3, "البحيرة" },
                    { new Guid("ba1ec23c-3c49-4ec7-b5c9-91150334b87c"), 10, "القليوبية" },
                    { new Guid("bdbbe8c9-f77d-4ad7-b193-706ebcc39616"), 41, "البحر الاحمر" },
                    { new Guid("c814befe-1fd2-458e-86c1-4c9c1dd4c793"), 42, "القاهرة" },
                    { new Guid("cdd40b00-6995-4a1f-9431-4645ed7d1cbb"), 25, "الاسكندريه" },
                    { new Guid("ce36d38f-13b6-4d6f-bf97-32dd1b29c6fa"), 16, "اسيوط" },
                    { new Guid("dfd2e4c3-6581-4e2d-829b-ad74a3363ce8"), 19, "الغربيه" },
                    { new Guid("e01e75cb-e663-4728-8e3e-f99d5916c350"), 5, "المنوفية" },
                    { new Guid("e0a69a1b-25f4-4f81-8078-4f5b90f0bdaf"), 13, "ميت غمرة" },
                    { new Guid("e226e5ae-59a1-4c97-a48c-d9a5cc945018"), 8, "امبابه" },
                    { new Guid("e9a6ff1e-5ee2-4d6e-94ec-826ada54534c"), 26, "دمنهور" },
                    { new Guid("f51dd3e8-3c98-4017-8aa0-62a3a2c1e594"), 9, "البساتين" }
                });

            migrationBuilder.InsertData(
                table: "genderCodes",
                columns: new[] { "GenderId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("38eff8ef-adb0-4b2f-85a3-f37164fb2ce1"), 2, "أنثى" },
                    { new Guid("a01bb913-31c8-4e5d-848b-c9e288310a3c"), 1, "ذكر" },
                    { new Guid("b6cacf0e-eec4-4b08-a92c-9359d287cf36"), 3, "غير معروف" }
                });

            migrationBuilder.InsertData(
                table: "jobCodes",
                columns: new[] { "JobId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0783984f-b961-454a-aca9-442ed5369fa9"), 55, "لحام" },
                    { new Guid("0a2dd510-285e-456e-81ca-0258160d2f2d"), 301, "محامي" },
                    { new Guid("0b46df92-a8c9-41ff-8cd3-dd67ccdb3537"), 54, "نجار" },
                    { new Guid("11560d59-b426-4147-a24d-6af60525e7d6"), 0, "خدمات معاونه" },
                    { new Guid("1358577c-2be9-40de-87c8-9c07c4828f11"), 4, "معاش" },
                    { new Guid("1cc344c9-8f3b-4fae-a050-ee48a4be3948"), 104, "هندسة الاشارات" },
                    { new Guid("1cd19904-a616-48e2-a2ea-54ebc583bc19"), 300, "اداري" },
                    { new Guid("1cefb3a0-6939-4b7d-a87c-bb0841c801f0"), 109, "رئيس قسم" },
                    { new Guid("1ea2e84a-74f0-4eb5-b7a3-699e7a623671"), 200, "مراقب ابراج" },
                    { new Guid("2923f60e-e820-491a-9d8c-b230822e2398"), 81, "ن . مالية" },
                    { new Guid("3f06b295-ccdd-4503-b794-b84f89c85575"), 50, "سائق" },
                    { new Guid("4559f67d-d1b4-4416-98dc-2824f3ea125b"), 107, "كاتبة" },
                    { new Guid("4baf9798-396e-4267-8475-6b9ef519707b"), 157, "حداد" },
                    { new Guid("4bb8ba36-0b44-42ba-8a8d-7a86e5f83e14"), 80, "أخرى" },
                    { new Guid("537e4c22-d1c9-49bf-ab45-03c369094ed3"), 6, "مهندس" },
                    { new Guid("57eb5078-3a41-4771-a8a7-5724de11e7fd"), 267, "رئيس قطار" },
                    { new Guid("5af163cf-4257-4630-80ca-6ab58373d773"), 103, "اشارات مصر" },
                    { new Guid("5b19aa4b-2fa2-49fc-b1cf-108173460057"), 7, "دكتور" },
                    { new Guid("5b232db8-9ef6-4dc9-997d-c62754461a26"), 61, "فحص مالى" },
                    { new Guid("5cd941e1-f8d1-4cca-a002-ba1c7de1f9ae"), 402, "نائب رئيس مجلس الاداره" },
                    { new Guid("5e105c5c-c2cd-4aa8-9772-fe19a0b3b409"), 30, "ملاحظ" },
                    { new Guid("66cfa577-ed8f-4722-adf7-a2a3764263a5"), 52, "نقاش" },
                    { new Guid("68f28c85-cf7c-46a0-8e21-41f6654ecbea"), 5, "محاسب" },
                    { new Guid("7a3abca0-e4db-4bed-91de-5074cbe745a0"), 202, "مضيف قطار" },
                    { new Guid("7b7ad2e3-1763-4b4b-ba34-b23a42b56cd5"), 70, "مراقب" },
                    { new Guid("7f1d7c8b-b9c1-4d5a-b7fd-4107ea1cba8c"), 158, "حرفى" },
                    { new Guid("82c9b89d-ada7-4c2e-b062-d255aa6d81f6"), 23, "فنى" },
                    { new Guid("84ade46d-4349-45e3-9949-a8ba5b30ec4c"), 389, "مساعد قائد قطار" },
                    { new Guid("8845c82d-c9d9-420e-b48f-f8936194bac2"), 401, "محقق قانوني" },
                    { new Guid("88a57bb9-ebf8-4b00-a48d-5ce7f64b6093"), 403, "رئيس إدارة مركزية" },
                    { new Guid("8cae9526-edd6-4b6e-bf74-7f9c0f5c42c8"), 20, "ميكانيكى" },
                    { new Guid("8f2b6104-b509-4803-96f8-63a0deb1b25b"), 500, "مفتش" },
                    { new Guid("90a34396-44bf-4b4d-8dae-3414e0acbc29"), 102, "امين مخزن" },
                    { new Guid("92c1a1a9-68fa-4782-9ab1-9deb54b354a0"), 56, "صراف تذاكر" },
                    { new Guid("94c21495-3687-49f4-bce7-6baed26d1d16"), 2, "الموارد البشريه" },
                    { new Guid("95c4a099-bdef-4aad-8c1d-a179f0e14252"), 100, "كاتب" },
                    { new Guid("9bfbc900-9521-4882-b556-389d9b97f0b6"), 106, "كاتبة" },
                    { new Guid("9ebe15a5-5cca-49e3-b961-b08ca7614c10"), 51, "كهربائي" },
                    { new Guid("9fa16568-9d27-4da9-893c-e97a8469b592"), 21, "خراط" },
                    { new Guid("a01494dc-472c-4dc1-a307-e2bc3e41bf8b"), 3, "قطاع البضائع" },
                    { new Guid("a62afa78-f26c-44a2-bc09-5ee8daab2f8c"), 396, "قائد قطار" },
                    { new Guid("aa53f520-4cc5-453b-a480-e1dcf945370e"), 53, "سباك" },
                    { new Guid("ac31dc5a-3b54-48b2-a613-e45eeafdaf6f"), 1, "المالية" },
                    { new Guid("b3bb4e81-d128-445d-af31-58c71ff196b6"), 60, "ناظر محطه" },
                    { new Guid("b7a359a8-68ab-4d05-b8b0-2398d643a98f"), 121, "بناء افران" },
                    { new Guid("c20b3336-0e26-4a05-87c3-cc8ee5cf86e8"), 57, "تمريض" },
                    { new Guid("c25447e2-ed26-4505-b1ee-db50d7428596"), 201, "سروجى" },
                    { new Guid("c255ac95-1f88-4b6d-ad15-3097182f867c"), 203, "طباع" },
                    { new Guid("d48d7dae-032c-461a-a85c-6890128b24ba"), 180, "عامل" },
                    { new Guid("d4e60bf8-3e9b-4340-a400-e78bc5021544"), 58, "موظف" },
                    { new Guid("d828e2b3-09a7-4a72-872a-5819deffafb6"), 111, "رئيس حركه" },
                    { new Guid("e2c1868e-a240-4f8e-9e90-0f8d89060005"), 59, "مشرف قطار" },
                    { new Guid("e4e1cb9d-137a-4c2f-bf80-275418caf551"), 101, "مدير عام" },
                    { new Guid("e8092075-ee75-43e8-ae85-ddcb56cc999f"), 26, "ملاحظ" },
                    { new Guid("f7d52487-9c6e-443e-93c6-8b2bddc592ed"), 400, "مدير ادارة" },
                    { new Guid("feadcab5-94cc-4a12-8229-a0df3e1e24f3"), 110, "براد" }
                });

            migrationBuilder.InsertData(
                table: "martialStatusCodes",
                columns: new[] { "MartialStatusId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0ea4f976-1178-482d-818c-81edb1cd7184"), 3, "مطلق/ة" },
                    { new Guid("3beffca8-e182-486e-82ad-1bb89bd6142e"), 4, "أرمل/ة" },
                    { new Guid("c39918dc-ee43-4d6d-88b6-9e13f338d9a9"), 2, "متزوج/ة" },
                    { new Guid("d1a67026-f19c-4521-ae7b-4cf2a425f20e"), 1, "أعزب" }
                });

            migrationBuilder.InsertData(
                table: "membershipCodes",
                columns: new[] { "MembershipId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("0e907e7a-e30e-4ad7-8335-54fea461958f"), 3, "عضوية فخرية" },
                    { new Guid("1b3cecc4-cbab-40b2-9eb6-f6fd4ee32adf"), 2, "عضو عامل خ" },
                    { new Guid("6f96f34f-c1ab-4fcb-83cb-503ab24d912f"), 8, "عضويه موسمية" },
                    { new Guid("84f2e487-f82a-4a67-8cf6-4475fa29cbd4"), 9, "عضو زائر  (مؤقت)" },
                    { new Guid("958ddaeb-3f45-402d-8000-84d7b0cf9e37"), 10, "عضو زائر" },
                    { new Guid("a9e48d2c-99e0-46cb-8105-e24c2d684508"), 1, "عضو عامل" }
                });

            migrationBuilder.InsertData(
                table: "nationalityCodes",
                columns: new[] { "NationalityId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("13e9c482-421e-465e-88e0-1a36bec29b83"), 2, "سعودى/ة" },
                    { new Guid("6b80e1fe-be90-480d-869b-5d0efaeb4b61"), 3, "كويتى/ة" },
                    { new Guid("85422937-2c0b-4a90-8a9f-3a842b573b03"), 4, "إماراتى/ة" },
                    { new Guid("b56380cf-662f-4d8f-87f3-180b4b12aac7"), 1, "مصرى/ة" }
                });

            migrationBuilder.InsertData(
                table: "religionCodes",
                columns: new[] { "ReligionId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("4e11b66c-8c42-4639-a91d-6b8d83d86cd7"), 2, "مسيحى/ة" },
                    { new Guid("5ee4ce09-ff48-4127-88f3-2ecc9d832f0a"), 1, "مسلم/ة" },
                    { new Guid("ea0a357a-a5fe-4310-a219-0edcd3aa8430"), 3, "أخرى" }
                });

            migrationBuilder.InsertData(
                table: "sectionCodes",
                columns: new[] { "SectionId", "Annual", "Code", "ComPenalty", "Donation", "Id", "Improve", "Init", "Maintenance", "Name", "Office", "Penalty", "Player", "Pool", "Post", "Reg", "ReserveFee", "River", "Society", "Stamp", "Worker" },
                values: new object[,]
                {
                    { new Guid("0371dad7-0d20-4661-9ec3-593b17b16117"), false, 93, false, false, false, false, false, false, "الفحص", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("05e86262-b9cf-41c2-8d16-32d0eb1fa1e0"), false, 88, false, false, false, false, false, false, "اداره الهيئه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("08bc35d3-b658-4e36-ad8e-41e8ea8111b3"), false, 6, false, false, false, false, false, false, "رئاسة الهيئة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("0dc94d17-605d-4e98-9cbf-02cc82287061"), false, 28, false, false, false, false, false, false, "الخدمات المشتركه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("0ee39414-b979-4793-975f-3fc8bc3ddddf"), false, 7, false, false, false, false, false, false, "ورش", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("170703ed-3503-4f5b-b8b4-f9142176e12d"), false, 79, false, false, false, false, false, false, "عربات الركاب", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("27c56576-9e45-4d33-b012-29e89b2796f0"), false, 94, false, false, false, false, false, false, "قطاع الصيانه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("2ac92fb5-a0bd-45cc-a6d2-eb7cc28ae2ba"), false, 51, false, false, false, false, false, false, "مؤقته", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("2bac4d63-cdd8-471d-bd6c-312c4fb388a8"), false, 83, false, false, false, false, false, false, "ابو راضى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("2d580936-44d0-46bd-b80d-9647c49ee1ca"), false, 40, false, false, false, false, false, false, "ابي غاطس", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("32792757-c916-4567-bff5-f67ee2fa33b3"), false, 33, false, false, false, false, false, false, "المسافات الطويلة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("3a802710-2ae0-4803-9630-9c1761cc7cf9"), false, 27, false, false, false, false, false, false, "ادارة مالية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("41ec20d0-c492-4b93-afb3-d2ffa543ae2a"), false, 12, false, false, false, false, false, false, "فرز القاهره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("45d9fd16-892b-4575-baf6-e98cc54d6a27"), false, 32, false, false, false, false, false, false, "التشغيل", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("46a3ca2e-54fd-4d17-b41e-99880848809b"), false, 86, false, false, false, false, false, false, "اداره النقل", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("46eb5f88-f222-4f6e-b1b4-667c35ce71d6"), false, 13, false, false, false, false, false, false, "هندسه السكه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("4a785eeb-0b0e-43a5-b8cb-d017f3830781"), false, 75, false, false, false, false, false, false, "قطاع البضائع", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("4d86058a-8d38-416d-aa09-d5690579417c"), false, 31, false, false, false, false, false, false, "الكبارى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("57b1ee02-116d-44fe-897c-ded5b31e4867"), false, 52, false, false, false, false, false, false, "مخازن", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("5f2d0008-39e9-4868-8dc2-7c18af14c386"), false, 89, false, false, false, false, false, false, "الاملاك", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("621dc6bd-d113-4721-8505-6fb81b1c0a26"), false, 25, false, false, false, false, false, false, "الاشارات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("650cc4a7-0415-44df-b93a-c70a00fa74ed"), false, 95, false, false, false, false, false, false, "حاسب الى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("689cd469-b920-438b-9778-1064c71a19ae"), false, 84, false, false, false, false, false, false, "المعدات الثقيلة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("705668f0-b995-4779-bb4c-5a4a37919872"), false, 63, false, false, false, false, false, false, "مراقب ابراج", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("74153a71-74d3-4083-b90f-df2d716b11cd"), false, 42, false, false, false, false, false, false, "د.بولاق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("7838f77f-a101-49c9-b8b3-4f4a611d3992"), false, 29, false, false, false, false, false, false, "ادارة المحطات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("7cb2dfe6-d214-42a0-a639-a9e626ecbb1e"), false, 2, false, false, false, false, false, false, "رئيس مجس الإدارة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("80f821ef-0eb0-4611-870c-f50f10fb225a"), false, 26, false, false, false, false, false, false, "المركز الطبي", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("83cb08a0-f618-46f2-bf2a-47ff40a83ce1"), false, 43, false, false, false, false, false, false, "السلامه و الجوده", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("841a2a53-f8cd-4d26-882f-8c968ccaa53b"), false, 19, false, false, false, false, false, false, "موسميه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("85a3c64a-6106-44df-837c-c712c5a12385"), false, 80, false, false, false, false, false, false, "سيارات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("86f5ea25-dc44-402e-b3e9-a4bc6aa12d3d"), false, 16, false, false, false, false, false, false, "عباسية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("88551076-4e79-4ebe-b13b-1f44a835d34b"), false, 35, false, false, false, false, false, false, "خدمه العملاء", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("89080a94-5f0a-46cc-a416-3bacb51044c4"), false, 66, false, false, false, false, false, false, "اداره السيارات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("8bfc30c7-3bd1-4e4c-8205-d6c5608bd14b"), false, 60, false, false, false, false, false, false, "نائب رئيس مجلس إداره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("8c12a4d5-bd28-472d-8b3a-8750745975b6"), false, 81, false, false, false, false, false, false, "رئيس الشئون القانونية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("8e9cdf45-c951-4076-9608-4e34eb874b7e"), false, 18, false, false, false, false, false, false, "المشروعات والتطوير", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("9419207d-c4f0-4cfe-b368-065c6edb69df"), false, 87, false, false, false, false, false, false, "عنابر بولاق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("95067bb9-b07e-4cb5-86d1-d14a531f072e"), false, 77, false, false, false, false, false, false, "ديزل كوبري الليمون", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("96728ab8-ed48-4ce2-8faa-6a540859b23b"), false, 34, false, false, false, false, false, false, "المسافات القصيرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("9e39bf4d-4101-4fcb-9ad6-9cb9ca2cecca"), false, 44, false, false, false, false, false, false, "مخازن", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("a103fd87-4679-47f9-b962-f23c8ecf4000"), false, 71, false, false, false, false, false, false, "بنك القاهرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("a6dc5b48-67db-4a26-9205-3cb8ea5f4a68"), false, 5, false, false, false, false, false, false, "مترو", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("a72bb318-c83e-4fe5-89fb-2d91262f38dc"), false, 8, false, false, false, false, false, false, "مطابع", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("a78e1059-8d0c-4191-93d4-b009658d5ced"), false, 15, false, false, false, false, false, false, "حركه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("aa89b371-c234-42cf-80a2-99911c60a7c6"), false, 85, false, false, false, false, false, false, "شئون قانونيه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("ab3a8eaf-4292-4be4-89df-35cd47de7a29"), false, 41, false, false, false, false, false, false, "د.طرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("ab8a6f4a-34aa-4ccb-a1c5-db3e8ced6ff4"), false, 20, false, false, false, false, false, false, "بولاق الدكرور", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("b18675bb-934c-4a71-a399-4b5ccfdf836e"), false, 54, false, false, false, false, false, false, "مخازن", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("b5c656fb-d338-487a-b79c-9b2a94d13b9d"), false, 24, false, false, false, false, false, false, "مدير هيئة سابق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("b8211d60-24de-413a-81db-307f744d02c3"), false, 30, false, false, false, false, false, false, "المنشأت", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("b9994ccb-2ff2-4300-804d-3f4a85642596"), false, 70, false, false, false, false, false, false, "البنيه الاساسيه", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c0126381-e254-4f76-bcf3-589dcb03357f"), false, 90, false, false, false, false, false, false, "ديزل الزقازيق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c02c704d-a475-4be0-88ea-f66cfcd0aa5c"), false, 14, false, false, false, false, false, false, "منطقه القاهره", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c409cd9d-49f5-4aa2-ac2c-b297ef773b2c"), false, 99, false, false, false, false, false, false, "مبيعات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c610f69c-bb44-48fc-b3b6-ac0355f5dcb2"), false, 9, false, false, false, false, false, false, "ابو زعبل", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("c73d30f4-4908-4a1a-ad13-405c8f5cf993"), false, 4, false, false, false, false, false, false, "مستشار الوزير", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("cd62f919-1901-4e11-8983-cf61e7ae2911"), false, 10, false, false, false, false, false, false, "التبين", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("d5e0c048-d78f-43e7-b811-eacf90569a11"), false, 1, false, false, false, false, false, false, "عضوية زائرة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("db94ee0e-5756-413b-8a3d-7f501a9bbb51"), false, 76, false, false, false, false, false, false, "دعم فنى", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("dba99fe3-5006-4cd6-838b-46f47ab99b24"), false, 0, false, false, false, false, false, false, "0", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e67fe84d-2952-4ec5-888d-41cb9e5f566c"), false, 64, false, false, false, false, false, false, "الموارد البشرية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e7b2e57f-d401-4a28-aa45-773c3a0307cd"), false, 21, false, false, false, false, false, false, "الوحدات المتحركة", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("e829b8d2-71f0-4e30-8b64-b961d81a379f"), false, 55, false, false, false, false, false, false, "اداره التنسيق", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("ea8ad93d-9816-411f-b75f-27172f3263a3"), false, 17, false, false, false, false, false, false, "م.الالكتروني", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("efc2d9dc-e0a4-4897-bd65-6c366cd0d0cf"), false, 50, false, false, false, false, false, false, "الادارة القانونية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("f0d48b5d-0ba5-44dd-b8d2-d26cc9e3960d"), false, 74, false, false, false, false, false, false, "الادارة المركزية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("f4056bab-7e63-4c07-a0a4-1c4485dc07ea"), false, 61, false, false, false, false, false, false, "ابى غاطس", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("f52bbeb6-e0e9-4b18-8da3-1911acf83cfa"), false, 3, false, false, false, false, false, false, "معاشات", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("fe7b823e-914a-4d16-943d-e0af65299c66"), false, 73, false, false, false, false, false, false, "كهرباء السبتية", false, false, false, false, false, false, false, false, false, false, false },
                    { new Guid("ffcd9db6-e01f-4239-a340-3e70c3ab5d2f"), false, 11, false, false, false, false, false, false, "ديزل القاهره", false, false, false, false, false, false, false, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "titleCodes",
                columns: new[] { "TitleId", "Code", "Name" },
                values: new object[,]
                {
                    { new Guid("118bc7ee-d5d0-4b08-98a8-0bc51494f4ba"), 1, "السيد/ة" },
                    { new Guid("95f32e89-54d4-40fb-a61c-4b2c11a35043"), 2, "أستاذ/ة" },
                    { new Guid("da0b2927-37f0-4bd8-9038-75662ea78bbe"), 3, "دكتور/ة" }
                });
        }
    }
}
