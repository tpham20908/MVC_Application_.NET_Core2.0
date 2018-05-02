using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
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
            ViewBag.TheMessage = "Having trouble, send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            //Todo: send message to HQ
            ViewBag.TheMessage = "Thanks, we got your message.";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
                return Content(serial.ToLower());
            // return Content(serial);
            // return new HttpStatusCodeResult(403);
            // return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            return RedirectToAction("About");
        }
    }
}