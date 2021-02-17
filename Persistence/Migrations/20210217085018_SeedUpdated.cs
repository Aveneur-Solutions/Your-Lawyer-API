using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("288e9227-7493-43df-90a8-18c9089cfbfb"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("3e793fa2-4d40-4936-95d1-6dad4bb57c23"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("4edafffe-dff6-47f7-95f8-23a76c728e22"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("66166738-a313-4d0d-86dc-fe32be749923"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("6a46f61d-6368-441c-a934-7382cc41dbfb"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("79f89c40-cda3-4b6c-94a1-1c4aebd1baea"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("85762f94-9412-4181-b63a-34b82c15847e"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("fb7af680-856b-42b5-998f-9db17687d4fa"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("097ceb1e-413f-40c6-b938-f61ce759d46d"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("44a809a1-7c53-4522-a312-3a5cbf3e94fe"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("4a2b9bee-284a-4654-95ff-439863ff8898"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("593d1c90-7161-4b84-b349-0001bc1e4f4a"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("886786ce-0361-4e26-bd92-a423c0862fb3"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("994c68fa-5553-49a5-b64f-64189e0d8065"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("c8c3de00-4a31-44c4-a5be-696192c64f07"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("ec7bdf75-de26-4fc2-9be0-a108e36f367c"));

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("d9f5daa3-95bb-4a95-a62c-9ec628d73bf6"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("b0a3a29c-296b-413b-991f-26afe35202bb"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("b42bf1af-cd96-4fb7-9754-d4ac6ceb6995"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("f460f4f5-5336-42a4-b617-08cfa47add96"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("f4b69be2-d765-480d-a129-199b79e7f324"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("de7be798-5516-4c89-9939-64df7f038761"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("102693e6-3b9c-4d7f-941f-3ee507e7ad44"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("7a5ef654-58ce-46de-a4aa-d335e1dac362"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("5025f07c-6a17-4d51-a187-118028b0d287"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ad46fd7e-6e18-4baa-91c9-042fa88df7b7"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9e12a884-c936-4a59-a292-ec636e7b26c6"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("46411802-23e3-47e0-a307-5236d43e26f0"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f01da635-fe55-4eed-b2fb-c44949cb1167"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("60b50bcd-0170-4307-ba69-ee6893957724"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2717c2f7-b989-4ae0-81a3-e23a73ef071d"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("953c65ff-c557-4330-a951-8094812d520f"), "Rangpur " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("102693e6-3b9c-4d7f-941f-3ee507e7ad44"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("7a5ef654-58ce-46de-a4aa-d335e1dac362"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("b0a3a29c-296b-413b-991f-26afe35202bb"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("b42bf1af-cd96-4fb7-9754-d4ac6ceb6995"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("d9f5daa3-95bb-4a95-a62c-9ec628d73bf6"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("de7be798-5516-4c89-9939-64df7f038761"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("f460f4f5-5336-42a4-b617-08cfa47add96"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("f4b69be2-d765-480d-a129-199b79e7f324"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("2717c2f7-b989-4ae0-81a3-e23a73ef071d"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("46411802-23e3-47e0-a307-5236d43e26f0"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("5025f07c-6a17-4d51-a187-118028b0d287"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("60b50bcd-0170-4307-ba69-ee6893957724"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("953c65ff-c557-4330-a951-8094812d520f"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("9e12a884-c936-4a59-a292-ec636e7b26c6"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("ad46fd7e-6e18-4baa-91c9-042fa88df7b7"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("f01da635-fe55-4eed-b2fb-c44949cb1167"));

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("85762f94-9412-4181-b63a-34b82c15847e"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("66166738-a313-4d0d-86dc-fe32be749923"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("79f89c40-cda3-4b6c-94a1-1c4aebd1baea"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("fb7af680-856b-42b5-998f-9db17687d4fa"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("288e9227-7493-43df-90a8-18c9089cfbfb"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("4edafffe-dff6-47f7-95f8-23a76c728e22"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("6a46f61d-6368-441c-a934-7382cc41dbfb"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("3e793fa2-4d40-4936-95d1-6dad4bb57c23"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("994c68fa-5553-49a5-b64f-64189e0d8065"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("886786ce-0361-4e26-bd92-a423c0862fb3"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("097ceb1e-413f-40c6-b938-f61ce759d46d"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ec7bdf75-de26-4fc2-9be0-a108e36f367c"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("593d1c90-7161-4b84-b349-0001bc1e4f4a"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4a2b9bee-284a-4654-95ff-439863ff8898"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("44a809a1-7c53-4522-a312-3a5cbf3e94fe"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c8c3de00-4a31-44c4-a5be-696192c64f07"), "Rangpur " });
        }
    }
}
