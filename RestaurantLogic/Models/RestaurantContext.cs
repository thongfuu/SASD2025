using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestaurantLogic.Models;

public partial class RestaurantContext : DbContext
{
    string connectionString = "";
    public RestaurantContext(string connectionString)
    {
        this.connectionString = connectionString;
    }
    public RestaurantContext(DbContextOptions<RestaurantContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString);
        optionsBuilder.UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("items_pkey");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();

            entity.HasOne(d => d.Table).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("orders_table_id_fkey");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_items_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.IsPrinted).HasDefaultValue(false);
            entity.Property(e => e.Note).HasDefaultValueSql("''::character varying");

            entity.HasOne(d => d.Item).WithMany(p => p.OrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_items_item_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("order_items_order_id_fkey");
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tables_pkey");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Status).HasDefaultValue(0);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
