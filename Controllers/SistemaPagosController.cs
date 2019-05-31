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

         public IActionResult Actualizar(int id)
        {
            var p = _context.SistemaPagos.FirstOrDefault(x => x.Id == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Actualizar(SistemaPago p)
        {
            if (ModelState.IsValid) {
                var productoBd = _context.SistemaPagos.Find(p.Id);

                productoBd.Nombre = p.Nombre;
                productoBd.Apoderado = p.Apoderado;
                productoBd.Direccion = p.Direccion;
                productoBd.Dni = p.Dni;
                productoBd.Celular = p.Celular;
                productoBd.Correo = p.Correo;

                productoBd.Turno = p.Turno;
                productoBd.Aula = p.Aula;
                productoBd.Ciclo = p.Ciclo;
                productoBd.Modalidad = p.Modalidad;
                productoBd.Postula = p.Postula;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            }

            return View(p);
        }
    }
}