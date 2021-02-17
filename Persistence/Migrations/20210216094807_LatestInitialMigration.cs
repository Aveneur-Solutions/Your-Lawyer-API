using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class LatestInitialMigration : Migration
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
                    LawyerRank = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "LawyerEducationalBGs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Degree = table.Column<string>(nullable: true),
                    Institute = table.Column<string>(nullable: true),
                    PassingYear = table.Column<int>(nullable: false),
                    LawyerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerEducationalBGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawyerEducationalBGs_Lawyers_LawyerId",
                        column: x => x.LawyerId,
                        principalTable: "Lawyers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LawyerAndAreaOfLaws_AreaOfLawId",
                table: "LawyerAndAreaOfLaws",
                column: "AreaOfLawId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerAndAreaOfLaws_LawyerId",
                table: "LawyerAndAreaOfLaws",
                column: "LawyerId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerEducationalBGs_LawyerId",
                table: "LawyerEducationalBGs",
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
                name: "LawyerEducationalBGs");

            migrationBuilder.DropTable(
                name: "AreaOfLaws");

            migrationBuilder.DropTable(
                name: "Lawyers");

            migrationBuilder.DropTable(
                name: "Divisions");
        }
    }
}
