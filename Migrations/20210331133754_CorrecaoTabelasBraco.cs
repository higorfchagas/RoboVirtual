using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRoboNddTech.Migrations
{
    public partial class CorrecaoTabelasBraco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoEsquerdoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropTable(
                name: "BracoMovimento");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoEsquerdoUltimoId",
                table: "Robo",
                newName: "movimentoBracoPulsoEsquerdoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoEsquerdoAtualId",
                table: "Robo",
                newName: "movimentoBracoPulsoEsquerdoAtualId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoDireitoUltimoId",
                table: "Robo",
                newName: "movimentoBracoPulsoDireitoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoDireitoAtualId",
                table: "Robo",
                newName: "movimentoBracoPulsoDireitoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoEsquerdoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoEsquerdoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoEsquerdoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoEsquerdoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoDireitoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoDireitoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoDireitoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoPulsoDireitoAtualId");

            migrationBuilder.AddColumn<int>(
                name: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "BracoCotoveloMovimento",
                columns: table => new
                {
                    BracoCotoveloMovimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BracoCotoveloMovimentoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracoCotoveloMovimento", x => x.BracoCotoveloMovimentoId);
                });

            migrationBuilder.CreateTable(
                name: "BracoPulsoMovimento",
                columns: table => new
                {
                    BracoPulsoMovimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BracoPulsoMovimentoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracoPulsoMovimento", x => x.BracoPulsoMovimentoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloDireitoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo",
                column: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId");

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
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoCotoveloEsquerdoUltimoId",
                principalTable: "BracoCotoveloMovimento",
                principalColumn: "BracoCotoveloMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo",
                column: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropForeignKey(
                name: "FK_Robo_BracoCotoveloMovimento_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
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

            migrationBuilder.DropTable(
                name: "BracoCotoveloMovimento");

            migrationBuilder.DropTable(
                name: "BracoPulsoMovimento");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoAtualId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloDireitoUltimoId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_movimentoBracoCotoveloEsquerdoUltimoId",
                table: "Robo");

            migrationBuilder.DropIndex(
                name: "IX_Robo_MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
                table: "Robo");

            migrationBuilder.DropColumn(
                name: "MovimentoBracoEsquerdoAtualBracoCotoveloMovimentoId",
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

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoEsquerdoUltimoId",
                table: "Robo",
                newName: "movimentoBracoEsquerdoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoEsquerdoAtualId",
                table: "Robo",
                newName: "movimentoBracoEsquerdoAtualId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoDireitoUltimoId",
                table: "Robo",
                newName: "movimentoBracoDireitoUltimoId");

            migrationBuilder.RenameColumn(
                name: "movimentoBracoPulsoDireitoAtualId",
                table: "Robo",
                newName: "movimentoBracoDireitoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoEsquerdoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoEsquerdoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoEsquerdoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoEsquerdoAtualId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoUltimoId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoDireitoUltimoId");

            migrationBuilder.RenameIndex(
                name: "IX_Robo_movimentoBracoPulsoDireitoAtualId",
                table: "Robo",
                newName: "IX_Robo_movimentoBracoDireitoAtualId");

            migrationBuilder.CreateTable(
                name: "BracoMovimento",
                columns: table => new
                {
                    BracoMovimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BracoMovimentoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BracoMovimento", x => x.BracoMovimentoId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoDireitoAtualId",
                principalTable: "BracoMovimento",
                principalColumn: "BracoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoDireitoUltimoId",
                principalTable: "BracoMovimento",
                principalColumn: "BracoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoEsquerdoAtualId",
                principalTable: "BracoMovimento",
                principalColumn: "BracoMovimentoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robo_BracoMovimento_movimentoBracoEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoEsquerdoUltimoId",
                principalTable: "BracoMovimento",
                principalColumn: "BracoMovimentoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
