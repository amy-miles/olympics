using CIS174_AmyMiles.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174_AmyMiles.Controllers
{
    public class TicketController : Controller
    {
        private TicketContext context;
        public TicketController (TicketContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.Statuses = context.Statuses.ToList();

            IQueryable<Ticket> query = context.Tickets
                .Include(t => t.Status);
             if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }  
             var tasks = query.OrderBy(t => t.StatusId).ToList();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Statuses = context.Statuses.ToList();
            var task = new Ticket { StatusId = "todo" };
            return View(task);
        }

        [HttpPost]
        public IActionResult Add(Ticket task) 
        {
            if (ModelState.IsValid)
            {
                context.Tickets.Add(task);
                context.SaveChanges();
                return RedirectToAction("Index", "Ticket");
            }
            else
            {
                ViewBag.Statuses = context.Statuses.ToList();
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Filter(string filter)
        {
            return RedirectToAction("Index", "Ticket", new {id = filter});
        }

        [HttpPost]
        public IActionResult MarkDone([FromRoute] string id, Ticket selected)
        {
            selected = context.Tickets.Find(selected.TicketId) !;
            if (selected != null)
            {
                selected.StatusId = "done";
                context.SaveChanges();
            }

            return RedirectToAction("Index", "Ticket", new { id});
        }

        [HttpPost]
        public IActionResult MarkInProgress([FromRoute] string id, int TicketId)
        {
            var selected = context.Tickets.Find(TicketId)!;
            if (selected != null)
            {
                selected.StatusId = "inprogress";
                context.SaveChanges();
            }

            return RedirectToAction("Index", "Ticket", new { id });
        }

        [HttpPost]
        public IActionResult MarkQA([FromRoute] string id, Ticket selected)
        {
            selected = context.Tickets.Find(selected.TicketId)!;
            if (selected != null)
            {
                selected.StatusId = "qa";
                context.SaveChanges();
            }

            return RedirectToAction("Index", "Ticket", new {  id });
        }

        [HttpPost]
        public IActionResult DeleteDone(string id) 
        {
            var toDelete = context.Tickets.Where(t => t.StatusId == "done").ToList();
            foreach(var task in toDelete)
            {
                context.Tickets.Remove(task);
            }
            context.SaveChanges();
            return RedirectToAction("Index", "Ticket");
        }
    }
}
