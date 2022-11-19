using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ank9ServerApiTekrar.Model.Migrations
{
    public partial class bir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1000, 2"),
                    Tc = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kisiler_Ad",
                table: "Kisiler",
                column: "Ad",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}
