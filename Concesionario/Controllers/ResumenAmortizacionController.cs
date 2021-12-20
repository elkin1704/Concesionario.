using Concesionario.Data;
using Concesionario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace Concesionario.Controllers
{
    public class ResumenAmortizacionController : Controller
    {
        private readonly DBConcesionario dB;
        public ResumenAmortizacionController(DBConcesionario db)
        {
            dB = db;
        }
        //Metodos para las vistas
        // Lista de Items
        public IActionResult ResumenAmortizacion(string cliente, int paginaActual = 1)
        {
            int registrosPorPagina = 5;

            IEnumerable<ResumenAmortizacion> ListaResumenAmortizacions =
                dB.ResumenAmortizacions
                 .Where(re => string.IsNullOrEmpty(cliente) || re.Cliente == cliente)
                .OrderBy(re => re.Id)
                .Skip((paginaActual - 1) * registrosPorPagina) //Saltarse los primeros (p-1)*n registros
                .Take(registrosPorPagina);
            int totalDeRegistros = dB.ResumenAmortizacions.Count();

            var modeloConPaginacion = new Paginacion
            {
                entidades = ListaResumenAmortizacions,
                PaginaActual = paginaActual,
                RegistrosPorPagina = registrosPorPagina,
                TotalDeRegistros = totalDeRegistros
            };

            return View(modeloConPaginacion);
        }
        [HttpPost]
        public IActionResult Create(ResumenAmortizacion resumenAmortizacion)
        {
            dB.ResumenAmortizacions.Add(resumenAmortizacion);
            dB.SaveChanges();
            return RedirectToAction("ResumenAmortizacion");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ResumenAmortizacion resumenAmortizacion = dB.ResumenAmortizacions.Find(id);
            return View(resumenAmortizacion);
        }
        [HttpPost]
        public IActionResult Edit(ResumenAmortizacion resumenAmortizacion)
        {

            dB.ResumenAmortizacions.Update(resumenAmortizacion);
            dB.SaveChanges();
            return RedirectToAction("ResumenAmortizacion");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ResumenAmortizacion resumenAmortizacion = dB.ResumenAmortizacions.Find(id);
            return View(resumenAmortizacion);
        }
        [HttpPost]
        public IActionResult Delete(ResumenAmortizacion resumenAmortizacion)
        {
            dB.ResumenAmortizacions.Remove(resumenAmortizacion);
            dB.SaveChanges();
            return RedirectToAction("ResumenAmortizacion");
        }
    }
}
