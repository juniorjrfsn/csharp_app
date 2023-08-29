namespace POO2EF.ModelData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PrototipoDB : DbContext
    {
        public PrototipoDB()
            : base("name=PrototipoDB")
        {
        }

        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<Idioma> Idiomas { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Regiao> Regioes { get; set; }
        public virtual DbSet<TipoLogradouro> TipoLogradouros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.UrlSite)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Fone)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.SiglaUF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.RegiaoBrasil)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Municipios)
                .WithRequired(e => e.Estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Idioma>()
                .Property(e => e.Abreviado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Idioma>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.SiglaUF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.Abreviacao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Preco)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Regiao>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Regiao>()
                .HasMany(e => e.Estadoes)
                .WithRequired(e => e.Regiao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoLogradouro>()
                .Property(e => e.Descricao)
                .IsUnicode(false);
        }
    }
}
