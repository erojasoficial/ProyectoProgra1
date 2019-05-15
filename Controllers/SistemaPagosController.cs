using System.Linq;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class SistemaPagosController : Controller
    {
        private TiendaContext _context { get; }

        public SistemaPagosController(TiendaContext context) {
            _context = context;
        } 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro_Alumnos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registro_Alumnos(SistemaPago p)
        {
            if (ModelState.IsValid) {
                _context.SistemaPagos.Add(p);
                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }

        public IActionResult Listar()
        {
            var alumnos = _context.SistemaPagos.ToList();

            return View(alumnos);
        }
    }
}