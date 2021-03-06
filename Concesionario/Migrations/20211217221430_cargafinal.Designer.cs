// <auto-generated />
using Concesionario.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Concesionario.Migrations
{
    [DbContext(typeof(DBConcesionario))]
    [Migration("20211217221430_cargafinal")]
    partial class cargafinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebApp.Models.Distribuidora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Distribuidor")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<string>("Motivo")
                        .HasColumnType("text");

                    b.Property<decimal>("Precio_Total")
                        .HasColumnType("numeric");

                    b.Property<int>("Unidades")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Distribuidoras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Distribuidor = "Chevrolet",
                            Modelo = "Spark",
                            Motivo = "Minimo-Igualado",
                            Precio_Total = 28.800m,
                            Unidades = 2
                        },
                        new
                        {
                            Id = 2,
                            Distribuidor = "Chevrolet",
                            Modelo = "Camaro",
                            Motivo = "Minimo-Vencido",
                            Precio_Total = 137.600m,
                            Unidades = 4
                        },
                        new
                        {
                            Id = 3,
                            Distribuidor = "Kia",
                            Modelo = "Picanto",
                            Motivo = "Minimo-Igualado",
                            Precio_Total = 41.600m,
                            Unidades = 2
                        },
                        new
                        {
                            Id = 4,
                            Distribuidor = "Nissan",
                            Modelo = "Note",
                            Motivo = "Minimo-Vencido",
                            Precio_Total = 54.400m,
                            Unidades = 4
                        },
                        new
                        {
                            Id = 5,
                            Distribuidor = "Nissan",
                            Modelo = "Leaf",
                            Motivo = "Minimo-Vencido",
                            Precio_Total = 70.400m,
                            Unidades = 4
                        },
                        new
                        {
                            Id = 6,
                            Distribuidor = "Nissan",
                            Modelo = "Micra",
                            Motivo = "Minimo-Igualado",
                            Precio_Total = 40.000m,
                            Unidades = 2
                        },
                        new
                        {
                            Id = 7,
                            Distribuidor = "Toyota",
                            Modelo = "Rav4",
                            Motivo = "Minimo-Vencido",
                            Precio_Total = 124.800m,
                            Unidades = 4
                        });
                });

            modelBuilder.Entity("WebApp.Models.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .HasColumnType("text");

                    b.Property<string>("Marca")
                        .HasColumnType("text");

                    b.Property<string>("Modelo")
                        .HasColumnType("text");

                    b.Property<decimal>("Precio_por_unidad")
                        .HasColumnType("numeric");

                    b.Property<int>("Unidades")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Inventarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Negro-Azul-Gris",
                            Estado = "Nuevo",
                            Marca = "Chevrolet",
                            Modelo = "Aveo",
                            Precio_por_unidad = 18.000m,
                            Unidades = 5
                        },
                        new
                        {
                            Id = 2,
                            Color = "Negro-Azul-Rojo",
                            Estado = "Usado",
                            Marca = "Chevrolet",
                            Modelo = "Spark",
                            Precio_por_unidad = 12.000m,
                            Unidades = 3
                        },
                        new
                        {
                            Id = 3,
                            Color = "Gris-Blanco",
                            Estado = "Nuevo",
                            Marca = "Chevrolet",
                            Modelo = "Orlando",
                            Precio_por_unidad = 26.000m,
                            Unidades = 4
                        },
                        new
                        {
                            Id = 4,
                            Color = "Negro-Amarillo",
                            Estado = "Nuevo",
                            Marca = "Chevrolet",
                            Modelo = "Camaro",
                            Precio_por_unidad = 43.000m,
                            Unidades = 2
                        },
                        new
                        {
                            Id = 5,
                            Color = "Negro-Rojo-Blanco",
                            Estado = "Usado",
                            Marca = "Kia",
                            Modelo = "Picanto",
                            Precio_por_unidad = 13.000m,
                            Unidades = 3
                        },
                        new
                        {
                            Id = 6,
                            Color = "Blanco-Negro",
                            Estado = "Nuevo",
                            Marca = "Kia",
                            Modelo = "Sportage",
                            Precio_por_unidad = 28.000m,
                            Unidades = 6
                        },
                        new
                        {
                            Id = 7,
                            Color = "Negro-Azul",
                            Estado = "Nuevo",
                            Marca = "Kia",
                            Modelo = "Rio",
                            Precio_por_unidad = 19.000m,
                            Unidades = 4
                        },
                        new
                        {
                            Id = 8,
                            Color = "Gris-Blanco-Negro",
                            Estado = "Nuevo",
                            Marca = "Nissan",
                            Modelo = "Note",
                            Precio_por_unidad = 17.000m,
                            Unidades = 2
                        },
                        new
                        {
                            Id = 9,
                            Color = "Azul-Blanco",
                            Estado = "Nuevo",
                            Marca = "Nissan",
                            Modelo = "Leaf",
                            Precio_por_unidad = 22.000m,
                            Unidades = 1
                        },
                        new
                        {
                            Id = 10,
                            Color = "Negro-Azul-Gris",
                            Estado = "Nuevo",
                            Marca = "Nissan",
                            Modelo = "Navara",
                            Precio_por_unidad = 38.000m,
                            Unidades = 5
                        },
                        new
                        {
                            Id = 11,
                            Color = "Negro-Rojo-Blanco",
                            Estado = "Usado",
                            Marca = "Nissan",
                            Modelo = "Micra",
                            Precio_por_unidad = 25.000m,
                            Unidades = 3
                        },
                        new
                        {
                            Id = 12,
                            Color = "Negro-Azul-Rojo",
                            Estado = "Nuevo",
                            Marca = "Nissan",
                            Modelo = "Juke",
                            Precio_por_unidad = 34.000m,
                            Unidades = 4
                        },
                        new
                        {
                            Id = 13,
                            Color = "Blanco-Negro",
                            Estado = "Nuevo",
                            Marca = "Toyoya",
                            Modelo = "Rav4",
                            Precio_por_unidad = 39.000m,
                            Unidades = 2
                        });
                });

            modelBuilder.Entity("WebApp.Models.ResumenAmortizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cliente")
                        .HasColumnType("text");

                    b.Property<string>("Prestamo")
                        .HasColumnType("text");

                    b.Property<decimal>("SumaCuotas")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SumaInteres")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorPrestamo")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("ResumenAmortizacions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cliente = "Elkin David Romero Torrres",
                            Prestamo = "Aprobado",
                            SumaCuotas = 30.09417m,
                            SumaInteres = 12.094017m,
                            ValorPrestamo = 18.000m
                        },
                        new
                        {
                            Id = 2,
                            Cliente = "Marco Eduardo Taco Betancourt",
                            Prestamo = "Rechazado",
                            SumaCuotas = 71.89164m,
                            SumaInteres = 28.89164m,
                            ValorPrestamo = 43.000m
                        },
                        new
                        {
                            Id = 3,
                            Cliente = "Adrian Sebastian Siguencia Remache",
                            Prestamo = "Aprobado",
                            SumaCuotas = 15.82785m,
                            SumaInteres = 3.82785m,
                            ValorPrestamo = 12.000m
                        },
                        new
                        {
                            Id = 4,
                            Cliente = "Alex Kevin Pintado Guaman",
                            Prestamo = "Rechazado",
                            SumaCuotas = 90.63865m,
                            SumaInteres = 52.63865m,
                            ValorPrestamo = 38.000m
                        },
                        new
                        {
                            Id = 5,
                            Cliente = "Luis Alfredo Lopez Condo",
                            Prestamo = "Aprobado",
                            SumaCuotas = 17.14684m,
                            SumaInteres = 4.14684m,
                            ValorPrestamo = 13.000m
                        });
                });

            modelBuilder.Entity("WebApp.Models.RolPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Anticipos")
                        .HasColumnType("numeric");

                    b.Property<decimal>("AporteIEES")
                        .HasColumnType("numeric");

                    b.Property<string>("Cargo")
                        .HasColumnType("text");

                    b.Property<string>("Cliente")
                        .HasColumnType("text");

                    b.Property<decimal>("Comision")
                        .HasColumnType("numeric");

                    b.Property<int>("Horas_extra")
                        .HasColumnType("integer");

                    b.Property<decimal>("Sueldo")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("RolPagos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Anticipos = 50m,
                            AporteIEES = 86.96m,
                            Cargo = "Empleado-Privado",
                            Cliente = "Elkin David Romero Torrres",
                            Comision = 100m,
                            Horas_extra = 3,
                            Sueldo = 800m,
                            Total = 793.05m
                        },
                        new
                        {
                            Id = 2,
                            Anticipos = 40m,
                            AporteIEES = 30.86m,
                            Cargo = "Empleado-Privado",
                            Cliente = "Marco Eduardo Taco Betancourt",
                            Comision = 50m,
                            Horas_extra = 0,
                            Sueldo = 280m,
                            Total = 259.15m
                        },
                        new
                        {
                            Id = 3,
                            Anticipos = 20m,
                            AporteIEES = 49.58m,
                            Cargo = "Empleado-Publico",
                            Cliente = "Adrian Sebastian Siguencia Remache",
                            Comision = 100m,
                            Horas_extra = 5,
                            Sueldo = 425m,
                            Total = 460.73m
                        },
                        new
                        {
                            Id = 4,
                            Anticipos = 25m,
                            AporteIEES = 30.65m,
                            Cargo = "Empleado-Privado",
                            Cliente = "Alex Kevin Pintado Guaman",
                            Comision = 70m,
                            Horas_extra = 7,
                            Sueldo = 250m,
                            Total = 272.16m
                        },
                        new
                        {
                            Id = 5,
                            Anticipos = 85m,
                            AporteIEES = 46.75m,
                            Cargo = "Empleado-Privado",
                            Cliente = "Luis Alfredo Lopez Condo",
                            Comision = 100m,
                            Horas_extra = 0,
                            Sueldo = 400m,
                            Total = 368.25m
                        });
                });

            modelBuilder.Entity("WebApp.Models.TablaAmortizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Años")
                        .HasColumnType("integer");

                    b.Property<string>("Cliente")
                        .HasColumnType("text");

                    b.Property<string>("Frecuencia")
                        .HasColumnType("text");

                    b.Property<string>("InteresEquivalente")
                        .HasColumnType("text");

                    b.Property<int>("NumeroCuotas")
                        .HasColumnType("integer");

                    b.Property<int>("Numeropagos")
                        .HasColumnType("integer");

                    b.Property<string>("TNA30_360")
                        .HasColumnType("text");

                    b.Property<decimal>("ValorPrestamo")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("TablaAmortizacions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Años = 5,
                            Cliente = "Elkin David Romero Torrres",
                            Frecuencia = "Anual",
                            InteresEquivalente = "20.000%",
                            NumeroCuotas = 10,
                            Numeropagos = 1,
                            TNA30_360 = "20%",
                            ValorPrestamo = 18.000m
                        },
                        new
                        {
                            Id = 2,
                            Años = 5,
                            Cliente = "Marco Eduardo Taco Betancourt",
                            Frecuencia = "Anual",
                            InteresEquivalente = "20.000%",
                            NumeroCuotas = 5,
                            Numeropagos = 1,
                            TNA30_360 = "20%",
                            ValorPrestamo = 43.000m
                        },
                        new
                        {
                            Id = 3,
                            Años = 5,
                            Cliente = "Adrian Sebastian Siguencia Remache",
                            Frecuencia = "Anual",
                            InteresEquivalente = "10.000%",
                            NumeroCuotas = 5,
                            Numeropagos = 1,
                            TNA30_360 = "10%",
                            ValorPrestamo = 12.000m
                        },
                        new
                        {
                            Id = 4,
                            Años = 10,
                            Cliente = "Alex Kevin Pintado Guaman",
                            Frecuencia = "Anual",
                            InteresEquivalente = "20.000%",
                            NumeroCuotas = 10,
                            Numeropagos = 1,
                            TNA30_360 = "20%",
                            ValorPrestamo = 38.000m
                        },
                        new
                        {
                            Id = 5,
                            Años = 5,
                            Cliente = "Luis Alfredo Lopez Condo",
                            Frecuencia = "Anual",
                            InteresEquivalente = "10.000%",
                            NumeroCuotas = 10,
                            Numeropagos = 1,
                            TNA30_360 = "10%",
                            ValorPrestamo = 13.000m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
