using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CadastroDesktop.Model
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.cpf_cnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.cep)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.limite)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.telefone)
                .IsUnicode(false);
        }
    }
}
