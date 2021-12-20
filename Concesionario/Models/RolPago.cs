using Concesionario.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApp.Models
{
    public class RolPago: Entidad
    {
        public int Id { get; set; }
        public string Cliente { get; set; }

        public string Cargo { get; set; }
        
        public decimal Sueldo { get; set; }
        public int Horas_extra { get; set; }

        public decimal Comision { get; set; }

        public decimal AporteIEES { get; set; }

        public decimal Anticipos { get; set; }

        public decimal Total { get; set; }

    }
}