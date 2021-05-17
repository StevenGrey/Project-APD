using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_APD.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InteriorDesign()        //Décoration Intérieur
        {
            return View("Interior/Index");
        }

        public ActionResult ExteriorDesign()        //Décoration Extérieur
        {
            return View("Exterior/Index");
        }

        public ActionResult GoldPlating()           //Dorure à la Feuille d'Or
        {
            return View("Gold/Index");
        }

        public ActionResult DescGoldPlating()           //Description Dorure à la Feuille d'Or
        {
            return View("Gold/Description");
        }

        public ActionResult GlazingMirrors()        //Vitrerie et Miroiterie 
        {
            return View("Glazing/Index");
        }
    }
}