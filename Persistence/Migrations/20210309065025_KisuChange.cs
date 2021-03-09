using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class KisuChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("1dbc2a63-8dc6-484c-a647-425de7a48e17"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("38968f7d-c734-4613-b21b-53debf06712e"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("672a0e08-a493-4c31-b410-954981d97f61"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("6bec7c27-2d82-4b18-ac2b-0a60c9369553"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("7604d712-5f61-41d3-b414-77d29ea61456"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("9a73f369-ffce-426b-b469-d51fe7dbeea1"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("9c409901-823c-4fc1-8e01-a654775030ca"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("f1f1433b-e15a-4f7c-adfb-632953d3acb8"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("512bce3c-4a5f-4eff-8a75-ad432c11fbb2"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("5473a696-ca41-44a0-b5d2-1692d084e744"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("83780d17-666f-4247-aecb-7c69662f4de9"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("8474094a-3737-4fb7-ad53-33b0b8b4dde5"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("8c86bb19-7f4b-4e28-a3f5-1f766438b157"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("a660a298-5b07-4a34-a8ff-255745dee017"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("bbaf338a-0236-4d71-b12d-1fff5ff93ee6"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("e4c6be12-0a38-4afc-8b6c-ebd3f388f72f"));

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("443c82be-d82e-42b5-89f4-a1bc6c9c8c54"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("ab92b941-c477-43cc-8bc7-65ee6770e94f"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("c83ec0b4-da15-4b7c-87fa-dcbd15e67a24"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("a001f428-b71c-47dd-8ec6-4b8332c1df69"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("d0742af6-e485-43d7-b042-fd72dd8faa2f"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("80c4316e-e71a-4493-ab74-5f6f0827a13a"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("67234d0d-dd8a-429e-961c-0ff1515c8cf7"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("52e24882-b4a5-4964-acd7-e6410a7cec70"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3be8f8c3-dd85-408a-973b-629d6661c76f"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e91a93a8-54c3-4680-b452-9e51ccb1e33e"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a7b9e293-81f5-4ff4-a859-49f75bdd96cd"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("28f26310-c925-448a-bc0b-b6a339e55ac8"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1d52ebef-d46e-497d-a530-6d4216d2bef5"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e53adb90-67c4-47b4-8fb0-1c242d02bb48"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("eb58b5a3-e078-4e36-9442-aef16be173fb"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c665fc07-fd15-48a9-abd9-2f741f83e4f4"), "Rangpur " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("443c82be-d82e-42b5-89f4-a1bc6c9c8c54"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("52e24882-b4a5-4964-acd7-e6410a7cec70"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("67234d0d-dd8a-429e-961c-0ff1515c8cf7"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("80c4316e-e71a-4493-ab74-5f6f0827a13a"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("a001f428-b71c-47dd-8ec6-4b8332c1df69"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("ab92b941-c477-43cc-8bc7-65ee6770e94f"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("c83ec0b4-da15-4b7c-87fa-dcbd15e67a24"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("d0742af6-e485-43d7-b042-fd72dd8faa2f"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("1d52ebef-d46e-497d-a530-6d4216d2bef5"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("28f26310-c925-448a-bc0b-b6a339e55ac8"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("3be8f8c3-dd85-408a-973b-629d6661c76f"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("a7b9e293-81f5-4ff4-a859-49f75bdd96cd"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("c665fc07-fd15-48a9-abd9-2f741f83e4f4"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("e53adb90-67c4-47b4-8fb0-1c242d02bb48"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("e91a93a8-54c3-4680-b452-9e51ccb1e33e"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("eb58b5a3-e078-4e36-9442-aef16be173fb"));

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("6bec7c27-2d82-4b18-ac2b-0a60c9369553"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("1dbc2a63-8dc6-484c-a647-425de7a48e17"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("7604d712-5f61-41d3-b414-77d29ea61456"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("9a73f369-ffce-426b-b469-d51fe7dbeea1"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("38968f7d-c734-4613-b21b-53debf06712e"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("672a0e08-a493-4c31-b410-954981d97f61"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("f1f1433b-e15a-4f7c-adfb-632953d3acb8"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("9c409901-823c-4fc1-8e01-a654775030ca"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a660a298-5b07-4a34-a8ff-255745dee017"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("512bce3c-4a5f-4eff-8a75-ad432c11fbb2"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("83780d17-666f-4247-aecb-7c69662f4de9"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bbaf338a-0236-4d71-b12d-1fff5ff93ee6"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("5473a696-ca41-44a0-b5d2-1692d084e744"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e4c6be12-0a38-4afc-8b6c-ebd3f388f72f"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8474094a-3737-4fb7-ad53-33b0b8b4dde5"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8c86bb19-7f4b-4e28-a3f5-1f766438b157"), "Rangpur " });
        }
    }
}
