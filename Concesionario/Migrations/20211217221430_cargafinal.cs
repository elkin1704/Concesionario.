using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Concesionario.Migrations
{
    public partial class cargafinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Distribuidoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Distribuidor = table.Column<string>(type: "text", nullable: true),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    Unidades = table.Column<int>(type: "integer", nullable: false),
                    Motivo = table.Column<string>(type: "text", nullable: true),
                    Precio_Total = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distribuidoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Unidades = table.Column<int>(type: "integer", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    Precio_por_unidad = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResumenAmortizacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cliente = table.Column<string>(type: "text", nullable: true),
                    ValorPrestamo = table.Column<decimal>(type: "numeric", nullable: false),
                    SumaCuotas = table.Column<decimal>(type: "numeric", nullable: false),
                    SumaInteres = table.Column<decimal>(type: "numeric", nullable: false),
                    Prestamo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResumenAmortizacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolPagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cliente = table.Column<string>(type: "text", nullable: true),
                    Cargo = table.Column<string>(type: "text", nullable: true),
                    Sueldo = table.Column<decimal>(type: "numeric", nullable: false),
                    Horas_extra = table.Column<int>(type: "integer", nullable: false),
                    Comision = table.Column<decimal>(type: "numeric", nullable: false),
                    AporteIEES = table.Column<decimal>(type: "numeric", nullable: false),
                    Anticipos = table.Column<decimal>(type: "numeric", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolPagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaAmortizacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cliente = table.Column<string>(type: "text", nullable: true),
                    TNA30_360 = table.Column<string>(type: "text", nullable: true),
                    Años = table.Column<int>(type: "integer", nullable: false),
                    ValorPrestamo = table.Column<decimal>(type: "numeric", nullable: false),
                    Frecuencia = table.Column<string>(type: "text", nullable: true),
                    InteresEquivalente = table.Column<string>(type: "text", nullable: true),
                    Numeropagos = table.Column<int>(type: "integer", nullable: false),
                    NumeroCuotas = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaAmortizacions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Distribuidoras",
                columns: new[] { "Id", "Distribuidor", "Modelo", "Motivo", "Precio_Total", "Unidades" },
                values: new object[,]
                {
                    { 1, "Chevrolet", "Spark", "Minimo-Igualado", 28.800m, 2 },
                    { 2, "Chevrolet", "Camaro", "Minimo-Vencido", 137.600m, 4 },
                    { 3, "Kia", "Picanto", "Minimo-Igualado", 41.600m, 2 },
                    { 4, "Nissan", "Note", "Minimo-Vencido", 54.400m, 4 },
                    { 5, "Nissan", "Leaf", "Minimo-Vencido", 70.400m, 4 },
                    { 6, "Nissan", "Micra", "Minimo-Igualado", 40.000m, 2 },
                    { 7, "Toyota", "Rav4", "Minimo-Vencido", 124.800m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Inventarios",
                columns: new[] { "Id", "Color", "Estado", "Marca", "Modelo", "Precio_por_unidad", "Unidades" },
                values: new object[,]
                {
                    { 13, "Blanco-Negro", "Nuevo", "Toyoya", "Rav4", 39.000m, 2 },
                    { 12, "Negro-Azul-Rojo", "Nuevo", "Nissan", "Juke", 34.000m, 4 },
                    { 10, "Negro-Azul-Gris", "Nuevo", "Nissan", "Navara", 38.000m, 5 },
                    { 9, "Azul-Blanco", "Nuevo", "Nissan", "Leaf", 22.000m, 1 },
                    { 8, "Gris-Blanco-Negro", "Nuevo", "Nissan", "Note", 17.000m, 2 },
                    { 7, "Negro-Azul", "Nuevo", "Kia", "Rio", 19.000m, 4 },
                    { 11, "Negro-Rojo-Blanco", "Usado", "Nissan", "Micra", 25.000m, 3 },
                    { 5, "Negro-Rojo-Blanco", "Usado", "Kia", "Picanto", 13.000m, 3 },
                    { 4, "Negro-Amarillo", "Nuevo", "Chevrolet", "Camaro", 43.000m, 2 },
                    { 3, "Gris-Blanco", "Nuevo", "Chevrolet", "Orlando", 26.000m, 4 },
                    { 6, "Blanco-Negro", "Nuevo", "Kia", "Sportage", 28.000m, 6 },
                    { 2, "Negro-Azul-Rojo", "Usado", "Chevrolet", "Spark", 12.000m, 3 },
                    { 1, "Negro-Azul-Gris", "Nuevo", "Chevrolet", "Aveo", 18.000m, 5 }
                });

            migrationBuilder.InsertData(
                table: "ResumenAmortizacions",
                columns: new[] { "Id", "Cliente", "Prestamo", "SumaCuotas", "SumaInteres", "ValorPrestamo" },
                values: new object[,]
                {
                    { 4, "Alex Kevin Pintado Guaman", "Rechazado", 90.63865m, 52.63865m, 38.000m },
                    { 3, "Adrian Sebastian Siguencia Remache", "Aprobado", 15.82785m, 3.82785m, 12.000m },
                    { 5, "Luis Alfredo Lopez Condo", "Aprobado", 17.14684m, 4.14684m, 13.000m },
                    { 1, "Elkin David Romero Torrres", "Aprobado", 30.09417m, 12.094017m, 18.000m },
                    { 2, "Marco Eduardo Taco Betancourt", "Rechazado", 71.89164m, 28.89164m, 43.000m }
                });

            migrationBuilder.InsertData(
                table: "RolPagos",
                columns: new[] { "Id", "Anticipos", "AporteIEES", "Cargo", "Cliente", "Comision", "Horas_extra", "Sueldo", "Total" },
                values: new object[,]
                {
                    { 1, 50m, 86.96m, "Empleado-Privado", "Elkin David Romero Torrres", 100m, 3, 800m, 793.05m },
                    { 2, 40m, 30.86m, "Empleado-Privado", "Marco Eduardo Taco Betancourt", 50m, 0, 280m, 259.15m },
                    { 3, 20m, 49.58m, "Empleado-Publico", "Adrian Sebastian Siguencia Remache", 100m, 5, 425m, 460.73m },
                    { 4, 25m, 30.65m, "Empleado-Privado", "Alex Kevin Pintado Guaman", 70m, 7, 250m, 272.16m },
                    { 5, 85m, 46.75m, "Empleado-Privado", "Luis Alfredo Lopez Condo", 100m, 0, 400m, 368.25m }
                });

            migrationBuilder.InsertData(
                table: "TablaAmortizacions",
                columns: new[] { "Id", "Años", "Cliente", "Frecuencia", "InteresEquivalente", "NumeroCuotas", "Numeropagos", "TNA30_360", "ValorPrestamo" },
                values: new object[,]
                {
                    { 4, 10, "Alex Kevin Pintado Guaman", "Anual", "20.000%", 10, 1, "20%", 38.000m },
                    { 1, 5, "Elkin David Romero Torrres", "Anual", "20.000%", 10, 1, "20%", 18.000m },
                    { 2, 5, "Marco Eduardo Taco Betancourt", "Anual", "20.000%", 5, 1, "20%", 43.000m },
                    { 3, 5, "Adrian Sebastian Siguencia Remache", "Anual", "10.000%", 5, 1, "10%", 12.000m },
                    { 5, 5, "Luis Alfredo Lopez Condo", "Anual", "10.000%", 10, 1, "10%", 13.000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Distribuidoras");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "ResumenAmortizacions");

            migrationBuilder.DropTable(
                name: "RolPagos");

            migrationBuilder.DropTable(
                name: "TablaAmortizacions");
        }
    }
}
