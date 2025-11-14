using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "movies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "WithSubtitles",
                table: "movies",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "membershipTypeId",
                table: "customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerMovie",
                columns: table => new
                {
                    CustomersId = table.Column<int>(type: "int", nullable: false),
                    moviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMovie", x => new { x.CustomersId, x.moviesId });
                    table.ForeignKey(
                        name: "FK_CustomerMovie_customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerMovie_movies_moviesId",
                        column: x => x.moviesId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiscountRate = table.Column<int>(type: "int", nullable: false),
                    DurationInMonth = table.Column<int>(type: "int", nullable: false),
                    SignUpFee = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_movies_GenderId",
                table: "movies",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_customers_membershipTypeId",
                table: "customers",
                column: "membershipTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMovie_moviesId",
                table: "CustomerMovie",
                column: "moviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_MembershipType_membershipTypeId",
                table: "customers",
                column: "membershipTypeId",
                principalTable: "MembershipType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_movies_genres_GenderId",
                table: "movies",
                column: "GenderId",
                principalTable: "genres",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_MembershipType_membershipTypeId",
                table: "customers");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_genres_GenderId",
                table: "movies");

            migrationBuilder.DropTable(
                name: "CustomerMovie");

            migrationBuilder.DropTable(
                name: "MembershipType");

            migrationBuilder.DropIndex(
                name: "IX_movies_GenderId",
                table: "movies");

            migrationBuilder.DropIndex(
                name: "IX_customers_membershipTypeId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "WithSubtitles",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "membershipTypeId",
                table: "customers");
        }
    }
}
