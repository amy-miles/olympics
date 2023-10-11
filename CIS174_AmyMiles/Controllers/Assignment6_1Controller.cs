using Microsoft.AspNetCore.Mvc;
using CIS174_AmyMiles.Models;
namespace CIS174_AmyMiles.Controllers
{
    public class Assignment6_1Controller : Controller
    {
        
        
            public ActionResult Index(int accessLevel)
            {
                var students = new List<Student>
            {
                new Student { FirstName = "Amy", LastName = "Miles", Grade = 98 },
                new Student { FirstName = "Zachary", LastName = "Ryan", Grade = 85 },
                new Student { FirstName = "Sophia", LastName = "Louise", Grade = 100 },
                new Student { FirstName = "Parker", LastName = "John", Grade = 78 },
                new Student { FirstName = "John", LastName = "Charles", Grade = 95 }
            };

                var viewModel = new Assignment6_1ViewModel
                {
                    Students = students,
                    AccessLevel = accessLevel
                };

                return View(viewModel);
            }
       
    }
}
