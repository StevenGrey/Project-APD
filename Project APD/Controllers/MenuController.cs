using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_APD.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
      
        public ActionResult DisplayServices()   //Services
        {
            return View("Services");
        }

        public ActionResult DisplayDiy()        //Atelier et Cours de Bricolage
        {
            return View("CourseDiy");
        }

        public ActionResult DisplayNewsEvents() //Actualités et Événements
        {
            return View("NewsEvents");
        }

        public ActionResult DisplayMeeting()    //Rendez-vous
        {
            return View("Meeting");
        }
    }
}