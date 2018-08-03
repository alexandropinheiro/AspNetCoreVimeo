using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StartupDemo.Controllers
{
    public class TesteController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("dashboard/tela-inicial")]
        [Route("dashboard/tela-inicial/{id:int}/{valor:guid}")]
        public IActionResult Index(int id, Guid valor)
        {
            //return View();
            return RedirectToAction("Teste");
        }

        public IActionResult Teste()
        {
            return View("Index");
        }
    }
}