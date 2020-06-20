using InvoiceApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductStore>().HasKey(ps => new { ps.StoreId, ps.ProductId });

            modelBuilder.Entity<ProductStore>()
                        .HasOne(bc => bc.Store)
                        .WithMany(b => b.ProductStores)
                        .HasForeignKey(bc => bc.StoreId);

            modelBuilder.Entity<ProductStore>()
                        .HasOne(bc => bc.Product)
                        .WithMany(b => b.ProductStores)
                        .HasForeignKey(b => b.ProductId);


            modelBuilder.Entity<Invoice>()
                        .HasKey(i => i.InvoiceId);

            modelBuilder.Entity<Invoice>()
                        .HasAlternateKey(i => i.Code);

            modelBuilder.Entity<Invoice>()
                .Property(a => a.Date).HasColumnType("date");


            modelBuilder.Entity<ProductInvoice>().HasKey(k => k.Id);


            modelBuilder.Entity<ProductInvoice>()
                        .HasOne(pi => pi.Invoice)
                        .WithMany(pi => pi.ProductInvoices)
                        .HasForeignKey(pi => pi.InvoiceId);

            modelBuilder.Entity<ProductInvoice>()
                        .HasOne(pi => pi.Product)
                        .WithMany(pi => pi.ProductInvoices)
                        .HasForeignKey(pi => pi.ProductId);

            modelBuilder.Entity<Unit>().HasKey(key => key.UnitId);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductStore> ProductStores { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<ProductInvoice> ProductInvoices { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

    }
}
