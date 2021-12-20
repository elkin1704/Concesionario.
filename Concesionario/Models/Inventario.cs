using Concesionario.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApp.Models
{
    public class Inventario: Entidad
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public int Unidades { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public string Estado { get; set; }

        public decimal Precio_por_unidad { get; set; }
    }
}