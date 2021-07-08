using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armoney_client.Controllers
{
    public class MoneyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProgressBar()
        {
            ViewBag.num = 10;
            return View();
        }
        public IActionResult WhereIsMyMoney()
        {
            ViewBag.place = "bank";
            ViewBag.money = 150;
            return View();
        }
    }
}
