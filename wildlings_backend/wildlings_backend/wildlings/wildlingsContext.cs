using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wildlings_backend.wildlings
{
    public partial class wildlingsContext : DbContext
    {
        public wildlingsContext()
        {
        }

        public wildlingsContext(DbContextOptions<wildlingsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=asdf1234;database=wildlings");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student", "wildlings");

                entity.HasIndex(e => e.Name)
                    .HasName("ix_student_name");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("1");
            });
        }
    }
}
