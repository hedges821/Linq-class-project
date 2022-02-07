using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LinqLab_MikeHedges.Models;

namespace LinqLab_MikeHedges.Controllers
{
    public class EmployeeController : Controller
    {
        Employee[] EmployeeArray =
        {
            new Employee {EmployeeID = 1, FirstName = "Mike", LastName = "Hedges", Age = 41M },
            new Employee {EmployeeID = 2, FirstName = "Kaylyn", LastName = "Hedges", Age = 33M },
            new Employee {EmployeeID = 3, FirstName = "Lucy", LastName = "Hedges", Age = 1M },
            new Employee {EmployeeID = 4, FirstName = "Kiwi", LastName = "TheCat", Age = 11M },
            new Employee {EmployeeID = 5, FirstName = "Barbra", LastName = "TheDog", Age = 5M },
        };



        // GET: Employee
        public ActionResult Index()
        {
            return View(EmployeeArray);
        }

        // Sort by Age with Query Syntax
        public ActionResult SortByAge()
        {
            var sorted =
                from a in EmployeeArray
                orderby a.Age 
                select a;

            return View("Index", sorted);
        }

        // Sort older than 10 with Method Syntax
        public ActionResult GreaterThanTen()
        {
            var greaterThanTen = EmployeeArray.Where(a => a.Age > 10).OrderBy(a => a.Age);

            return View("Index", greaterThanTen);
        }

        public ActionResult Summary()
        {
            ViewBag.AvgAge = (from a in EmployeeArray
                              select a.Age).Average();

            ViewBag.MaxAge = (from a in EmployeeArray
                              select a.Age).Max();

            ViewBag.NumEmployees = (from a in EmployeeArray
                                    select a).Count();

            return View("Summary");
        }
    }
}
