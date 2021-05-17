using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_APD.Controllers
{
    public class InteriorController : Controller
    {
        // GET: Interior
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LivingDesign()        //Salon
        {
            return View("Interior/Livingroom");
        }
        public ActionResult KitchenDesign()        //Cuisine
        {
            return View("Interior/Kitchen");
        }

        public ActionResult BathDesign()           //Salle de Bain
        {
            return View("Interior/Bathroom");
        }

        public ActionResult BedDesign()            //Chambre
        {
            return View("Interior/Bedroom");
        }

        public ActionResult DiningDesign()        //Salle à Manger
        {
            return View("Interior/Diningroom");
        }
    }
}