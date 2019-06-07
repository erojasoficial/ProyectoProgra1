using System.Linq;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class RecibosController : Controller
    {
        private TiendaContext _context { get; }

        public RecibosController(TiendaContext context) {
            _context = context;
        } 

        [HttpPost]
        public IActionResult Registro_Recibos(Recibo p)
        {
            if (ModelState.IsValid) {
                _context.Recibos.Add(p);
                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }

    }
}