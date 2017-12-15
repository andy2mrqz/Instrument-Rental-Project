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

        [HttpGet]
        public ActionResult Checkout(int instrumentID)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout([Bind(Include = "clientID,firstname,lastname,address,city,state,zip,email,phone")] Client client, int instrumentID)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(client);
                db.SaveChanges();

                Instrument instrument = db.Instruments.Find(instrumentID);
                instrument.clientID = client.clientID;
                db.SaveChanges();

                return RedirectToAction("Summary", new { clientID = client.clientID, instrumentID = instrumentID  });
            }

            return View(client);
        }

        public ActionResult Summary(int clientID, int instrumentID)
        {
            return View(new ClientInstrument() { client = db.Clients.Find(clientID), instrument = db.Instruments.Find(instrumentID)});
        }

        [HttpGet]
        [Authorize]
        public ActionResult UpdateData()
        {
            IEnumerable<OrderInfo> orderinfo =

                db.Database.SqlQuery<OrderInfo>(
                    "SELECT i.clientID, " +
                    "c.firstname + ' ' + c.lastname \"clientName\", " +
                    "c.address, c.email, c.phone, " +
                    "i.instDescription \"instDesc\", " +
                    "i.type \"instType\", " +
                    "i.price " +
                    "FROM Instrument i " +
                    "LEFT JOIN Client c ON i.clientID = c.clientID " +
                    "WHERE c.clientID IS NOT NULL"
                    );

            return View(orderinfo);
        }
    }
}