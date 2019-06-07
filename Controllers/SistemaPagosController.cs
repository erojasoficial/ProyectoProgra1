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

        public IActionResult Registro_Pagos(int id)
        {
            var p = _context.SistemaPagos.FirstOrDefault(x => x.Id == id);

            if (p == null) {
                return NotFound();
            }

            return View(p);
        }

        [HttpPost]
        public IActionResult Registro_Pagos(SistemaPago p)
        {

                var productoBd = _context.SistemaPagos.Find(p.Id);

                productoBd.Cuenta1 = p.Cuenta1;
                productoBd.Monto1 = p.Monto1;
                productoBd.Cuenta2 = p.Cuenta2;
                productoBd.Monto2 = p.Monto2;
                productoBd.Cuenta3 = p.Cuenta3;
                productoBd.Monto3 = p.Monto3;
                productoBd.Cuenta4 = p.Cuenta4;
                productoBd.Monto4 = p.Monto4;
                productoBd.Cuenta5 = p.Cuenta5;
                productoBd.Monto5 = p.Monto5;
                productoBd.Cuenta6 = p.Cuenta6;
                productoBd.Monto6 = p.Monto6;

                _context.SaveChanges();

                return RedirectToAction("Listar");
            
        }

        public IActionResult Borrar(int id)
        {
            var p = _context.SistemaPagos.FirstOrDefault(x => x.Id == id);

            if (p != null) {
                _context.SistemaPagos.Remove(p);
                _context.SaveChanges();
            }

            return RedirectToAction("Listar");
        }
    }
}