using DropDownListCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownListCS.Controllers
{
    public class HomeController : Controller
    {
        DropDownCSCEntities db = new DropDownCSCEntities();
        public ActionResult Index()
        {
            List<countries> CountryList = db.countries.ToList();
            ViewBag.CountryList = new SelectList(CountryList, "name", "name");
            return View();  
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}