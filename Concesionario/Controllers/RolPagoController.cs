using Concesionario.Data;
using Concesionario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace Concesionario.Controllers
{
    public class RolPagoController : Controller
    {
        private readonly DBConcesionario dB;
        public RolPagoController(DBConcesionario db)
        {
            dB = db;
        }
        //Metodos para las vistas
        // Lista de Items
        public IActionResult RolPago(string cliente,int paginaActual = 1)
        {
            int registrosPorPagina = 5;

            IEnumerable<RolPago> ListaRolPagos =
                dB.RolPagos
                .Where(rol => string.IsNullOrEmpty(cliente) || rol.Cliente == cliente)
                .OrderBy(rol => rol.Id)
                .Skip((paginaActual - 1) * registrosPorPagina) //Saltarse los primeros (p-1)*n registros
                .Take(registrosPorPagina);
            int totalDeRegistros = dB.RolPagos.Count();

            var modeloConPaginacion = new Paginacion
            {
                entidades = ListaRolPagos,
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
        public IActionResult Create(RolPago rolPago)
        {
            dB.RolPagos.Add(rolPago);
            dB.SaveChanges();
            return RedirectToAction("RolPago");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            RolPago rolPago = dB.RolPagos.Find(id);
            return View(rolPago);
        }
        [HttpPost]
        public IActionResult Edit(RolPago rolPago)
        {

            dB.RolPagos.Update(rolPago);
            dB.SaveChanges();
            return RedirectToAction("RolPago");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            RolPago rolPago = dB.RolPagos.Find(id);
            return View(rolPago);
        }
        [HttpPost]
        public IActionResult Delete(RolPago rolPago)
        {
            dB.RolPagos.Remove(rolPago);
            dB.SaveChanges();
            return RedirectToAction("RolPago");
        }
    }
}
