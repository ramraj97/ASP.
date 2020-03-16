using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly employeeinterface _ei;
        public HomeController(employeeinterface employee)
        {
            _ei = employee;
        }
        public ActionResult Index()
        {
            var alls = _ei.Getall();
            return View(alls);
        }
        public ActionResult details(int ID)
        {
            employee models = _ei.Getemployee(ID);
            ViewBag.person = models;
            ViewBag.title = "detail page";
            return View(models);
        }

        public ActionResult form()
        {
            return View();
        }
    }
}
