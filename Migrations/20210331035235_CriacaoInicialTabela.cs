using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoRoboNddTech.Migrations
{
    public partial class CriacaoInicialTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "CabecaInclinacaoMovimento",
                columns: table => new
                {
                    CabecaInclinacaoMovimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabecaInclinacaoMovimentoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabecaInclinacaoMovimento", x => x.CabecaInclinacaoMovimentoId);
                });

            migrationBuilder.CreateTable(
                name: "CabecaRotacaoMovimento",
                columns: table => new
                {
                    CabecaRotacaoMovimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CabecaRotacaoMovimentoDescricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabecaRotacaoMovimento", x => x.CabecaRotacaoMovimentoId);
                });

            migrationBuilder.CreateTable(
                name: "Robo",
                columns: table => new
                {
                    RoboId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    movimentoCabecaRotacaoAtualId = table.Column<int>(type: "int", nullable: true),
                    movimentoCabecaRotacaoUltimoId = table.Column<int>(type: "int", nullable: true),
                    movimentoCabecaInclinacaoAtualId = table.Column<int>(type: "int", nullable: true),
                    movimentoCabecaInclinacaoUltimoId = table.Column<int>(type: "int", nullable: true),
                    movimentoBracoDireitoAtualId = table.Column<int>(type: "int", nullable: true),
                    movimentoBracoDireitoUltimoId = table.Column<int>(type: "int", nullable: true),
                    movimentoBracoEsquerdoAtualId = table.Column<int>(type: "int", nullable: true),
                    movimentoBracoEsquerdoUltimoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robo", x => x.RoboId);
                    table.ForeignKey(
                        name: "FK_Robo_BracoMovimento_movimentoBracoDireitoAtualId",
                        column: x => x.movimentoBracoDireitoAtualId,
                        principalTable: "BracoMovimento",
                        principalColumn: "BracoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_BracoMovimento_movimentoBracoDireitoUltimoId",
                        column: x => x.movimentoBracoDireitoUltimoId,
                        principalTable: "BracoMovimento",
                        principalColumn: "BracoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_BracoMovimento_movimentoBracoEsquerdoAtualId",
                        column: x => x.movimentoBracoEsquerdoAtualId,
                        principalTable: "BracoMovimento",
                        principalColumn: "BracoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_BracoMovimento_movimentoBracoEsquerdoUltimoId",
                        column: x => x.movimentoBracoEsquerdoUltimoId,
                        principalTable: "BracoMovimento",
                        principalColumn: "BracoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoAtualId",
                        column: x => x.movimentoCabecaInclinacaoAtualId,
                        principalTable: "CabecaRotacaoMovimento",
                        principalColumn: "CabecaRotacaoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaInclinacaoUltimoId",
                        column: x => x.movimentoCabecaInclinacaoUltimoId,
                        principalTable: "CabecaRotacaoMovimento",
                        principalColumn: "CabecaRotacaoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoAtualId",
                        column: x => x.movimentoCabecaRotacaoAtualId,
                        principalTable: "CabecaRotacaoMovimento",
                        principalColumn: "CabecaRotacaoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Robo_CabecaRotacaoMovimento_movimentoCabecaRotacaoUltimoId",
                        column: x => x.movimentoCabecaRotacaoUltimoId,
                        principalTable: "CabecaRotacaoMovimento",
                        principalColumn: "CabecaRotacaoMovimentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoDireitoAtualId",
                table: "Robo",
                column: "movimentoBracoDireitoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoDireitoUltimoId",
                table: "Robo",
                column: "movimentoBracoDireitoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoEsquerdoAtualId",
                table: "Robo",
                column: "movimentoBracoEsquerdoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoBracoEsquerdoUltimoId",
                table: "Robo",
                column: "movimentoBracoEsquerdoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoCabecaInclinacaoAtualId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoCabecaInclinacaoUltimoId",
                table: "Robo",
                column: "movimentoCabecaInclinacaoUltimoId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoCabecaRotacaoAtualId",
                table: "Robo",
                column: "movimentoCabecaRotacaoAtualId");

            migrationBuilder.CreateIndex(
                name: "IX_Robo_movimentoCabecaRotacaoUltimoId",
                table: "Robo",
                column: "movimentoCabecaRotacaoUltimoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CabecaInclinacaoMovimento");

            migrationBuilder.DropTable(
                name: "Robo");

            migrationBuilder.DropTable(
                name: "BracoMovimento");

            migrationBuilder.DropTable(
                name: "CabecaRotacaoMovimento");
        }
    }
}
