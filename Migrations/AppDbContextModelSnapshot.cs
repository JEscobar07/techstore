﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using techstore.Data;

#nullable disable

namespace techstore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("techstore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Equipos de escritorio, laptops, monitores, etc.",
                            Name = "Computadoras y Portátiles"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Smartphones, tablets, accesorios para móviles.",
                            Name = "Teléfonos y Tablets"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Teclados, ratones, webcams, auriculares, y más.",
                            Name = "Accesorios para Computadoras"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tarjetas gráficas, discos duros, fuentes de poder, procesadores.",
                            Name = "Componentes de Hardware"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Discos duros externos, SSDs, memorias USB, tarjetas de memoria.",
                            Name = "Almacenamiento y Memoria"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Routers, switches, cables, adaptadores Wi-Fi.",
                            Name = "Redes y Conectividad"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Cámaras, drones, consolas de videojuegos.",
                            Name = "Electrónica de Consumo"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Sistemas operativos, antivirus, licencias de software.",
                            Name = "Software y Licencias"
                        });
                });

            modelBuilder.Entity("techstore.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("address");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("phoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("techstore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("creationDate");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int")
                        .HasColumnName("idCustomer");

                    b.Property<int>("IdStateOrder")
                        .HasColumnType("int")
                        .HasColumnName("idStateOrder");

                    b.HasKey("Id");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdStateOrder");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("techstore.Models.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountBought")
                        .HasColumnType("int")
                        .HasColumnName("amountBought");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int")
                        .HasColumnName("idOrder");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int")
                        .HasColumnName("idProduct");

                    b.HasKey("Id");

                    b.HasIndex("IdOrder");

                    b.HasIndex("IdProduct");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("techstore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountProducts")
                        .HasColumnType("int")
                        .HasColumnName("amountProducts");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int")
                        .HasColumnName("idCategory");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<double>("Price")
                        .HasColumnType("double")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AmountProducts = 20,
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            IdCategory = 1,
                            Name = "Delbert",
                            Price = 11266.975988206379
                        },
                        new
                        {
                            Id = 2,
                            AmountProducts = 20,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            IdCategory = 6,
                            Name = "Beulah",
                            Price = 96967.042878609966
                        },
                        new
                        {
                            Id = 3,
                            AmountProducts = 10,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            IdCategory = 6,
                            Name = "Louis",
                            Price = 14155.613274532658
                        },
                        new
                        {
                            Id = 4,
                            AmountProducts = 15,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            IdCategory = 2,
                            Name = "Pamela",
                            Price = 7019.2436882127367
                        },
                        new
                        {
                            Id = 5,
                            AmountProducts = 10,
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            IdCategory = 7,
                            Name = "Dave",
                            Price = 59518.109147780902
                        });
                });

            modelBuilder.Entity("techstore.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("techstore.Models.StateOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("StateOrders");
                });

            modelBuilder.Entity("techstore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<int>("IdRol")
                        .HasColumnType("int")
                        .HasColumnName("idRol");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.HasIndex("IdRol");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("techstore.Models.Order", b =>
                {
                    b.HasOne("techstore.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("techstore.Models.StateOrder", "StateOrder")
                        .WithMany()
                        .HasForeignKey("IdStateOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("StateOrder");
                });

            modelBuilder.Entity("techstore.Models.OrderProduct", b =>
                {
                    b.HasOne("techstore.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("IdOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("techstore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("techstore.Models.Product", b =>
                {
                    b.HasOne("techstore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("techstore.Models.User", b =>
                {
                    b.HasOne("techstore.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
