using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRoboNddTech.Migrations
{
    public partial class CorrecaoCabecaInclinacaoEntidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoId",
                table: "Robo");

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaInclinacaoMovimento_movimentoCabecaInclinacaoId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoId",
                principalTable: "CabecaInclinacaoMovimento",
                principalColumn: "CabecaInclinacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaInclinacaoMovimento_movimentoCabecaInclinacaoId",
                table: "Robo");

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
