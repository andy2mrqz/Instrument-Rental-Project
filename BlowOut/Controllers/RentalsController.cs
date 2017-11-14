using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.DAL;
using BlowOut.Models;
using System.Data.Entity;
using System.Net;

namespace BlowOut.Controllers
{

    public class RentalsController : Controller
    {
        private BLOWOUTContext db = new BLOWOUTContext();

        public ActionResult Index()
        {
            return View(db.Instruments.ToList());
        }

        public ActionResult Instrument(int instrumentID)
        {
            //Create an instrument object from the id
            Instrument instrument = db.Instruments.Find(instrumentID);

            return View(instrument);
        }

        public string Checkout(int instrumentID)
        {
            return "You are currently checking out with item: " + instrumentID;
        }

        public ActionResult Summary(int instrumentID)
        {
            return View();
        }
    }
}

/*
//Find the corresponding new and used IDs/prices so the customer can switch
//Get the instrument list
var instList = db.Instruments.ToList();

//Find the new instrument information
var newquery = from inst in instList
               where inst.instDescription.Equals(instrument.instDescription)
               && inst.type.Equals("new")
               select inst;
            //Pass the id and price to the viewbag
            foreach (var inst in newquery)
            {
                ViewBag.newID = inst.instrumentID;
                ViewBag.newPrice = inst.price;
            }

            //Find the used instrument information
            var usedquery = from inst in instList
                            where inst.instDescription.Equals(instrument.instDescription)
                            && inst.type.Equals("used")
                            select inst;
            //Pass the id and price to the viewbag
            foreach (var inst in usedquery)
            {
                ViewBag.usedID = inst.instrumentID;
                ViewBag.usedPrice = inst.price;
            }
*/