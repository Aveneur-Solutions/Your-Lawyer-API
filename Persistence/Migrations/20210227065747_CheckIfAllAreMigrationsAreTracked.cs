using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CheckIfAllAreMigrationsAreTracked : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("3313b758-9a5d-43a6-922b-b8c6d07f9555"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("3fec1443-729d-4b10-9eb0-dad428fef603"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("4169365c-4312-4dd9-9335-f7fe43668685"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("431fa44f-315b-466b-a131-6d5299947637"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("7c69373c-9eb3-4c30-b8f5-4bcfbf222cd5"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("95414419-39d8-40c6-b3c4-d2b6abc9dbcd"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("ddd13ace-d4b9-4c09-b038-9fd16e3b187e"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("eeb1059b-6cc2-4a73-be51-ae6c424b9caf"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("0203cf77-6e60-448f-9dc8-a5521591cae9"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("3588e5f1-c360-4f10-87ff-d3b006460e6e"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("4a0b55eb-1f4a-45f9-b079-d87dc4910551"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("4e675abf-62d7-4ffd-b66b-cce98a3f00c2"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("7003c575-8e91-4c24-9bd4-ab3e4b935429"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("739620f3-8c14-4542-b0eb-fc2ddfefe7ea"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("b2cc577c-c526-4a9f-b1a5-a5fb2aace8f8"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("da661d1e-6007-4281-a22d-aea82243ba6d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("4169365c-4312-4dd9-9335-f7fe43668685"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("95414419-39d8-40c6-b3c4-d2b6abc9dbcd"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("eeb1059b-6cc2-4a73-be51-ae6c424b9caf"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("431fa44f-315b-466b-a131-6d5299947637"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("7c69373c-9eb3-4c30-b8f5-4bcfbf222cd5"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("ddd13ace-d4b9-4c09-b038-9fd16e3b187e"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("3313b758-9a5d-43a6-922b-b8c6d07f9555"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("3fec1443-729d-4b10-9eb0-dad428fef603"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4a0b55eb-1f4a-45f9-b079-d87dc4910551"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0203cf77-6e60-448f-9dc8-a5521591cae9"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3588e5f1-c360-4f10-87ff-d3b006460e6e"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("739620f3-8c14-4542-b0eb-fc2ddfefe7ea"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7003c575-8e91-4c24-9bd4-ab3e4b935429"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4e675abf-62d7-4ffd-b66b-cce98a3f00c2"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b2cc577c-c526-4a9f-b1a5-a5fb2aace8f8"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("da661d1e-6007-4281-a22d-aea82243ba6d"), "Rangpur " });
        }
    }
}
