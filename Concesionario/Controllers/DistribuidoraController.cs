using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Concesionario.Data;
using WebApp.Models;
using System.Linq;
using Concesionario.Models;

namespace Concesionario.Controllers
{
    public class DistribuidoraController : Controller
    {
        private readonly DBConcesionario dB;
        public DistribuidoraController(DBConcesionario db)
        {
            dB = db;
        }
        //Metodos para las vistas
        // Lista de Items
        public IActionResult Distribuidora(string distribuidor= "", int paginaActual = 1)
        {
            int registrosPorPagina = 5;

            IEnumerable<Distribuidora> ListaDistribuidoras =
                dB.Distribuidoras
                .Where(dib => string.IsNullOrEmpty(distribuidor) || dib.Distribuidor == distribuidor)
                .OrderBy(dib => dib.Id)
                .Skip((paginaActual - 1) * registrosPorPagina) //Saltarse los primeros (p-1)*n registros
                .Take(registrosPorPagina);
            int totalDeRegistros = dB.Distribuidoras.Count();

            var modeloConPaginacion = new Paginacion
            {
                entidades = ListaDistribuidoras,
                PaginaActual = paginaActual,
                RegistrosPorPagina = registrosPorPagina,
                TotalDeRegistros = totalDeRegistros
            };

            return View(modeloConPaginacion);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Distribuidora distribuidora)
        {
            dB.Distribuidoras.Add(distribuidora);
            dB.SaveChanges();
            return RedirectToAction("Distribuidora");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Distribuidora distribuidora = dB.Distribuidoras.Find(id);
            return View(distribuidora);
        }
        [HttpPost]
        public IActionResult Edit(Distribuidora distribuidora)
        {

            dB.Distribuidoras.Update(distribuidora);
            dB.SaveChanges();
            return RedirectToAction("Distribuidora");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Distribuidora distribuidora = dB.Distribuidoras.Find(id);
            return View(distribuidora);
        }
        [HttpPost]
        public IActionResult Delete(Distribuidora distribuidora)
        {
            dB.Distribuidoras.Remove(distribuidora);
            dB.SaveChanges();
            return RedirectToAction("Distribuidora");
        }
    }
}
