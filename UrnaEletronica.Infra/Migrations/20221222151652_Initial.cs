using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UrnaEletronica.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PrimeiroNome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    PartidoDataCriacao = table.Column<DateOnly>(name: "Partido_DataCriacao", type: "date", nullable: false),
                    PartidoSigla = table.Column<string>(name: "Partido_Sigla", type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatos");
        }
    }
}
