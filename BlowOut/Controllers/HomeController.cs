using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {

            return View();
        }
        
        public ActionResult Contact()
        {

            return View();
        }

        // GET: Home
        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;

            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            if (string.Equals(username, "Missouri") && string.Equals(password, "showMe"))
            {
                FormsAuthentication.SetAuthCookie(username, rememberMe);

                return Redirect(form["ReturnUrl"].ToString());
            }
            else
            {
                return View();
            }
        }

    }
}