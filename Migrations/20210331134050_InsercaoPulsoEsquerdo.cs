using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRoboNddTech.Migrations
{
    public partial class InsercaoPulsoEsquerdo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoAtualId");

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoAtualId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.AddColumn<int>(
                name: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Robo_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo",
                column: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo",
                column: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
