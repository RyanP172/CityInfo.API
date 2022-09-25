using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityInfo.API.Migrations
{
    public partial class CityInfoDBAddPointOfInterestDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Cities_CityId",
                table: "MyProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_MyProperty_PointOfInterestId",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.DropIndex(
                name: "IX_MyProperty_PointOfInterestId",
                table: "MyProperty");

            migrationBuilder.DropColumn(
                name: "PointOfInterestId",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "PointsOfInterest");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_CityId",
                table: "PointsOfInterest",
                newName: "IX_PointsOfInterest_CityId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PointsOfInterest",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Cities_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PointsOfInterest",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PointsOfInterest");

            migrationBuilder.RenameTable(
                name: "PointsOfInterest",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "MyProperty",
                newName: "IX_MyProperty_CityId");

            migrationBuilder.AddColumn<int>(
                name: "PointOfInterestId",
                table: "MyProperty",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_PointOfInterestId",
                table: "MyProperty",
                column: "PointOfInterestId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Cities_CityId",
                table: "MyProperty",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_MyProperty_PointOfInterestId",
                table: "MyProperty",
                column: "PointOfInterestId",
                principalTable: "MyProperty",
                principalColumn: "Id");
        }
    }
}
