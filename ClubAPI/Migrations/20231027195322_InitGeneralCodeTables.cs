using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitGeneralCodeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cityCodes",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityCodes", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "genderCodes",
                columns: table => new
                {
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genderCodes", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "jobCodes",
                columns: table => new
                {
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobCodes", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "martialStatusCodes",
                columns: table => new
                {
                    MartialStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_martialStatusCodes", x => x.MartialStatusId);
                });

            migrationBuilder.CreateTable(
                name: "membershipCodes",
                columns: table => new
                {
                    MembershipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membershipCodes", x => x.MembershipId);
                });

            migrationBuilder.CreateTable(
                name: "nationalityCodes",
                columns: table => new
                {
                    NationalityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationalityCodes", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "QualCodes",
                columns: table => new
                {
                    QualId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualCodes", x => x.QualId);
                });

            migrationBuilder.CreateTable(
                name: "RefCodes",
                columns: table => new
                {
                    RefId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AgeFlag = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefCodes", x => x.RefId);
                });

            migrationBuilder.CreateTable(
                name: "religionCodes",
                columns: table => new
                {
                    ReligionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_religionCodes", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "sectionCodes",
                columns: table => new
                {
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Annual = table.Column<bool>(type: "bit", nullable: false),
                    Improve = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<bool>(type: "bit", nullable: false),
                    Init = table.Column<bool>(type: "bit", nullable: false),
                    Office = table.Column<bool>(type: "bit", nullable: false),
                    Penalty = table.Column<bool>(type: "bit", nullable: false),
                    Player = table.Column<bool>(type: "bit", nullable: false),
                    Pool = table.Column<bool>(type: "bit", nullable: false),
                    Post = table.Column<bool>(type: "bit", nullable: false),
                    Reg = table.Column<bool>(type: "bit", nullable: false),
                    River = table.Column<bool>(type: "bit", nullable: false),
                    Stamp = table.Column<bool>(type: "bit", nullable: false),
                    Worker = table.Column<bool>(type: "bit", nullable: false),
                    Donation = table.Column<bool>(type: "bit", nullable: false),
                    Maintenance = table.Column<bool>(type: "bit", nullable: false),
                    Society = table.Column<bool>(type: "bit", nullable: false),
                    ComPenalty = table.Column<bool>(type: "bit", nullable: false),
                    ReserveFee = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionCodes", x => x.SectionId);
                });

            migrationBuilder.CreateTable(
                name: "titleCodes",
                columns: table => new
                {
                    TitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titleCodes", x => x.TitleId);
                });

            migrationBuilder.CreateTable(
                name: "TransCodes",
                columns: table => new
                {
                    TransId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransCodes", x => x.TransId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cityCodes_Code",
                table: "cityCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_genderCodes_Code",
                table: "genderCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_jobCodes_Code",
                table: "jobCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_martialStatusCodes_Code",
                table: "martialStatusCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_membershipCodes_Code",
                table: "membershipCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nationalityCodes_Code",
                table: "nationalityCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QualCodes_Code",
                table: "QualCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefCodes_Code",
                table: "RefCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_religionCodes_Code",
                table: "religionCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_sectionCodes_Code",
                table: "sectionCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_titleCodes_Code",
                table: "titleCodes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransCodes_Code",
                table: "TransCodes",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cityCodes");

            migrationBuilder.DropTable(
                name: "genderCodes");

            migrationBuilder.DropTable(
                name: "jobCodes");

            migrationBuilder.DropTable(
                name: "martialStatusCodes");

            migrationBuilder.DropTable(
                name: "membershipCodes");

            migrationBuilder.DropTable(
                name: "nationalityCodes");

            migrationBuilder.DropTable(
                name: "QualCodes");

            migrationBuilder.DropTable(
                name: "RefCodes");

            migrationBuilder.DropTable(
                name: "religionCodes");

            migrationBuilder.DropTable(
                name: "sectionCodes");

            migrationBuilder.DropTable(
                name: "titleCodes");

            migrationBuilder.DropTable(
                name: "TransCodes");
        }
    }
}
