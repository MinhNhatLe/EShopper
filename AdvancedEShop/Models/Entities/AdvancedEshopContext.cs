using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AdvancedEShop.Models.Entities
{
    public partial class AdvancedEshopContext : DbContext
    {
        public AdvancedEshopContext()
        {
        }

        public AdvancedEshopContext(DbContextOptions<AdvancedEshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<User> Users { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=LAPTOP-AP54ORLO\\SQLEXPRESS;Initial Catalog=AdvancedEshop;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(150);

                entity.Property(e => e.CategoryPhoto).HasMaxLength(300);

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Categories_User");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.ColorName).HasMaxLength(30);

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Colors)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Colors_User");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ProductPhoto).HasMaxLength(300);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(8, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Products_Categories");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Products_Colors");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_Products_Sizes");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.SizeName).HasMaxLength(30);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Sizes)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Sizes_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.ToTable("User");

                entity.Property(e => e.IdUser).HasColumnName("ID_User");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
