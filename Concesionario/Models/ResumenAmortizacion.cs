using Concesionario.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApp.Models
{
    public class ResumenAmortizacion: Entidad
    {
        public int Id { get; set; }
        public string Cliente { get; set; }

        public decimal ValorPrestamo { get; set; }

        public decimal SumaCuotas { get; set; }
        public decimal SumaInteres { get; set; }

        public string Prestamo { get; set; }

       

    }
}
