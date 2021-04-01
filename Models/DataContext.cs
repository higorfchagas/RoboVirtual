using Microsoft.EntityFrameworkCore;
using ProjetoRoboNddTech.Models;

namespace ProjetoRoboNddTech.Data {

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }
        public DbSet<Robo> Robo { get; set; }
        public DbSet<CabecaRotacaoMovimento> CabecaRotacaoMovimento { get; set; }
        public DbSet<CabecaInclinacaoMovimento> CabecaInclinacaoMovimento { get; set; }
        public DbSet<BracoCotoveloMovimento> BracoCotoveloMovimento { get; set; }
        public DbSet<BracoPulsoMovimento> BracoPulsoMovimento { get; set; }
    }
}