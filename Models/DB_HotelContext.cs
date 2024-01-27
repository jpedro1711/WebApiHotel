using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DB_Hotel
{
    public class DB_HotelContext : DbContext
    {
        public DbSet<Endereco> Endereco {get; set;} = null!;
        public DbSet<Filial> Filial {get; set;} = null!;
        public DbSet<TipoQuarto> TipoQuarto {get; set;} = null!;
        public DbSet<Quarto> Quarto {get; set;} = null!;        
        public DbSet<TipoFuncionario> TipoFuncionario {get; set;} = null!;
        public DbSet<Funcionario> Funcionario {get; set;} = null!;
        public DbSet<TipoPagamento> TipoPagamento {get; set;} = null!;
        public DbSet<NotaFiscal> NotaFiscal {get; set;} = null!;
        public DbSet<Cliente> Cliente {get; set;} = null!;
        public DbSet<Telefone> Telefone {get; set;} = null!;
        public DbSet<Email> Email {get; set;} = null!;
        public DbSet<ContaCliente> ContaCliente {get; set;} = null!;
        public DbSet<Servico> Servico {get; set;} = null!;
        public DbSet<ContaCliente_Servico> ContaCliente_Servico {get; set;} = null!;
        public DbSet<Consumo> Consumo {get; set;} = null!;
        public DbSet<ContaCliente_Consumo> ContaCliente_Consumo {get; set;} = null!;
        public DbSet<Reserva> Reserva {get; set;} = null!;        

        protected override void OnModelCreating(ModelBuilder modelBuilder)        
        {
            modelBuilder.Entity<TipoQuarto>()
                .Property(e => e.Valor_TipoQuarto)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Quarto>()
                .HasKey(e => new { e.Codigo_Filial, e.Numero_Quarto});

            modelBuilder.Entity<NotaFiscal>()
                .Property(e => e.ValorTotal_NotaFiscal)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Consumo>()
                .Property(e => e.Valor_Consumo)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ContaCliente_Consumo>()
                .HasKey(e => new { e.Codigo_ContaCliente, e.Codigo_Consumo, e.DataHora_Consumo });

            modelBuilder.Entity<Servico>()
                .Property(e => e.Valor_Servico)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ContaCliente_Servico>()
                .HasKey(e => new { e.Codigo_ContaCliente, e.Codigo_Servico, e.DataHora_Servico });

            modelBuilder.Entity<Reserva>()
                .Property(e => e.ValorTotal_Reserva)
                .HasPrecision(5, 2);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NJE93RJ;Database=DB_HOTEL;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");
            
        }

    }
}