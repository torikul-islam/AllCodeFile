using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorials.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Countries = new List<string>
            //{
            //    "Bangladesh",
            //    "India",
            //    "Australia",
            //    "England",
            //};
            //return View();

            ViewData["Country"] = new List<string>
            {
                "Bangladesh",
                "India",
                "Australia",
                "England",
            };
            return View();

        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}