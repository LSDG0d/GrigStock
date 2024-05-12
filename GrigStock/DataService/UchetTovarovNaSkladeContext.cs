using System;
using System.Collections.Generic;
using System.Configuration;
using GrigStock.Model;
using Microsoft.EntityFrameworkCore;

namespace GrigStock.DataService;

public partial class UchetTovarovNaSkladeContext : DbContext
{
    public UchetTovarovNaSkladeContext()
    {
    }

    public UchetTovarovNaSkladeContext(DbContextOptions<UchetTovarovNaSkladeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Planned> Planneds { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Tovar> Tovars { get; set; }

    public virtual DbSet<Model.Type> Types { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings[1].ConnectionString.ToString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.Property(e => e.ClientId).HasColumnName("Client_ID");
            entity.Property(e => e.ClientAddress)
                .HasMaxLength(50)
                .HasColumnName("Client_Address");
            entity.Property(e => e.ClientContact)
                .HasMaxLength(50)
                .HasColumnName("Client_Contact");
            entity.Property(e => e.ClientDescription)
                .HasMaxLength(50)
                .HasColumnName("Client_Description");
            entity.Property(e => e.ClientMail)
                .HasMaxLength(50)
                .HasColumnName("Client_Mail");
            entity.Property(e => e.ClientName)
                .HasMaxLength(50)
                .HasColumnName("Client_Name");
            entity.Property(e => e.ClientPhone)
                .HasMaxLength(50)
                .HasColumnName("Client_Phone");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployeeAddress)
                .HasMaxLength(50)
                .HasColumnName("Employee_Address");
            entity.Property(e => e.EmployeeBirthDay)
                .HasColumnType("datetime")
                .HasColumnName("Employee_BirthDay");
            entity.Property(e => e.EmployeeFirstName)
                .HasMaxLength(50)
                .HasColumnName("Employee_FirstName");
            entity.Property(e => e.EmployeeJobTitle)
                .HasMaxLength(50)
                .HasColumnName("Employee_JobTitle");
            entity.Property(e => e.EmployeeLastName)
                .HasMaxLength(50)
                .HasColumnName("Employee_LastName");
            entity.Property(e => e.EmployeeMail)
                .HasMaxLength(50)
                .HasColumnName("Employee_Mail");
            entity.Property(e => e.EmployeePatronymic)
                .HasMaxLength(50)
                .HasColumnName("Employee_Patronymic");
            entity.Property(e => e.EmployeePhone)
                .HasMaxLength(50)
                .HasColumnName("Employee_Phone");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
            entity.Property(e => e.ClientId).HasColumnName("Client_ID");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.PaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Payment_Date");
            entity.Property(e => e.Recipient).HasMaxLength(50);
            entity.Property(e => e.RecipientAddress)
                .HasMaxLength(50)
                .HasColumnName("Recipient_Address");
            entity.Property(e => e.ShippingDate)
                .HasColumnType("datetime")
                .HasColumnName("Shipping_Date");

            entity.HasOne(d => d.Client).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Clients");

            entity.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Employees");
        });

        modelBuilder.Entity<Planned>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Planned");

            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
            entity.Property(e => e.TovarId).HasColumnName("Tovar_ID");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Planned_Orders");

            entity.HasOne(d => d.Tovar).WithMany()
                .HasForeignKey(d => d.TovarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Planned_Tovars");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PK_Postavshik");

            entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");
            entity.Property(e => e.ProviderAddress)
                .HasMaxLength(50)
                .HasColumnName("Provider_Address");
            entity.Property(e => e.ProviderContact)
                .HasMaxLength(50)
                .HasColumnName("Provider_Contact");
            entity.Property(e => e.ProviderMail)
                .HasMaxLength(50)
                .HasColumnName("Provider_Mail");
            entity.Property(e => e.ProviderName)
                .HasMaxLength(50)
                .HasColumnName("Provider_Name");
            entity.Property(e => e.ProviderPhone)
                .HasMaxLength(50)
                .HasColumnName("Provider_Phone");
        });

        modelBuilder.Entity<Tovar>(entity =>
        {
            entity.Property(e => e.TovarId).HasColumnName("Tovar_ID");
            entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");
            entity.Property(e => e.TovarCost)
                .HasColumnType("money")
                .HasColumnName("Tovar_Cost");
            entity.Property(e => e.TovarCount)
                .HasMaxLength(50)
                .HasColumnName("Tovar_Count");
            entity.Property(e => e.TovarDescription)
                .HasMaxLength(100)
                .HasColumnName("Tovar_Description");
            entity.Property(e => e.TovarName)
                .HasMaxLength(50)
                .HasColumnName("Tovar_Name");
            entity.Property(e => e.TypeId).HasColumnName("Type_ID");

            entity.HasOne(d => d.Provider).WithMany(p => p.Tovars)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tovars_Providers");

            entity.HasOne(d => d.Type).WithMany(p => p.Tovars)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tovars_Types");
        });

        modelBuilder.Entity<Model.Type>(entity =>
        {
            entity.Property(e => e.TypeId).HasColumnName("Type_ID");
            entity.Property(e => e.TypeCategory)
                .HasMaxLength(50)
                .HasColumnName("Type_Category");
            entity.Property(e => e.TypeDescription)
                .HasMaxLength(100)
                .HasColumnName("Type_Description");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId).HasColumnName("User_ID");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(50)
                .HasColumnName("User_Login");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(50)
                .HasColumnName("User_Password");
            entity.Property(e => e.UserRole)
                .HasMaxLength(50)
                .HasColumnName("User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
