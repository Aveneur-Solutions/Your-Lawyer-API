using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class LawyerServiceRelatedEntitiesAdded : Migration
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
