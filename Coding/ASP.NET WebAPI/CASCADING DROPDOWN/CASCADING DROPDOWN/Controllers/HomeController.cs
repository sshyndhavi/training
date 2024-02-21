using CASCADING_DROPDOWN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CASCADING_DROPDOWN.Controllers
{
    public class HomeController : Controller
    {
        WordVoyager_MVCEntities1 db = new WordVoyager_MVCEntities1();
        public ActionResult Index()
        {
            List<COUNTRY> countrylist = db.COUNTRies.ToList();
            List<CITY> citiesList = db.CITies.ToList();
            List<STATE> statesList = db.STATES.ToList();
            ViewBag.CountryList = new SelectList(countrylist,"COUNTRYID","COUNTRYNAME");
            ViewBag.CityList = new SelectList(citiesList, "CITYID","CITYNAME");
            ViewBag.StateList = new SelectList(statesList, "STATEID","STATENAME");
            return View();
        }

        public  JsonResult GetStateList(int CountryID)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<STATE> statelist = db.STATES.Where(x=>x.COUNTRYID).ToList();
            return Json(statelist,JsonRequestBehavior.AllowGet);
        }
    }
}