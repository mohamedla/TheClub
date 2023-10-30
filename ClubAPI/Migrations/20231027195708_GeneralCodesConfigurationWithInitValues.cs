using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubAPI.Migrations
{
    /// <inheritdoc />
    public partial class GeneralCodesConfigurationWithInitValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
