using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armoney_client.Controllers
{
    public class CommercialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Suggestions()
        {
            return View();
        }
        public IActionResult Lessons()
        {
            return View();
        }
    }
}
