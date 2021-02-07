using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InititalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaOfLaws",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AreaOfLawName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaOfLaws", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lawyers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartingOfficeHour = table.Column<DateTime>(nullable: false),
                    EndingOfficeHour = table.Column<DateTime>(nullable: false),
                    ProfileImageLocation = table.Column<string>(nullable: true),
                    WorkingExperience = table.Column<int>(nullable: false),
                    DivisionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lawyers_Divisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LawyerAndAreaOfLaws",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LawyerId = table.Column<Guid>(nullable: false),
                    AreaOfLawId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerAndAreaOfLaws", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawyerAndAreaOfLaws_AreaOfLaws_AreaOfLawId",
                        column: x => x.AreaOfLawId,
                        principalTable: "AreaOfLaws",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LawyerAndAreaOfLaws_Lawyers_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("77b98aad-794b-476d-82ea-4657b6f497e2"), "Case" });

            migrationBuilder.InsertData(
                table: "AreaOfLaws",
                columns: new[] { "Id", "AreaOfLawName" },
                values: new object[] { new Guid("1d0da5be-2a5c-4dd9-aad9-98e0054997bc"), "Criminal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("67752983-6694-4fec-a919-c96aa5a47bbc"), "Dhaka" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("cc77b860-7ff2-4ef1-9fb8-c2ed2f3967af"), "Chittagong" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("8798ea69-ec65-4813-a5ee-1aad581cb546"), "Rajshahi" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("b0d29ac1-74ee-413d-b05f-9e0b1cf74dd2"), "Khulna" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c4571dd4-ca0b-4781-a059-8f17ce0ab2cb"), "Sylhet" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e4db70cb-001d-4776-bf83-586f94385084"), "Comilla" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("722f5f32-8398-4912-9f09-99ea57dd5c9e"), "Barisal" });

            migrationBuilder.InsertData(
                table: "Divisions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("32b7e7c9-d7fa-43b2-93b3-1c025ec2ee3b"), "Rangpur " });

            migrationBuilder.CreateIndex(
                name: "IX_LawyerAndAreaOfLaws_AreaOfLawId",
                table: "LawyerAndAreaOfLaws",
                column: "AreaOfLawId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerAndAreaOfLaws_LawyerId",
                table: "LawyerAndAreaOfLaws",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lawyers_DivisionId",
                table: "Lawyers",
                column: "DivisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LawyerAndAreaOfLaws");

            migrationBuilder.DropTable(
                name: "AreaOfLaws");

            migrationBuilder.DropTable(
                name: "Lawyers");

            migrationBuilder.DropTable(
                name: "Divisions");
        }
    }
}
