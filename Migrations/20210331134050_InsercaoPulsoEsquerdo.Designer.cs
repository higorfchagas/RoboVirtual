// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoRoboNddTech.Data;

namespace ProjetoRoboNddTech.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210331134050_InsercaoPulsoEsquerdo")]
    partial class InsercaoPulsoEsquerdo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ProjetoRoboNddTech.Models.BracoCotoveloMovimento", b =>
                {
                    b.Property<int>("BracoCotoveloMovimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BracoCotoveloMovimentoDescricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BracoCotoveloMovimentoId");

                    b.ToTable("BracoCotoveloMovimento");
                });

            modelBuilder.Entity("ProjetoRoboNddTech.Models.BracoPulsoMovimento", b =>
                {
                    b.Property<int>("BracoPulsoMovimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BracoPulsoMovimentoDescricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BracoPulsoMovimentoId");

                    b.ToTable("BracoPulsoMovimento");
                });

            modelBuilder.Entity("ProjetoRoboNddTech.Models.CabecaInclinacaoMovimento", b =>
                {
                    b.Property<int>("CabecaInclinacaoMovimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CabecaInclinacaoMovimentoDescricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CabecaInclinacaoMovimentoId");

                    b.ToTable("CabecaInclinacaoMovimento");
                });

            modelBuilder.Entity("ProjetoRoboNddTech.Models.CabecaRotacaoMovimento", b =>
                {
                    b.Property<int>("CabecaRotacaoMovimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CabecaRotacaoMovimentoDescricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CabecaRotacaoMovimentoId");

                    b.ToTable("CabecaRotacaoMovimento");
                });

            modelBuilder.Entity("ProjetoRoboNddTech.Models.Robo", b =>
                {
                    b.Property<int>("RoboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("movimentoBracoCotoveloDireitoAtualId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoCotoveloDireitoUltimoId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoCotoveloEsquerdoAtualId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoCotoveloEsquerdoUltimoId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoPulsoDireitoAtualId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoPulsoDireitoUltimoId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoPulsoEsquerdoAtualId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoBracoPulsoEsquerdoUltimoId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoCabecaInclinacaoAtualId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoCabecaInclinacaoUltimoId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoCabecaRotacaoAtualId")
                        .HasColumnType("int");

                    b.Property<int?>("movimentoCabecaRotacaoUltimoId")
                        .HasColumnType("int");

                    b.HasKey("RoboId");

                    b.HasIndex("movimentoBracoCotoveloDireitoAtualId");

                    b.HasIndex("movimentoBracoCotoveloDireitoUltimoId");

                    b.HasIndex("movimentoBracoCotoveloEsquerdoAtualId");

                    b.HasIndex("movimentoBracoCotoveloEsquerdoUltimoId");

                    b.HasIndex("movimentoBracoPulsoDireitoAtualId");

                    b.HasIndex("movimentoBracoPulsoDireitoUltimoId");

                    b.HasIndex("movimentoBracoPulsoEsquerdoAtualId");

                    b.HasIndex("movimentoBracoPulsoEsquerdoUltimoId");

                    b.HasIndex("movimentoCabecaInclinacaoAtualId");

                    b.HasIndex("movimentoCabecaInclinacaoUltimoId");

                    b.HasIndex("movimentoCabecaRotacaoAtualId");

                    b.HasIndex("movimentoCabecaRotacaoUltimoId");

                    b.ToTable("Robo");
                });

            modelBuilder.Entity("ProjetoRoboNddTech.Models.Robo", b =>
                {
                    b.HasOne("ProjetoRoboNddTech.Models.BracoCotoveloMovimento", "MovimentoBracoCotoveloDireitoAtual")
                        .WithMany()
                        .HasForeignKey("movimentoBracoCotoveloDireitoAtualId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoCotoveloMovimento", "MovimentoBracoCotoveloDireitoUltimo")
                        .WithMany()
                        .HasForeignKey("movimentoBracoCotoveloDireitoUltimoId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoCotoveloMovimento", "MovimentoBracoCotoveloEsquerdoAtual")
                        .WithMany()
                        .HasForeignKey("movimentoBracoCotoveloEsquerdoAtualId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoCotoveloMovimento", "MovimentoBracoCotoveloEsquerdoUltimo")
                        .WithMany()
                        .HasForeignKey("movimentoBracoCotoveloEsquerdoUltimoId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoPulsoMovimento", "MovimentoBracoPulsoDireitoAtual")
                        .WithMany()
                        .HasForeignKey("movimentoBracoPulsoDireitoAtualId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoPulsoMovimento", "MovimentoBracoPulsoDireitoUltimo")
                        .WithMany()
                        .HasForeignKey("movimentoBracoPulsoDireitoUltimoId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoPulsoMovimento", "MovimentoBracoPulsoEsquerdoAtual")
                        .WithMany()
                        .HasForeignKey("movimentoBracoPulsoEsquerdoAtualId");

                    b.HasOne("ProjetoRoboNddTech.Models.BracoPulsoMovimento", "MovimentoBracoPulsoEsquerdoUltimo")
                        .WithMany()
                        .HasForeignKey("movimentoBracoPulsoEsquerdoUltimoId");

                    b.HasOne("ProjetoRoboNddTech.Models.CabecaRotacaoMovimento", "MovimentoCabecaInclinacaoAtual")
                        .WithMany()
                        .HasForeignKey("movimentoCabecaInclinacaoAtualId");

                    b.HasOne("ProjetoRoboNddTech.Models.CabecaRotacaoMovimento", "MovimentoCabecaInclinacaoUltimo")
                        .WithMany()
                        .HasForeignKey("movimentoCabecaInclinacaoUltimoId");

                    b.HasOne("ProjetoRoboNddTech.Models.CabecaRotacaoMovimento", "MovimentoCabecaRotacaoAtual")
                        .WithMany()
                        .HasForeignKey("movimentoCabecaRotacaoAtualId");

                    b.HasOne("ProjetoRoboNddTech.Models.CabecaRotacaoMovimento", "MovimentoCabecaRotacaoUltimo")
                        .WithMany()
                        .HasForeignKey("movimentoCabecaRotacaoUltimoId");

                    b.Navigation("MovimentoBracoCotoveloDireitoAtual");

                    b.Navigation("MovimentoBracoCotoveloDireitoUltimo");

                    b.Navigation("MovimentoBracoCotoveloEsquerdoAtual");

                    b.Navigation("MovimentoBracoCotoveloEsquerdoUltimo");

                    b.Navigation("MovimentoBracoPulsoDireitoAtual");

                    b.Navigation("MovimentoBracoPulsoDireitoUltimo");

                    b.Navigation("MovimentoBracoPulsoEsquerdoAtual");

                    b.Navigation("MovimentoBracoPulsoEsquerdoUltimo");

                    b.Navigation("MovimentoCabecaInclinacaoAtual");

                    b.Navigation("MovimentoCabecaInclinacaoUltimo");

                    b.Navigation("MovimentoCabecaRotacaoAtual");

                    b.Navigation("MovimentoCabecaRotacaoUltimo");
                });
#pragma warning restore 612, 618
        }
    }
}
