using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClubAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMemberEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlaceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MartialStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NationalityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pic = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonalPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    JobPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberNo = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberOrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberOrderNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberRenewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QualId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HasCard = table.Column<bool>(type: "bit", nullable: false),
                    CardDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MSCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    M_Lock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    F_Lock = table.Column<int>(type: "int", nullable: false),
                    TMPFLG = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_members_QualCodes_QualId",
                        column: x => x.QualId,
                        principalTable: "QualCodes",
                        principalColumn: "QualId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_cityCodes_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "cityCodes",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_members_cityCodes_CityId",
                        column: x => x.CityId,
                        principalTable: "cityCodes",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_genderCodes_Gender",
                        column: x => x.Gender,
                        principalTable: "genderCodes",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_jobCodes_JobId",
                        column: x => x.JobId,
                        principalTable: "jobCodes",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_martialStatusCodes_MartialStatusId",
                        column: x => x.MartialStatusId,
                        principalTable: "martialStatusCodes",
                        principalColumn: "MartialStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_membershipCodes_MembershipId",
                        column: x => x.MembershipId,
                        principalTable: "membershipCodes",
                        principalColumn: "MembershipId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_nationalityCodes_NationalityID",
                        column: x => x.NationalityID,
                        principalTable: "nationalityCodes",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_religionCodes_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "religionCodes",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_sectionCodes_SectionId",
                        column: x => x.SectionId,
                        principalTable: "sectionCodes",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_members_titleCodes_Title",
                        column: x => x.Title,
                        principalTable: "titleCodes",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_members_BirthPlaceId",
                table: "members",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_members_CityId",
                table: "members",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_members_Gender",
                table: "members",
                column: "Gender");

            migrationBuilder.CreateIndex(
                name: "IX_members_IdNo",
                table: "members",
                column: "IdNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_members_JobId",
                table: "members",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_members_MartialStatusId",
                table: "members",
                column: "MartialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_members_MembershipId",
                table: "members",
                column: "MembershipId");

            migrationBuilder.CreateIndex(
                name: "IX_members_NationalityID",
                table: "members",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_members_QualId",
                table: "members",
                column: "QualId");

            migrationBuilder.CreateIndex(
                name: "IX_members_ReligionId",
                table: "members",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_members_SectionId",
                table: "members",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_members_Title",
                table: "members",
                column: "Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "members");
        }
    }
}
