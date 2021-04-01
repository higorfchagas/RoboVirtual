using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRoboNddTech.Migrations
{
    public partial class RemocaoMovimentoAnterior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoUltimoId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "movimentoBracoCotoveloDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "movimentoBracoPulsoDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "movimentoBracoPulsoDireitoUltimoId",
                table: "Robo");

            migrationBuilder.RenameColumn(
                name: "movimentoCabecaRotacaoUltimoId",
                table: "Robo",
                newName: "movimentoCabecaRotacaoId");

            migrationBuilder.RenameColumn(
                name: "movimentoCabecaRotacaoAtualId",
                table: "Robo",
                newName: "movimentoCabecaInclinacaoId");

            migrationBuilder.RenameColumn(
                name: "movimentoCabecaInclinacaoUltimoId",
                table: "Robo",
                newName: "movimentoBracoPulsoEsquerdoId");

            migrationBuilder.RenameColumn(
                name: "movimentoCabecaInclinacaoAtualId",
                table: "Robo",
                newName: "movimentoBracoPulsoDireitoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoEsquerdoUltimoId",
                table: "Robo",
                newName: "movimentoBracoCotoveloEsquerdoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoEsquerdoAtualId",
                table: "Robo",
                newName: "movimentoBracoCotoveloDireitoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoCabecaRotacaoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoCabecaRotacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoCabecaRotacaoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoCabecaInclinacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoCabecaInclinacaoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoEsquerdoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoCabecaInclinacaoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoDireitoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoEsquerdoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoCotoveloEsquerdoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoEsquerdoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoCotoveloDireitoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoDireitoId",
                table: "Robo",
                column: "movimentoBracoPulsoDireitoId",
                principalTable: "BracoPulsoMovimento",
                principalColumn: "BracoPulsoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoEsquerdoId",
                table: "Robo",
                column: "movimentoBracoPulsoEsquerdoId",
                principalTable: "BracoPulsoMovimento",
                principalColumn: "BracoPulsoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoId",
                table: "Robo",
                column: "movimentoCabecaRotacaoId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoDireitoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoEsquerdoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoId",
                table: "Robo");

            migrationBuilder.RenameColumn(
                name: "movimentoCabecaRotacaoId",
                table: "Robo",
                newName: "movimentoCabecaRotacaoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoCabecaInclinacaoId",
                table: "Robo",
                newName: "movimentoCabecaRotacaoAtualId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoEsquerdoId",
                table: "Robo",
                newName: "movimentoCabecaInclinacaoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoDireitoId",
                table: "Robo",
                newName: "movimentoCabecaInclinacaoAtualId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoCotoveloEsquerdoId",
                table: "Robo",
                newName: "movimentoBracoPulsoEsquerdoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoCotoveloDireitoId",
                table: "Robo",
                newName: "movimentoBracoPulsoEsquerdoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoCabecaRotacaoId",
                table: "Robo",
                newName: "IX_Robo_movimentoCabecaRotacaoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoCabecaInclinacaoId",
                table: "Robo",
                newName: "IX_Robo_movimentoCabecaRotacaoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoEsquerdoId",
                table: "Robo",
                newName: "IX_Robo_movimentoCabecaInclinacaoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoId",
                table: "Robo",
                newName: "IX_Robo_movimentoCabecaInclinacaoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoEsquerdoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoEsquerdoAtualId");

            migrationBuilder.AddColumn<int>(
                name: "movimentoBracoCotoveloDireitoAtualId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movimentoBracoPulsoDireitoAtualId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "movimentoBracoPulsoDireitoUltimoId",
                table: "Robo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoPulsoDireitoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoPulsoDireitoUltimoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoAtualId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoUltimoId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoAtualId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoUltimoId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoPulsoDireitoAtualId",
                principalTable: "BracoPulsoMovimento",
                principalColumn: "BracoPulsoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoPulsoDireitoUltimoId",
                principalTable: "BracoPulsoMovimento",
                principalColumn: "BracoPulsoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoPulsoEsquerdoAtualId",
                principalTable: "BracoPulsoMovimento",
                principalColumn: "BracoPulsoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoPulsoMovimento_movimentoBracoPulsoEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoPulsoEsquerdoUltimoId",
                principalTable: "BracoPulsoMovimento",
                principalColumn: "BracoPulsoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoAtualId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoAtualId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoUltimoId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoUltimoId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoAtualId",
                table: "Robo",
                column: "movimentoCabecaRotacaoAtualId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoUltimoId",
                table: "Robo",
                column: "movimentoCabecaRotacaoUltimoId",
                principalTable: "CabecaRotacaoMovimento",
                principalColumn: "CabecaRotacaoMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
