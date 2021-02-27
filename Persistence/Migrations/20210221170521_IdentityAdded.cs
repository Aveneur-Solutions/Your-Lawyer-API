using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class IdentityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
