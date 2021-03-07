using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class OtpFieldAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("314f7eb4-9df1-455e-aa35-8405c8b8530c"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("36eb8521-52b3-4531-bc0e-2d7ed3e9f004"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("41f7c4e6-a733-4b28-9e8e-daf7174d652b"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("55bdce93-55f9-44be-8142-66391a42b60e"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("56cfc262-5deb-4b3a-a028-7a8ae03ef1f7"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("99e3034e-c18e-41dd-8511-84d25bbbd0d4"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("a99ae3dc-4220-4126-b64d-1d64eb99179e"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("acf86c84-0fb9-45f4-b5cf-da904480adf0"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("8771014b-13d1-48ce-9bc8-7221974315a1"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("99cd906d-a0fb-4f85-a7e0-9d853bb261fd"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("b5c72444-95fc-42bc-af3f-3912f5fac925"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("c2a4892c-e4f8-41a3-a4b6-e9d390ccbcd8"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("ca2d9490-e232-474f-a2a0-5cae616a2a89"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("d85287f5-a84b-40b9-a4d1-25bde4c38d9e"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("e7a1448c-03a0-4f3a-ada8-1fcc8030510a"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("f052cbcd-996a-40fb-b218-93305866b749"));

            migrationBuilder.AddColumn<string>(
                name: "Otp",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("98a29e8a-96f5-4ac5-8020-39a2f20192a4"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("4679f12a-12ab-45d4-8dcf-39216a10dca8"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("bb5c1fea-f2b0-4b9a-9419-d3d57a4ba626"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("33df37cc-6a9b-4400-8ab7-25cd3931b518"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("cf1d2fca-97b0-4dcc-bad9-60e9b13cd610"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("9085ebd8-844c-4125-a8e7-371768fc7b27"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("7a33f676-7e40-407e-9b85-ee047d9e0765"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("9dc9c1ff-6f83-49d6-845e-dae977eaa791"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a8f556f7-be9c-4135-a02d-7ef26e7fdef1"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3f2f6a4a-e54e-4a03-ad9e-5b81d9cffcd8"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("565b229a-b381-46d1-ba4e-bfefe1ff0095"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("049dcd81-6f8f-4d2f-8b47-8583f5426507"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("20b7d4d3-e07d-4e0c-9509-6fd8dc8c7cc2"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2d4a3da4-6e37-4cbd-b646-5d08cfbc082d"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a30e4dd0-e355-42be-a3d6-2b9f797f3048"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d6017130-4ecc-459e-9f3d-feaa7e5e1cb0"), "Rangpur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("33df37cc-6a9b-4400-8ab7-25cd3931b518"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("4679f12a-12ab-45d4-8dcf-39216a10dca8"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("7a33f676-7e40-407e-9b85-ee047d9e0765"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("9085ebd8-844c-4125-a8e7-371768fc7b27"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("98a29e8a-96f5-4ac5-8020-39a2f20192a4"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("9dc9c1ff-6f83-49d6-845e-dae977eaa791"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("bb5c1fea-f2b0-4b9a-9419-d3d57a4ba626"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("cf1d2fca-97b0-4dcc-bad9-60e9b13cd610"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("049dcd81-6f8f-4d2f-8b47-8583f5426507"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("20b7d4d3-e07d-4e0c-9509-6fd8dc8c7cc2"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("2d4a3da4-6e37-4cbd-b646-5d08cfbc082d"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("3f2f6a4a-e54e-4a03-ad9e-5b81d9cffcd8"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("565b229a-b381-46d1-ba4e-bfefe1ff0095"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("a30e4dd0-e355-42be-a3d6-2b9f797f3048"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("a8f556f7-be9c-4135-a02d-7ef26e7fdef1"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("d6017130-4ecc-459e-9f3d-feaa7e5e1cb0"));

            migrationBuilder.DropColumn(
                name: "Otp",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("99e3034e-c18e-41dd-8511-84d25bbbd0d4"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("41f7c4e6-a733-4b28-9e8e-daf7174d652b"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("a99ae3dc-4220-4126-b64d-1d64eb99179e"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("36eb8521-52b3-4531-bc0e-2d7ed3e9f004"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("55bdce93-55f9-44be-8142-66391a42b60e"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("314f7eb4-9df1-455e-aa35-8405c8b8530c"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("56cfc262-5deb-4b3a-a028-7a8ae03ef1f7"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("acf86c84-0fb9-45f4-b5cf-da904480adf0"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("f052cbcd-996a-40fb-b218-93305866b749"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("d85287f5-a84b-40b9-a4d1-25bde4c38d9e"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("99cd906d-a0fb-4f85-a7e0-9d853bb261fd"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e7a1448c-03a0-4f3a-ada8-1fcc8030510a"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b5c72444-95fc-42bc-af3f-3912f5fac925"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c2a4892c-e4f8-41a3-a4b6-e9d390ccbcd8"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ca2d9490-e232-474f-a2a0-5cae616a2a89"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8771014b-13d1-48ce-9bc8-7221974315a1"), "Rangpur " });
        }
    }
}
