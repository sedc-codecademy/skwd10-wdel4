﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.Lamazon.DataAccess.DataContext;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("InvoiceStatusId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceStatusId");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.InvoiceLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("OrderLineItemId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("OrderLineItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceLineItems");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.InvoiceStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("InvoiceStatuses");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.OrderLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountPercentage")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("ProductPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderLineItem");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Role", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Key");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RoleKey")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleKey");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Invoice", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Enitities.InvoiceStatus", "InvoiceStatus")
                        .WithMany("Invoices")
                        .HasForeignKey("InvoiceStatusId")
                        .HasConstraintName("FK_Invoice_InvoiceStatus")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Enitities.Order", "Order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_Invoice_Order")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Enitities.User", "User")
                        .WithMany("Invoices")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Invoice_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("InvoiceStatus");

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.InvoiceLineItem", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Enitities.Invoice", "Invoice")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_InvoiceLineItem_Invoice")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Enitities.OrderLineItem", "OrderLineItem")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("OrderLineItemId")
                        .HasConstraintName("FK_InvoiceLineItem_OrderLineItem")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Enitities.Product", "Product")
                        .WithMany("InvoiceLineItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_InvoiceLineItem_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("OrderLineItem");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Order", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Enitities.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .HasConstraintName("FK_Order_OrderStatus")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Enitities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Order_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("OrderStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.OrderLineItem", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Enitities.Order", "Order")
                        .WithMany("OrderLineItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderLineItem_Order")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("SEDC.Lamazon.Domain.Enitities.Product", "Product")
                        .WithMany("OrderLineItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderLineItem_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Product", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Enitities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .HasConstraintName("FK_Product_ProductCategory")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.User", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Enitities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleKey")
                        .HasConstraintName("FK_User_Role")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Invoice", b =>
                {
                    b.Navigation("InvoiceLineItems");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.InvoiceStatus", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Order", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("OrderLineItems");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.OrderLineItem", b =>
                {
                    b.Navigation("InvoiceLineItems");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Product", b =>
                {
                    b.Navigation("InvoiceLineItems");

                    b.Navigation("OrderLineItems");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Enitities.User", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
