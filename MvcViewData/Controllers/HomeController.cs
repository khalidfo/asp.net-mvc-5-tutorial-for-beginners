using MvcViewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "I'm Index Action of Home Controller.";
            ViewData["Time"] = DateTime.Now.ToLongTimeString();

            //Passing array to ViewData
            string[] fruits = { "Mango", "Jackfruit", "Apple", "Avocados", "Guava" };
            ViewData["Fruit"] = fruits;

            //Passing list object to ViewData
            ViewData["Dish"] = new List<string>
            {
                "Fish Curry",
                "Boiled rice",
                "Bread",
                "Salad",
            };

            //Passing object to ViewData
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Forid";
            employee.Address = "Mirpur, Dhaka";

            ViewData["Employee"] = employee;            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}