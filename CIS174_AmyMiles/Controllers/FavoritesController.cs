using CIS174_AmyMiles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174_AmyMiles.Controllers
{
    public class FavoritesController : Controller
    {
        //all updated per pg 353
        private CountryContext context;
        public FavoritesController(CountryContext ctx) => context = ctx;

        [HttpGet]
        public ViewResult Index()
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new OlympicViewModel
            {
                ActiveDivision = session.GetActiveDivision(),
                ActiveSport = session.GetActiveSport(),
                Countries = session.GetMyCountries()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(Country country)
        {
            country = context.Countries
                .Include(c => c.Division)
                .Include(c => c.Sport)
                .Where(c => c.CountryID == country.CountryID)
                .FirstOrDefault() ?? new Country();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(country);
            session.SetMyCountries(countries);

            //notify user and redirect to olympic home page
            TempData["message"] = $"{country.Name} added to your favorites";
            //olympic controller?
            return RedirectToAction("Index", "Olympic",
                new {
                        ActiveDivision = session.GetActiveDivision() ,
                        ActiveSport = session.GetActiveSport()
                });            
        }


        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new OlympicSession(HttpContext.Session);
            session.RemoveMyCountries();
            //notify user and redirect to home olympic page
            TempData["message"] = "Favorite countries cleared";
            return RedirectToAction("Index", "Olympic",
               new
               {
                   ActiveDivision = session.GetActiveDivision(),
                   ActiveSport = session.GetActiveSport()
               });
        }
    }
}
