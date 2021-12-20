using Concesionario.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApp.Models
{
    public class TablaAmortizacion: Entidad
    {
        public int Id { get; set; }
        public string Cliente { get; set; }

        public string TNA30_360 { get; set; }
        public int Años { get; set; }
        public decimal ValorPrestamo { get; set; }
        public string Frecuencia { get; set; }

        public string InteresEquivalente { get; set; }

        public int Numeropagos { get; set; }

        public int NumeroCuotas { get; set; }

        

    }
}
