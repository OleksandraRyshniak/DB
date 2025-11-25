using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace toode.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategooriatabel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategooria_nimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategooriatabel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tootetabel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Toodenimetus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lisatud = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Kogus = table.Column<int>(type: "int", nullable: false),
                    Hind = table.Column<float>(type: "real", nullable: false),
                    Pilt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategooriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tootetabel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tootetabel_Kategooriatabel_KategooriaId",
                        column: x => x.KategooriaId,
                        principalTable: "Kategooriatabel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tootetabel_KategooriaId",
                table: "Tootetabel",
                column: "KategooriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tootetabel");

            migrationBuilder.DropTable(
                name: "Kategooriatabel");
        }
    }
}
