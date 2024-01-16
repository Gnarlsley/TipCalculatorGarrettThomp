using Microsoft.AspNetCore.Mvc;
using TipCalculatorGarrettThomp.Models;

namespace TipCalculatorGarrettThomp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.tipAmount = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipInput tip)
        {
            if (ModelState.IsValid)
            {
                ViewBag.tipAmount = tip.CalculateTip();
            }
            else
            {
                ViewBag.tipAmount = "";
            }
            return View();
        }
    }
}
