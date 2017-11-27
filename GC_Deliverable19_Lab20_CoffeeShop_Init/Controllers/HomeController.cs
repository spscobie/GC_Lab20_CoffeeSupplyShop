﻿using System;
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

        public ActionResult DB_InsertNewUser(User user)
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
            return View();
        }

        public ActionResult ItemAdd(Item newItem)
        {
            if (ModelState.IsValid)
            {
                GroundswellEntities1 ORM = new GroundswellEntities1();

                List<Item> items = new List<Item>();
                items = (from i in ORM.Items
                         where i.ProductName == newItem.ProductName
                         select i).ToList();

                if (items.Count == 0)
                {
                    ORM.Items.Add(newItem);
                    ORM.SaveChanges();

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

        public ActionResult ItemDelete(int pid)
        {
            GroundswellEntities1 ORM = new GroundswellEntities1();

            Item i = ORM.Items.Find(pid);
            if (i != null)
            {
                ORM.Items.Remove(i);
                ORM.SaveChanges();
            }

            return RedirectToAction("ListItems");
        }

        public ActionResult ItemEdit (Item editItem)
        {
            GroundswellEntities1 ORM = new GroundswellEntities1();

            //int i = editItem.ProductId;
            //string str = editItem.ProductId.ToString();

            Item temp = ORM.Items.Find(editItem.ProductId);
            temp.ProductName = editItem.ProductName;
            temp.ProductDesc = editItem.ProductDesc;
            temp.Qty = editItem.Qty;
            temp.Price = editItem.Price;

            ORM.Entry(temp).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();

            return RedirectToAction("ListItems");
        }

        public ActionResult ItemEditForm (int pid)
        {
            GroundswellEntities1 ORM = new GroundswellEntities1();

            Item editItem = ORM.Items.Find(pid);
            if (editItem != null)
            {
                ViewBag.EditItem = editItem;
                return View("ItemEditForm");
            }
            else
            {
                return RedirectToAction("ListItems");
            }
        }

        public ActionResult ListItems()
        {
            GroundswellEntities1 ORM = new GroundswellEntities1();
            List<Item> items = new List<Item>();

            items = ORM.Items.ToList();

            ViewBag.Items = items;

            return View("ItemsView");
        }

        public ActionResult RegisterNewUser()
        {
            return View();
        }
    }
}