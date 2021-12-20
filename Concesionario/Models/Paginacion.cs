using System.Collections.Generic;
using WebApp.Models;

namespace Concesionario.Models
{
    public class Paginacion
    {
        public IEnumerable<Entidad> entidades { get; set; }
        public int PaginaActual { get; set; }
        public int TotalDeRegistros { get; set; }
        public int RegistrosPorPagina { get; set; }
   
    
    }
}
