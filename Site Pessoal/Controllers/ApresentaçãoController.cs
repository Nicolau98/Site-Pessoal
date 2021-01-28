using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_Pessoal.Controllers
{
    public class ApresentaçãoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
