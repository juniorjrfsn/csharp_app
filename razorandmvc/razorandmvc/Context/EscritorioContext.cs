using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using razorandmvc.Models;

namespace razorandmvc.Context;

public partial class EscritorioContext : DbContext
{
    public EscritorioContext()
    {
    }

    public EscritorioContext(DbContextOptions<EscritorioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; } = null!;

    public virtual DbSet<Empresa> Empresas { get; set; } = null!;

    public virtual DbSet<Funcao> Funcaos { get; set; } = null!;

    public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\njunior\\Documents\\projetos\\C#APP\\Banco\\App_Data\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Cliid).HasName("PK__Cliente__FA1F2CB3E38232BA");

            entity.ToTable("Cliente");

            entity.Property(e => e.Cliid).HasColumnOrder(0);
            entity.Property(e => e.Clicpf)
                .HasMaxLength(20)
                .HasColumnOrder(2)
                .IsFixedLength();
            entity.Property(e => e.Clidatanascimento)
                .HasColumnOrder(3)
                .HasColumnType("date");
            entity.Property(e => e.Cliendereco)
                .HasMaxLength(200)
                .HasColumnOrder(4)
                .IsFixedLength();
            entity.Property(e => e.Climail)
                .HasMaxLength(100)
                .HasColumnOrder(6)
                .IsFixedLength();
            entity.Property(e => e.Clinome)
                .HasMaxLength(100)
                .HasColumnOrder(1);
            entity.Property(e => e.Cliphone)
                .HasMaxLength(15)
                .HasColumnOrder(5)
                .IsFixedLength();
            entity.Property(e => e.UiddtInsert)
                .HasColumnOrder(8)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("UIddtInsert");
            entity.Property(e => e.Uiddtupdate)
                .HasMaxLength(10)
                .HasColumnOrder(10)
                .IsFixedLength();
            entity.Property(e => e.Uidinsert).HasColumnOrder(7);
            entity.Property(e => e.Uidupdate).HasColumnOrder(9);
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Emprid).HasName("PK__Empresa__8D4437FA74FF7D17");

            entity.ToTable("Empresa");

            entity.Property(e => e.Emprid).HasColumnOrder(0);
            entity.Property(e => e.Emprnome)
                .HasMaxLength(100)
                .HasColumnOrder(1);
            entity.Property(e => e.Uiddtinsert)
                .HasColumnOrder(3)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Uiddtupdate)
                .HasColumnOrder(5)
                .HasColumnType("datetime");
            entity.Property(e => e.Uidinsert).HasColumnOrder(2);
            entity.Property(e => e.Uidupdate).HasColumnOrder(4);
        });

        modelBuilder.Entity<Funcao>(entity =>
        {
            entity.HasKey(e => e.Funcid).HasName("PK__Funcao__834CEE3BEDB7C579");

            entity.ToTable("Funcao");

            entity.Property(e => e.Funcid).HasColumnOrder(0);
            entity.Property(e => e.Funcnome)
                .HasMaxLength(20)
                .HasColumnOrder(1)
                .IsFixedLength();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__Usuario__C5B69A4A8BD06A2D");

            entity.ToTable("Usuario");

            entity.Property(e => e.Uid).HasColumnOrder(0);
            entity.Property(e => e.Emprid).HasColumnOrder(1);
            entity.Property(e => e.Uadmin).HasColumnOrder(10);
            entity.Property(e => e.Uativo).HasColumnOrder(11);
            entity.Property(e => e.Ucelular)
                .HasMaxLength(20)
                .HasColumnOrder(8)
                .IsFixedLength();
            entity.Property(e => e.Ucpf)
                .HasMaxLength(20)
                .HasColumnOrder(3)
                .IsFixedLength();
            entity.Property(e => e.Udatanascimento)
                .HasColumnOrder(4)
                .HasColumnType("date");
            entity.Property(e => e.Uemail)
                .HasMaxLength(100)
                .HasColumnOrder(5)
                .IsFixedLength();
            entity.Property(e => e.Ufoto)
                .HasMaxLength(200)
                .HasColumnOrder(9)
                .IsFixedLength();
            entity.Property(e => e.Uiddtinsert)
                .HasColumnOrder(15)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Uiddtupdate)
                .HasColumnOrder(17)
                .HasColumnType("datetime");
            entity.Property(e => e.Uidinsert).HasColumnOrder(14);
            entity.Property(e => e.Uidupdate).HasColumnOrder(16);
            entity.Property(e => e.Ulogon).HasColumnOrder(12);
            entity.Property(e => e.Unome)
                .HasMaxLength(50)
                .HasColumnOrder(2);
            entity.Property(e => e.Uphone)
                .HasMaxLength(20)
                .HasColumnOrder(7)
                .IsFixedLength();
            entity.Property(e => e.Usenha)
                .HasColumnOrder(6)
                .HasColumnType("text");
            entity.Property(e => e.Usuporte).HasColumnOrder(13);

            entity.HasOne(d => d.Empr).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.Emprid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Usuario_Empresa");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
