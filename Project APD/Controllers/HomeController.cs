using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_APD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult DisplaySkill()
        {
            return View("Skills");
        }

        public ActionResult DisplayPhilo()
        {
            return View("Philo");
        }

        public ActionResult DisplayPartners()
        {
            return View("Partners");
        }

    }
}