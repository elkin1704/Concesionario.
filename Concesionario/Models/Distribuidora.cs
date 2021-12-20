using Concesionario.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApp.Models
{
    public class Distribuidora: Entidad

    {
        public int Id { get; set; }
        public string Distribuidor { get; set; }
        
        public string Modelo { get; set; }
        public int Unidades { get; set; }

        public string Motivo { get; set; }

        public decimal Precio_Total { get; set; }
    }
}