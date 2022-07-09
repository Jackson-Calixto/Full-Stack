using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.API.Data.Migrations
{
    public partial class Sessao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessoes",
                columns: table => new
                {
                    SessaoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HorarioInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HorarioFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValorIngresso = table.Column<double>(type: "REAL", nullable: false),
                    Animacao = table.Column<string>(type: "TEXT", nullable: true),
                    Audio = table.Column<string>(type: "TEXT", nullable: true),
                    FilmeId = table.Column<int>(type: "INTEGER", nullable: false),
                    SalaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessoes", x => x.SessaoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessoes");
        }
    }
}
