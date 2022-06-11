using MvcViewBagData.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewBag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Message from ViewBag";
            ViewBag.CurrentDateTime = DateTime.Now;

            string[] vegetables = { "Carrot", "Broccoli", "Asparagus", "Cucumber", "Eggplant" };
            ViewBag.Vegetables = vegetables;


            ViewBag.Countries = new List<string>
            {
                "Bangladesh",
                "Japan",
                "Saudi Arabia",
                "Egypt",
                "Malaysia"
            };

            Employee employee = new Employee();
            employee.Id = 1;
            employee.EmpName = "Ali";
            employee.EmpAddress = "Mirpur Dhaka";
            employee.Dob = new DateTime(2001, 6, 25);

            ViewBag.AliDetails = employee;

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