using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using blockTimeWebApi.Domains;

#nullable disable

namespace blockTimeWebApi.Context
{
    public partial class BlockTimeContext : DbContext
    {
        public BlockTimeContext()
        {
        }

        public BlockTimeContext(DbContextOptions<BlockTimeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chaveacesso> Chaveacessos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }
        public virtual DbSet<Tipochave> Tipochaves { get; set; }
        public virtual DbSet<Tipousuario> Tipousuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioZabbix> UsuarioZabbixes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Chaveacesso>(entity =>
            {
                entity.ToTable("CHAVEACESSO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdTipoChave).HasColumnName("idTipoChave");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Chaveacessos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__CHAVEACES__idCli__35BCFE0A");

                entity.HasOne(d => d.IdTipoChaveNavigation)
                    .WithMany(p => p.Chaveacessos)
                    .HasForeignKey(d => d.IdTipoChave)
                    .HasConstraintName("FK__CHAVEACES__idTip__34C8D9D1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("CLIENTE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("EMAIL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__EMAIL__idCliente__31EC6D26");
            });

            modelBuilder.Entity<Telefone>(entity =>
            {
                entity.ToTable("TELEFONE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.Telefone1)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("telefone");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Telefones)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__TELEFONE__idClie__2F10007B");
            });

            modelBuilder.Entity<Tipochave>(entity =>
            {
                entity.ToTable("TIPOCHAVE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<Tipousuario>(entity =>
            {
                entity.ToTable("TIPOUSUARIO");

                entity.HasIndex(e => e.Titulo, "UQ__TIPOUSUA__38FA640FC341338E")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("titulo");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.HasIndex(e => e.Email, "UQ__USUARIO__AB6E616480CD9EC1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdTipoUsuarioNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipoUsuario)
                    .HasConstraintName("FK__USUARIO__idTipoU__286302EC");
            });

            modelBuilder.Entity<UsuarioZabbix>(entity =>
            {
                entity.ToTable("usuarioZabbix");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioZabbixes)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__usuarioZa__idUsu__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
