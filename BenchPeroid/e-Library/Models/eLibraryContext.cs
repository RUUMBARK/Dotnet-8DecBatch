using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using e_Library.Models;

namespace e_Library.Models
{
    public partial class eLibraryContext : DbContext
    {
        public eLibraryContext()
        {
        }

        public eLibraryContext(DbContextOptions<eLibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }
        public virtual DbSet<BookIssue> BookIssues { get; set; }
        public virtual DbSet<CategoryBookJoin> CategoryBookJoins { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__Book__DE90ADE7F8780664");

                entity.ToTable("Book");

                entity.Property(e => e.Bid)
                    .ValueGeneratedNever()
                    .HasColumnName("bid");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Publication)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookCategory>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__BookCate__D837D05F4C93B160");

                entity.ToTable("BookCategory");

                entity.Property(e => e.Cid)
                    .ValueGeneratedNever()
                    .HasColumnName("cid");

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookIssue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BookIssue");

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.Sid).HasColumnName("sid");
            });

            modelBuilder.Entity<CategoryBookJoin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CategoryBookJoin");

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.Cid).HasColumnName("cid");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Student__DDDFDD361371CE68");

                entity.ToTable("Student");

                entity.HasIndex(e => e.Username, "UQ__Student__536C85E4F0B12AB8")
                    .IsUnique();

                entity.HasIndex(e => e.Password, "UQ__Student__87909B15EBFB35E9")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Student__A9D1053488DBB676")
                    .IsUnique();

                entity.HasIndex(e => e.Contact, "UQ__Student__F7C046658CF7E65C")
                    .IsUnique();

                entity.Property(e => e.Sid)
                    .ValueGeneratedNever()
                    .HasColumnName("sid");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
