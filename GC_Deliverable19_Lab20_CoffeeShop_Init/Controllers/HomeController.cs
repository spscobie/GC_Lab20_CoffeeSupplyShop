using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using GC_Deliverable19_Lab20_CoffeeShop_Init.Models;

namespace GC_Deliverable19_Lab20_CoffeeShop_Init.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult DB_InsertNewUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                GroundswellDAL DAL = new GroundswellDAL();

                if (DAL.InsertUser(newUser) != null)
                {
                    //TODO: Make the HTML use a pop-up/modal or alert and stay on registration page
                    ViewBag.FirstName = newUser.FirstName;

                    return View();
                }
                else
                {
                    //TODO: Add another tab to explain to the user that account is already established
                    ViewBag.FirstName = "ALREADY TAKEN ";

                    return View();
                }
            }
            else
            {
                //redirect user back to the form
                return View("RegisterNewUser");
            }
        }

        public ActionResult Index()
        {
            GroundswellDAL DAL = new GroundswellDAL();

            ViewBag.Items = DAL.RetrieveItemsAll();

            return View();
        }

        public ActionResult ItemAdd(Item newItem)
        {
            if (ModelState.IsValid)
            {
                GroundswellDAL DAL = new GroundswellDAL();

                if (DAL.InsertItem(newItem) != null)
                {
                    return RedirectToAction("ListItems");
                }
                else
                {
                    ViewBag.ProductName = newItem.ProductName;
                    return View();
                }
            }
            else
            {
                return View("ItemAddForm");
            }
        }

        public ActionResult ItemAddForm ()
        {
            return View();
        }

        public ActionResult ItemDelete (int pid)
        {
            GroundswellDAL DAL = new GroundswellDAL();

            DAL.DropItem(pid);

            return RedirectToAction("ListItems");
        }

        public ActionResult ItemEdit (Item editItem)
        {
            GroundswellDAL DAL = new GroundswellDAL();

            DAL.UpdateItem(editItem);

            return RedirectToAction("ListItems");
        }

        public ActionResult ItemEditForm (int pid)
        {
            GroundswellDAL DAL = new GroundswellDAL();

            if (DAL.RetrieveItem(pid) != null)
            {
                ViewBag.EditItem = DAL.RetrieveItem(pid);
                return View("ItemEditForm");
            }
            else
            {
                return RedirectToAction("ListItems");
            }
        }

        public ActionResult ListItems()
        {
            GroundswellDAL DAL = new GroundswellDAL();

            ViewBag.Items = DAL.RetrieveItemsAll();

            return View("ItemsView");
        }

        public ActionResult RegisterNewUser()
        {
            return View();
        }
    }
}