using Microsoft.AspNetCore.Mvc;
using TipCalculatorGarrettThomp.Models;

namespace TipCalculatorGarrettThomp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.tipAmount = false;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipInput tip)
        {
            if (ModelState.IsValid)
            {
                ViewBag.tipAmount = true;
            }
            else
            {
                ViewBag.tipAmount = false;
            }
            return View();
        }
    }
}
