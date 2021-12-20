using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace Concesionario.Data
{
    public class DBConcesionario : DbContext
    {
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Distribuidora> Distribuidoras { get; set; }
        public DbSet<RolPago> RolPagos { get; set; }
        public DbSet<TablaAmortizacion> TablaAmortizacions { get; set; }
        public DbSet<ResumenAmortizacion> ResumenAmortizacions { get; set; }

        public DBConcesionario(DbContextOptions<DBConcesionario> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Inventario>().HasData(
            new Inventario { Id = 1, Marca = "Chevrolet",Unidades =5,Modelo="Aveo",Color="Negro-Azul-Gris",Estado="Nuevo",Precio_por_unidad= 18.000M },
            new Inventario { Id = 2, Marca = "Chevrolet", Unidades = 3, Modelo = "Spark", Color = "Negro-Azul-Rojo", Estado = "Usado", Precio_por_unidad = 12.000M },
            new Inventario { Id = 3, Marca = "Chevrolet", Unidades = 4, Modelo = "Orlando", Color = "Gris-Blanco", Estado = "Nuevo", Precio_por_unidad = 26.000M },
            new Inventario { Id = 4, Marca = "Chevrolet", Unidades = 2, Modelo = "Camaro", Color = "Negro-Amarillo", Estado = "Nuevo", Precio_por_unidad = 43.000M },
            new Inventario { Id = 5, Marca = "Kia", Unidades = 3, Modelo = "Picanto", Color = "Negro-Rojo-Blanco", Estado = "Usado", Precio_por_unidad = 13.000M },
            new Inventario { Id = 6, Marca = "Kia", Unidades = 6, Modelo = "Sportage", Color = "Blanco-Negro", Estado = "Nuevo", Precio_por_unidad = 28.000M },
            new Inventario { Id = 7, Marca = "Kia", Unidades = 4, Modelo = "Rio", Color = "Negro-Azul", Estado = "Nuevo", Precio_por_unidad = 19.000M },
            new Inventario { Id = 8, Marca = "Nissan", Unidades = 2, Modelo = "Note", Color = "Gris-Blanco-Negro", Estado = "Nuevo", Precio_por_unidad = 17.000M },
            new Inventario { Id = 9, Marca = "Nissan", Unidades = 1, Modelo = "Leaf", Color = "Azul-Blanco", Estado = "Nuevo", Precio_por_unidad = 22.000M }, 
            new Inventario { Id = 10, Marca = "Nissan", Unidades = 5, Modelo = "Navara", Color = "Negro-Azul-Gris", Estado = "Nuevo", Precio_por_unidad = 38.000M },
            new Inventario { Id = 11, Marca = "Nissan", Unidades = 3, Modelo = "Micra", Color = "Negro-Rojo-Blanco", Estado = "Usado", Precio_por_unidad = 25.000M },
            new Inventario { Id = 12, Marca = "Nissan", Unidades = 4, Modelo = "Juke", Color = "Negro-Azul-Rojo", Estado = "Nuevo", Precio_por_unidad = 34.000M },
            new Inventario { Id = 13, Marca = "Toyoya", Unidades = 2, Modelo = "Rav4", Color = "Blanco-Negro", Estado = "Nuevo", Precio_por_unidad = 39.000M }
            
            );
            builder.Entity<Distribuidora>().HasData(
                  new Distribuidora { Id = 1, Distribuidor = "Chevrolet", Modelo = "Spark",Unidades = 2,Motivo = "Minimo-Igualado", Precio_Total = 28.800M },
                  new Distribuidora { Id = 2, Distribuidor = "Chevrolet", Modelo = "Camaro", Unidades = 4, Motivo = "Minimo-Vencido", Precio_Total = 137.600M },
                  new Distribuidora { Id = 3, Distribuidor = "Kia", Modelo = "Picanto", Unidades = 2, Motivo = "Minimo-Igualado", Precio_Total = 41.600M },
                  new Distribuidora { Id = 4, Distribuidor = "Nissan", Modelo = "Note", Unidades = 4, Motivo = "Minimo-Vencido", Precio_Total = 54.400M },
                  new Distribuidora { Id = 5, Distribuidor = "Nissan", Modelo = "Leaf", Unidades = 4, Motivo = "Minimo-Vencido", Precio_Total = 70.400M },
                  new Distribuidora { Id = 6, Distribuidor = "Nissan", Modelo = "Micra", Unidades = 2, Motivo = "Minimo-Igualado", Precio_Total = 40.000M },
                  new Distribuidora { Id = 7, Distribuidor = "Toyota", Modelo = "Rav4", Unidades = 4, Motivo = "Minimo-Vencido", Precio_Total = 124.800M }
            );


            builder.Entity<RolPago>().HasData(
                 new RolPago { Id = 1, Cliente="Elkin David Romero Torrres", Cargo="Empleado-Privado", Sueldo=800M, Horas_extra= 3, Comision= 100M, AporteIEES= 86.96M,Anticipos=50M,Total=793.05M },
                 new RolPago { Id = 2, Cliente = "Marco Eduardo Taco Betancourt", Cargo = "Empleado-Privado", Sueldo = 280M, Horas_extra = 0, Comision = 50M, AporteIEES = 30.86M, Anticipos = 40M, Total = 259.15M },
                 new RolPago { Id = 3, Cliente = "Adrian Sebastian Siguencia Remache", Cargo = "Empleado-Publico", Sueldo = 425M, Horas_extra = 5, Comision = 100M, AporteIEES = 49.58M, Anticipos = 20M, Total = 460.73M },
                 new RolPago { Id = 4, Cliente = "Alex Kevin Pintado Guaman", Cargo = "Empleado-Privado", Sueldo = 250M, Horas_extra = 7, Comision = 70M, AporteIEES = 30.65M, Anticipos = 25M, Total = 272.16M },
                 new RolPago { Id = 5, Cliente = "Luis Alfredo Lopez Condo", Cargo = "Empleado-Privado", Sueldo = 400M, Horas_extra = 0, Comision = 100M, AporteIEES = 46.75M, Anticipos = 85M, Total = 368.25M }


           );

            builder.Entity<TablaAmortizacion>().HasData(
                new TablaAmortizacion { Id = 1, Cliente = "Elkin David Romero Torrres",ValorPrestamo = 18.000M, TNA30_360= "20%",Años=5 ,Frecuencia="Anual",InteresEquivalente= "20.000%", Numeropagos=1,NumeroCuotas=10 },
                new TablaAmortizacion { Id = 2, Cliente = "Marco Eduardo Taco Betancourt", ValorPrestamo = 43.000M, TNA30_360 = "20%", Años = 5, Frecuencia = "Anual", InteresEquivalente = "20.000%", Numeropagos = 1, NumeroCuotas = 5 },
                new TablaAmortizacion { Id = 3, Cliente = "Adrian Sebastian Siguencia Remache", ValorPrestamo = 12.000M, TNA30_360 = "10%", Años = 5, Frecuencia = "Anual", InteresEquivalente = "10.000%", Numeropagos = 1, NumeroCuotas = 5 },
                new TablaAmortizacion { Id = 4, Cliente = "Alex Kevin Pintado Guaman", ValorPrestamo = 38.000M, TNA30_360 = "20%", Años = 10, Frecuencia = "Anual", InteresEquivalente = "20.000%", Numeropagos = 1, NumeroCuotas = 10 },
                new TablaAmortizacion { Id = 5, Cliente = "Luis Alfredo Lopez Condo", ValorPrestamo = 13.000M, TNA30_360 = "10%", Años = 5, Frecuencia = "Anual", InteresEquivalente = "10.000%", Numeropagos = 1, NumeroCuotas = 10 }

          );

            builder.Entity<ResumenAmortizacion>().HasData(
                new ResumenAmortizacion { Id = 1, Cliente = "Elkin David Romero Torrres", ValorPrestamo = 18.000M, SumaCuotas=30.09417M, SumaInteres=12.094017M,Prestamo="Aprobado" },
                new ResumenAmortizacion { Id = 2, Cliente = "Marco Eduardo Taco Betancourt", ValorPrestamo = 43.000M, SumaCuotas = 71.89164M, SumaInteres = 28.89164M, Prestamo = "Rechazado" },
                new ResumenAmortizacion { Id = 3, Cliente = "Adrian Sebastian Siguencia Remache", ValorPrestamo = 12.000M, SumaCuotas = 15.82785M, SumaInteres = 3.82785M, Prestamo = "Aprobado" },
                new ResumenAmortizacion { Id = 4, Cliente = "Alex Kevin Pintado Guaman", ValorPrestamo = 38.000M, SumaCuotas = 90.63865M, SumaInteres = 52.63865M, Prestamo = "Rechazado" },
                new ResumenAmortizacion { Id = 5, Cliente = "Luis Alfredo Lopez Condo", ValorPrestamo = 13.000M, SumaCuotas = 17.14684M, SumaInteres = 4.14684M, Prestamo = "Aprobado" }

          );
        }
    }

}