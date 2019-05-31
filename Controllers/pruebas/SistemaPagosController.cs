using System.Linq;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class ProductosController : Controller
    {
        private TiendaContext _context { get; }

        public ProductosController(TiendaContext context) {
            _context = context;
        }

        public IActionResult Actualizar(int id)
        {
            var p = _context.SistemaPagos.FirstOrDefault(x => x.Id == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(Producto p)
        {
            if (ModelState.IsValid) {
                var productoBd = _context.SistemaPagos.Find(p.Id);

                productoBd.Nombre = p.Nombre;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }

        public IActionResult Borrar(int id)
        {
            var p = _context.Productos.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.Productos.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}