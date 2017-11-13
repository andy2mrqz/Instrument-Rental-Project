using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalsController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instrument(string instName, string edition)
        {
            ViewBag.InstrumentName = instName;
            ViewBag.ImageSource = instName + ".jpg";
            ViewBag.Edition = edition;

            ViewBag.ImagePrices = new Dictionary<string, double[]>()
            {
                { "trumpet", new double[] {55, 25 } },
                { "trombone", new double[] {60, 35 } },
                { "tuba", new double[] {70, 50 } },
                { "flute", new double[] {40, 25 } },
                { "clarinet", new double[] {35, 27 } },
                { "saxophone", new double[] {42, 30 } }
            };
            return View();
        }
    }
}