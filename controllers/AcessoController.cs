using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROJETO.Models;

namespace PROJETO.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

       
    }
}
