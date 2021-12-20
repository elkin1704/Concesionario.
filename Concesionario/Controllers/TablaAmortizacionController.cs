using Concesionario.Data;
using Concesionario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace Concesionario.Controllers
{
    public class TablaAmortizacionController : Controller
    {
        private readonly DBConcesionario dB;
        public TablaAmortizacionController(DBConcesionario db)
        {
            dB = db;
        }
        //Metodos para las vistas
        // Lista de Items
        public IActionResult TablaAmortizacion(string cliente ,int paginaActual = 1)
        {
            int registrosPorPagina = 5;

            IEnumerable<TablaAmortizacion> ListaTablaAmortizacions =
                dB.TablaAmortizacions
                 .Where(tab => string.IsNullOrEmpty(cliente) || tab.Cliente == cliente)
                .OrderBy(tab => tab.Id)
                .Skip((paginaActual - 1) * registrosPorPagina) //Saltarse los primeros (p-1)*n registros
                .Take(registrosPorPagina);
            int totalDeRegistros = dB.TablaAmortizacions.Count();

            var modeloConPaginacion = new Paginacion
            {
                entidades = ListaTablaAmortizacions,
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
        public IActionResult Create(TablaAmortizacion tablaAmortizacion)
        {
            dB.TablaAmortizacions.Add(tablaAmortizacion);
            dB.SaveChanges();
            return RedirectToAction("TablaAmortizacion");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            TablaAmortizacion tablaAmortizacion = dB.TablaAmortizacions.Find(id);
            return View(tablaAmortizacion);
        }
        [HttpPost]
        public IActionResult Edit(TablaAmortizacion tablaAmortizacion)
        {

            dB.TablaAmortizacions.Update(tablaAmortizacion);
            dB.SaveChanges();
            return RedirectToAction("TablaAmortizacion");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            TablaAmortizacion tablaAmortizacion = dB.TablaAmortizacions.Find(id);
            return View(tablaAmortizacion);
        }
        [HttpPost]
        public IActionResult Delete(TablaAmortizacion tablaAmortizacion)
        {
            dB.TablaAmortizacions.Remove(tablaAmortizacion);
            dB.SaveChanges();
            return RedirectToAction("TablaAmortizacion");
        }
    }
}
