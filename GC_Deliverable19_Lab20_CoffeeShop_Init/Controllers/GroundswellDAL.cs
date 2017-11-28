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
    public class GroundswellDAL
    {
        private GroundswellEntities1 ORM = new GroundswellEntities1();

        public void DropItem (int pid)
        {
            if (RetrieveItem(pid) != null)
            {
                ORM.Items.Remove(RetrieveItem(pid));
                ORM.SaveChanges();
            }
        }

        public Item InsertItem (Item itm)
        {
            if (RetrieveItem(itm).Count == 0)
            {
                ORM.Items.Add(itm);
                ORM.SaveChanges();

                return itm;
            }
            else
            {
                return new Item();
            }
        }

        public User InsertUser (User usr)
        {
            if (RetrieveUser(usr).Count == 0)
            {
                ORM.Users.Add(usr);
                ORM.SaveChanges();

                return usr;
            }
            else
            {
                return new User();
            }
        }

        public Item RetrieveItem (int pid)
        {
            Item item = ORM.Items.Find(pid);

            return item;
        }

        public List<Item> RetrieveItem (Item itm)
        {
            List<Item> items = new List<Item>();
            
            items = (from i in ORM.Items
                     where i.ProductName == itm.ProductName
                     select i).ToList();

            return items;
        }

        public List<Item> RetrieveItemsAll ()
        {
            List<Item> items = ORM.Items.ToList();

            return items;
        }

        public List<User> RetrieveUser (User usr)
        {
            List<User> users = new List<User>();
            users = (from u in ORM.Users
                     where u.EmailAddress == usr.EmailAddress
                     select u).ToList();

            return users;
        }

        public void UpdateItem (Item itm)
        {
            Item temp = RetrieveItem(itm.ProductId);
            temp.ProductName = itm.ProductName;
            temp.ProductDesc = itm.ProductDesc;
            temp.Qty = itm.Qty;
            temp.Price = itm.Price;

            ORM.Entry(temp).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();

            //return itm;
        }
    }
}