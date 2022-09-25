using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.API.Migrations
{
    public partial class CityInforDBInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false),
                    PointOfInterestId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyProperty_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyProperty_MyProperty_PointOfInterestId",
                        column: x => x.PointOfInterestId,
                        principalTable: "MyProperty",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_CityId",
                table: "MyProperty",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_PointOfInterestId",
                table: "MyProperty",
                column: "PointOfInterestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProperty");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
