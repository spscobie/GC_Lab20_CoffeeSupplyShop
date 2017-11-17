using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GC_Deliverable19_Lab20_CoffeeShop_Init.Models;

namespace GC_Deliverable19_Lab20_CoffeeShop_Init.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /*
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
        */
        public ActionResult RegisterNewUser ()
        {
            return View();
        }

        public ActionResult DB_InsertNewUser (User user)
        {
            ViewBag.FirstName = user.FirstName;

            return View();
        }
    }
}