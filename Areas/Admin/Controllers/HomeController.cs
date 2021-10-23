using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Project.Areas.Admin.Attributes;

namespace Project.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        [CheckLogin]
        public IActionResult Index()
        {
            return View();
        }
    }
}
