﻿using CIS174_AmyMiles.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_AmyMiles.Controllers
{
    public class OlympicController : Controller
    {
        private CountryContext context;
        public OlympicController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeDivision = "all", string activeSport = "all")        
        {
            //store selected division nad sport IDs in view bag
            ViewBag.ActiveDivision = activeDivision;
            ViewBag.ActiveSport = activeSport;

            //store divisions, settings and sports from the db in view bag
            //ViewBag.Divisions = context.Divisions.ToList();
            //ViewBag.Sports = context.Sports.ToList();
            //ViewBag.Settings = context.Settings.ToList();

            //get list of divisions and sports
            List<Division> divisions = context.Divisions.ToList();
            List<Sport> sports = context.Sports.ToList();

            //insert default "All" value at front fo each list
            divisions.Insert(0, new Division { DivisionID = "all", Name = "All" }) ;
            sports.Insert(0, new Sport { SportID = "all", Name = "All" });

            //save lists
            ViewBag.Divisions = divisions ;
            ViewBag.Sports = sports ;

            //get countries - filter by division and sport
            IQueryable<Country> query = context.Countries.OrderBy(c => c.Name);
            if (activeDivision != "all") 
                query = query.Where(c => c.Division.DivisionID.ToLower() == activeDivision.ToLower());
            if (activeSport != "all")
                query = query.Where(c => c.Sport.SportID.ToLower() == activeSport.ToLower());

            //pass the list of countries to the view as model
            var countries = query.ToList();
            return View(countries);
        }
    }
}