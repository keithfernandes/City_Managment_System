using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjCRS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrimeLocation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrimeLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Criminal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Employed = table.Column<bool>(nullable: false),
                    Income = table.Column<int>(nullable: true),
                    EducationLevel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criminal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriminalCode",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CriminalActivity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeOfOccurance = table.Column<DateTime>(nullable: false),
                    CriminalId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    CriminalCodeId = table.Column<int>(nullable: false),
                    CaseStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriminalActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriminalActivity_CriminalCode_CriminalCodeId",
                        column: x => x.CriminalCodeId,
                        principalTable: "CriminalCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriminalActivity_Criminal_CriminalId",
                        column: x => x.CriminalId,
                        principalTable: "Criminal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriminalActivity_CrimeLocation_LocationId",
                        column: x => x.LocationId,
                        principalTable: "CrimeLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CriminalActivity_CriminalCodeId",
                table: "CriminalActivity",
                column: "CriminalCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalActivity_CriminalId",
                table: "CriminalActivity",
                column: "CriminalId");

            migrationBuilder.CreateIndex(
                name: "IX_CriminalActivity_LocationId",
                table: "CriminalActivity",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CriminalActivity");

            migrationBuilder.DropTable(
                name: "CriminalCode");

            migrationBuilder.DropTable(
                name: "Criminal");

            migrationBuilder.DropTable(
                name: "CrimeLocation");
        }
    }
}
