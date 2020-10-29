using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab04.Controllers
{
    public class LaptopController : Controller
    {
        FilterDbContext db = new FilterDbContext();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
            return PartialView(ListRam);
        }
    }
}