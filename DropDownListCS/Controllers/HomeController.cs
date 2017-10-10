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
            ViewBag.CountryList = new SelectList(CountryList, "id", "name");
            return View();  
        }

        public JsonResult GetStateList(int CountryId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<states> StateList = db.states.Where(x => x.country_id == CountryId).ToList();   
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCitiesList(int StateId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<cities> CitiesList = db.cities.Where(x => x.state_id == StateId).ToList();
            return Json(CitiesList, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}