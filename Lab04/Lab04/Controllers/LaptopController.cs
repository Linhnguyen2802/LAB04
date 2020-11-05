using Lab04.Helper;
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
        public ActionResult GetSearchFilter()
        {
            SearchParameters search = new SearchParameters();
            var listlaptop = db.laptops.ToList();
            //company
            search.Company          = listlaptop.GroupBy(l => l.Company).Select(l => l.Key).ToList();
            //CPU
            search.CPU              = listlaptop.GroupBy(l => l.Cpu).Select(l => l.Key).ToList();
            //type name
            search.TypeName         = listlaptop.GroupBy(l => l.TypeName).Select(l => l.Key).ToList();
            //Ram
            search.Memory           = listlaptop.GroupBy(l => l.Memory).Select(l => l.Key).ToList();
            //OS
            search.OS               = listlaptop.GroupBy(l => l.OpSys).Select(l => l.Key).ToList();
            //ScreenResolution
            search.ScreenResolution = listlaptop.GroupBy(l => l.ScreenResolution).Select(l => l.Key).ToList();
            //speed
            //search.Speed            = listlaptop.GroupBy(l => l.Speed).Select(l => l.Key).ToList();
            //Wright
            //search.Weight           = listlaptop.GroupBy(l => l.Weight).Select(l => l.Key).ToList();
            //PriceHigh
            //search.PriceHigh      = listlaptop.GroupBy(l => l.Price_euros).Select(l => l.Key).ToList();

            return PartialView(search);
        }
        ////Company
        //public ActionResult getCompany()
        //{
        //    var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
        //    return PartialView(ListCompany);
        //}
        ////CPU
        //public ActionResult getCPU()
        //{
        //    var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
        //    return PartialView(ListCPU);
        //}
        ////Ram
        //public ActionResult getRam()
        //{
        //    var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
        //    return PartialView(ListRam);
        //}
        ////Inches
        //public ActionResult getInches()
        //{
        //    var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
        //    return PartialView(ListInches);
        //}

    }
}