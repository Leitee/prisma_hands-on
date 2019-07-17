﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prisma.Demo.DATA.Dals;

namespace Prisma.Demo.DATA.Migrations
{
    [DbContext(typeof(PrismaDbContext))]
    partial class PrismaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prisma.Demo.MODEL.Entity.Competidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle");

                    b.Property<string>("Codigo");

                    b.Property<decimal>("Latitud");

                    b.Property<decimal>("Longitud");

                    b.Property<int>("MarcaId");

                    b.Property<bool>("Marcador");

                    b.Property<string>("Nombre");

                    b.Property<bool>("Observar");

                    b.Property<int>("ZonaDePrecioId");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.HasIndex("ZonaDePrecioId");

                    b.ToTable("Competidores","Prisma");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calle = "calle1",
                            Codigo = "codigo1",
                            Latitud = 0m,
                            Longitud = 0m,
                            MarcaId = 1,
                            Marcador = false,
                            Nombre = "nombre1",
                            Observar = false,
                            ZonaDePrecioId = 1
                        },
                        new
                        {
                            Id = 2,
                            Calle = "calle2",
                            Codigo = "codigo2",
                            Latitud = 0m,
                            Longitud = 0m,
                            MarcaId = 2,
                            Marcador = false,
                            Nombre = "nombre2",
                            Observar = false,
                            ZonaDePrecioId = 2
                        },
                        new
                        {
                            Id = 3,
                            Calle = "calle3",
                            Codigo = "codigo3",
                            Latitud = 0m,
                            Longitud = 0m,
                            MarcaId = 3,
                            Marcador = false,
                            Nombre = "nombre3",
                            Observar = false,
                            ZonaDePrecioId = 3
                        });
                });

            modelBuilder.Entity("Prisma.Demo.MODEL.Entity.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Marcas","Prisma");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "marca_codigo1",
                            Nombre = "marca_nombre1"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "marca_codigo2",
                            Nombre = "marca_nombre2"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "marca_codigo3",
                            Nombre = "marca_nombre3"
                        });
                });

            modelBuilder.Entity("Prisma.Demo.MODEL.Entity.ZonaDePrecio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("ZonasDePrecio","Prisma");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "zona_codigo1",
                            Nombre = "zona_nombre1"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "zona_codigo2",
                            Nombre = "zona_nombre2"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "zona_codigo3",
                            Nombre = "zona_nombre3"
                        });
                });

            modelBuilder.Entity("Prisma.Demo.MODEL.Entity.Competidor", b =>
                {
                    b.HasOne("Prisma.Demo.MODEL.Entity.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prisma.Demo.MODEL.Entity.ZonaDePrecio", "ZonaDePrecio")
                        .WithMany()
                        .HasForeignKey("ZonaDePrecioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
