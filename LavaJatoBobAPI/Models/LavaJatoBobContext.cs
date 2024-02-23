using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LavaJatoBobAPI.Models
{
    public partial class LavaJatoBobContext : DbContext
    {
        public LavaJatoBobContext()
        {
        }

        public LavaJatoBobContext(DbContextOptions<LavaJatoBobContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Funcionario> Funcionarios { get; set; } = null!;
        public virtual DbSet<Veiculo> Veiculos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.Nome)
                    .HasColumnType("text")
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cpf");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasColumnType("text")
                    .HasColumnName("nome");

                entity.Property(e => e.Salario)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("salario");

                entity.Property(e => e.Telefone)
                    .HasColumnType("decimal(11, 0)")
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdFuncionario).HasColumnName("id_funcionario");

                entity.Property(e => e.Modelo)
                    .HasColumnType("text")
                    .HasColumnName("modelo");

                entity.Property(e => e.Placa)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("placa");

                entity.Property(e => e.Preco)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("preco");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Veiculos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Veiculos__id_cli__3A81B327");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Veiculos)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("FK__Veiculos__id_fun__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
