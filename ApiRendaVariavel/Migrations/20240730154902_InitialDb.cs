using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRendaVariavel.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FUNDOS_IMOBILIARIOS",
                columns: table => new
                {
                    ID_FUNDO_IMOBILIARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TICKER = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    TIPO_INVESTIMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RAZAO_SOCIAL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SEGMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PUBLICO_ALVO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MANDATO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PRAZO_DURACAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TIPO_GESTAO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TAXA_ADMINISTRACAO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VACANCIA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NUMERO_COTISTAS = table.Column<int>(type: "int", nullable: true),
                    COTAS_EMITIDAS = table.Column<int>(type: "int", nullable: true),
                    VALOR_PATRIMONIAL_POR_COTA = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VALOR_PATRIMONIAL = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ULTIMO_RENDIMENTO = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DATA_HORA_ULTIMA_ATUALIZACAO = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNDOS_IMOBILIARIOS", x => x.ID_FUNDO_IMOBILIARIO);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FUNDOS_IMOBILIARIOS_TICKER",
                table: "FUNDOS_IMOBILIARIOS",
                column: "TICKER",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FUNDOS_IMOBILIARIOS");
        }
    }
}
