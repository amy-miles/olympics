using CIS174_AmyMiles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace CIS174_AmyMiles.Controllers
{
    public class OlympicController : Controller
    {
        private CountryContext context;
        public OlympicController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(OlympicViewModel model)        
        {
            /**************using ViewModel****************************/

            model.Divisions = context.Divisions.ToList();
            model.Sports = context.Sports.ToList();

            IQueryable<Country> query = context.Countries.OrderBy(c => c.Name);
            if (model.ActiveDivision != "all")
                query = query.Where(c => c.Division.DivisionID.ToLower() == model.ActiveDivision.ToLower());
            if (model.ActiveSport != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == model.ActiveSport.ToLower());
            model.Countries = query.ToList();
            ViewBag.Message = TempData["message"];//do I need this?
            return View(model);


        }

        [HttpPost]//added this from pg 315
        public RedirectToActionResult Add(Country country)
        {
            //code that updates the server with the new team data
            TempData["message"] = $"{country.Name} added to your favorites";
            return RedirectToAction("Index", "Olympic");
        }

       public IActionResult Details(string id)//page 323
        {
            var country = context.Countries
                .Include(c => c.Division)
                .Include(c => c.Sport)
                .FirstOrDefault(c => c.CountryID == id) ?? new Country();
            return View(country);
        }


    }
}
