using lb2engineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lb2engineering.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Pound To Engineering Lb2E";//Spot for Floating video or images";

            return View();
        }

        public ActionResult About()
        {
           // ViewBag.Message = "The application description page.";
           // ViewBag.Quote = "With great Power Comes Great Responsibilities.";
            var model = new AboutModel();
            model.Description = "Computer Engineering Graduate";
            model.Name = "Me & this site";
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = " ";

            return View();
        }
    }
}
