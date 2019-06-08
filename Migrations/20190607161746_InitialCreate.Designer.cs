﻿// <auto-generated />
using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUD.Migrations
{
    [DbContext(typeof(TiendaContext))]
    [Migration("20190607161746_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUD.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Foto");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<decimal>("Precio");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("CRUD.Models.Recibo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cuenta1");

                    b.Property<string>("Cuenta2");

                    b.Property<string>("Cuenta3");

                    b.Property<string>("Cuenta4");

                    b.Property<string>("Cuenta5");

                    b.Property<string>("Cuenta6");

                    b.Property<int>("Id_Alumno");

                    b.Property<string>("Monto1");

                    b.Property<string>("Monto2");

                    b.Property<string>("Monto3");

                    b.Property<string>("Monto4");

                    b.Property<string>("Monto5");

                    b.Property<string>("Monto6");

                    b.HasKey("Id");

                    b.ToTable("Recibos");
                });

            modelBuilder.Entity("CRUD.Models.SistemaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apoderado");

                    b.Property<string>("Aula");

                    b.Property<string>("Celular");

                    b.Property<string>("Ciclo");

                    b.Property<string>("Correo");

                    b.Property<string>("Cuenta1");

                    b.Property<string>("Cuenta2");

                    b.Property<string>("Cuenta3");

                    b.Property<string>("Cuenta4");

                    b.Property<string>("Cuenta5");

                    b.Property<string>("Cuenta6");

                    b.Property<string>("Direccion");

                    b.Property<string>("Dni");

                    b.Property<string>("Modalidad");

                    b.Property<string>("Monto1");

                    b.Property<string>("Monto2");

                    b.Property<string>("Monto3");

                    b.Property<string>("Monto4");

                    b.Property<string>("Monto5");

                    b.Property<string>("Monto6");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Postula");

                    b.Property<string>("Turno");

                    b.HasKey("Id");

                    b.ToTable("SistemaPagos");
                });
#pragma warning restore 612, 618
        }
    }
}