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
            if (ModelState.IsValid)
            {
                GroundswellEntities1 ORM = new GroundswellEntities1();

                List<User> OutputList = new List<User>();

                OutputList = (from u in ORM.Users
                              where u.EmailAddress == user.EmailAddress
                              select u).ToList();

                if (OutputList.Count == 0)
                {
                    ORM.Users.Add(user);
                    ORM.SaveChanges();

                    //TODO: Make the HTML use a pop-up/modal or alert and stay on registration page
                    ViewBag.FirstName = user.FirstName;

                    return View();
                }
                else
                {
                    //TODO: Add another tab to explain to the user that account is already established
                    ViewBag.FirstName = "ALREADY TAKEN" +
                        "";

                    return View();
                }
            }
            else
            {
                //redirect user back to the form
                return View("RegisterNewUser");
            }
        }

        public ActionResult ListItems ()
        {
            return View("ItemsView");
        }
    }
}