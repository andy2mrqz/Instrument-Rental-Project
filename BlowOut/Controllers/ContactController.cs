using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            return "Please call Support at <span style='text-decoration: underline'><b>801-555-1212</b></span>. Thank you!";
        }

        public string Email(string name, string email)
        {
            return "Thank you " + name + ". We will send an email to " + email;
        }
    }
}