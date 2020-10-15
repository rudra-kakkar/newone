using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace edahii.Controllers
{
    public class meController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
