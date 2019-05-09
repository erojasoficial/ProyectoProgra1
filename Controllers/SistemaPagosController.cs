using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class SistemaPagos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registro_Alumnos()
        {
            return View();
        }
    }
}