using PracticaApp.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticaApp.Controllers
{
    public class RecepcionController : Controller
    {
        public IActionResult Index()
        {
            Recepcion recepcion = new Recepcion(1, 1,"Frule","11.111.111-1",10);
            return View(recepcion);
        }
    }
}