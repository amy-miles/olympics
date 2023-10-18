using CIS174_AmyMiles.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_AmyMiles.Controllers
{
    public class Favorites : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Add(Country country)
        {
            //code to store favorite team in session goes here from ch 9
            TempData["message"] = $"{country.Name} added to your favorites";
            return RedirectToAction("Index", "Olympic");//changed from home controller to Olympic
        }
    }
}
