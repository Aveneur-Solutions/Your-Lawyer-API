using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MessagesAdded : Migration
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

            migrationBuilder.CreateTable(
                name: "QueryFile",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    SenderId = table.Column<string>(nullable: true),
                    ReceiverId = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryFile_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryFile_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueryText",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    SenderId = table.Column<string>(nullable: true),
                    ReceiverId = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryText", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryText_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QueryText_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("ec39ff46-415f-4307-b611-82c50ad811ab"), "Banking and Finance Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("1475b4dd-db74-4df5-b6a0-936480050e60"), "Civil Litigation" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("e2eaf09b-348b-4b81-a39f-da296f0ba1d0"), "Dispute Resolution" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("6a49f3a1-cf42-48de-84b2-cbd68e9095c7"), "Commercial Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("03710086-ab1e-48c7-893b-347ca496abf8"), "Construction Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("f7b50d33-51c1-4225-b9b2-6276dfe2424f"), "Corporate Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("60ade23c-05fb-4596-95db-958e90d3b6f3"), "Criminal Law" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("165e47eb-5209-4e5a-9069-8953a24ae65f"), "Family Law" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a70fa025-db49-4f14-8559-a32a3f471314"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("805fa95e-89ae-4571-b1f9-5561ff3f61c3"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c5c3f58b-41c5-4916-bee6-e433b1a0bea1"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7c3d6e53-dfa5-4f3e-8914-10505a5d18ad"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("0a1f1f93-83bb-41a2-88d3-0aa3e0f9ef83"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("163bf884-58be-47f9-9df9-2cec05585fd5"), "Mymensingh" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2234854c-282c-4f68-aac5-d1a59146b6a8"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b39d7440-cf97-4536-96e7-d21c9551549e"), "Rangpur " });

            migrationBuilder.CreateIndex(
                name: "IX_QueryFile_ReceiverId",
                table: "QueryFile",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryFile_SenderId",
                table: "QueryFile",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryText_ReceiverId",
                table: "QueryText",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryText_SenderId",
                table: "QueryText",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueryFile");

            migrationBuilder.DropTable(
                name: "QueryText");

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("03710086-ab1e-48c7-893b-347ca496abf8"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("1475b4dd-db74-4df5-b6a0-936480050e60"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("165e47eb-5209-4e5a-9069-8953a24ae65f"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("60ade23c-05fb-4596-95db-958e90d3b6f3"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("6a49f3a1-cf42-48de-84b2-cbd68e9095c7"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("e2eaf09b-348b-4b81-a39f-da296f0ba1d0"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("ec39ff46-415f-4307-b611-82c50ad811ab"));

            migrationBuilder.DeleteData(
                table: "AreaOfLaws",
                keyColumn: "Id",
                keyValue: new Guid("f7b50d33-51c1-4225-b9b2-6276dfe2424f"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1f93-83bb-41a2-88d3-0aa3e0f9ef83"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("163bf884-58be-47f9-9df9-2cec05585fd5"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("2234854c-282c-4f68-aac5-d1a59146b6a8"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("7c3d6e53-dfa5-4f3e-8914-10505a5d18ad"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("805fa95e-89ae-4571-b1f9-5561ff3f61c3"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("a70fa025-db49-4f14-8559-a32a3f471314"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("b39d7440-cf97-4536-96e7-d21c9551549e"));

            migrationBuilder.DeleteData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: new Guid("c5c3f58b-41c5-4916-bee6-e433b1a0bea1"));

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
