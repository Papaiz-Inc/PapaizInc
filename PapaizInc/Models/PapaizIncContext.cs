using Microsoft.EntityFrameworkCore;
using PapaizInc.Models;

namespace PapaizInc.Data
{
    public class PapaizIncContext : DbContext
    {
        public PapaizIncContext(DbContextOptions<PapaizIncContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>(p =>
           {
               p.HasKey(n => n.ID);
               p.Property(n => n.Descricao).HasMaxLength(40).IsRequired();
           });
            modelBuilder.Entity<Funcionario>(f =>
            {
                f.HasKey(n => n.ID);
                f.Property(n => n.Nome).HasMaxLength(50).IsRequired();
                f.Property(n => n.Telefones).HasMaxLength(50).IsRequired();
                f.Property(n => n.Identidade).HasMaxLength(11).IsRequired();
                f.Property(n => n.CarteiraDeTrabalho).HasMaxLength(20).IsRequired();
                f.Property(n => n.Salario).IsRequired();
                f.Property(n => n.Motorista).IsRequired();
                f.Property(n => n.Tecnico).IsRequired();
                f.Property(n => n.Observacoes).HasMaxLength(70);
            });
        }
    }
}
