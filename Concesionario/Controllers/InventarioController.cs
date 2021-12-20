using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Concesionario.Data;
using WebApp.Models;
using System.Linq;
using Concesionario.Models;

namespace Concesionario.Controllers
{
    public class InventarioController : Controller
    {
        private readonly DBConcesionario dB;
        public InventarioController(DBConcesionario db)
        {
            dB = db;
        }
        //Metodos para las vistas
        // Lista de Items
        public IActionResult Inventario(string marca="", int paginaActual=1)
        {
            int registrosPorPagina = 5;

            IEnumerable<Inventario> ListaInventarios = 
                dB.Inventarios
                .Where(inv =>string.IsNullOrEmpty(marca) || inv.Marca==marca )
                .OrderBy(inv => inv.Id)
                .Skip((paginaActual-1)* registrosPorPagina) //Saltarse los primeros (p-1)*n registros
                .Take(registrosPorPagina);
            int totalDeRegistros = dB.Inventarios.Count();

            var modeloConPaginacion = new Paginacion { 
                entidades = ListaInventarios,
                PaginaActual = paginaActual,
                RegistrosPorPagina= registrosPorPagina,
                TotalDeRegistros= totalDeRegistros
        };
            
            return View(modeloConPaginacion);
        }
        [HttpGet]
            
                                           
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Inventario inventario)
        {
            dB.Inventarios.Add(inventario);
            dB.SaveChanges();
            return RedirectToAction("Inventario");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Inventario inventario = dB.Inventarios.Find(id);
            return View(inventario);
        }
        [HttpPost]
        public IActionResult Edit(Inventario inventario)
        {

            dB.Inventarios.Update(inventario);
            dB.SaveChanges();
            return RedirectToAction("Inventario");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Inventario inventario = dB.Inventarios.Find(id);
            return View(inventario);
        }
        [HttpPost]
        public IActionResult Delete(Inventario inventario)
        {
            dB.Inventarios.Remove(inventario);
            dB.SaveChanges();
            return RedirectToAction("Inventario");
        }
    }
}