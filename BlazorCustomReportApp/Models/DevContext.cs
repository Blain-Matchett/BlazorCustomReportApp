﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorCustomReportApp.Models
{
    public partial class DevContext : DbContext
    {
        public DevContext()
        {
        }

        public DevContext(DbContextOptions<DevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreEmployee> StoreEmployee { get; set; }
        public virtual DbSet<StoreProduct> StoreProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreName).HasMaxLength(255);

                entity.Property(e => e.StoreNumber)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Store_Province");
            });

            modelBuilder.Entity<StoreEmployee>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreEmployee)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreEmployee_Store");
            });

            modelBuilder.Entity<StoreProduct>(entity =>
            {
                entity.Property(e => e.ProductPrice).HasColumnType("money");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreProduct)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_StoreProduct_Store");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}