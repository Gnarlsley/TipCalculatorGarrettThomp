using Microsoft.AspNetCore.Mvc;
using TipCalculatorGarrettThomp.Models;

namespace TipCalculatorGarrettThomp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.tipFifteen = 0;
            ViewBag.tipTwenty = 0;
            ViewBag.tipTwentyFive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipInput tip)
        {
            if (ModelState.IsValid)
            {
                ViewBag.tipFifteen = tip.tipFifteen(tip.MealCost);
                ViewBag.tipTwenty = tip.tipTwenty(tip.MealCost);
                ViewBag.tipTwentyFive = tip.tipTwentyFive(tip.MealCost);
            }
            else
            {
                ViewBag.tipFifteen = 0;
                ViewBag.tipTwenty = 0;
                ViewBag.tipTwentyFive = 0;
            }
            return View();
        }
    }
}
