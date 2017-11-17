using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GC_Deliverable19_Lab20_CoffeeShop_Init.Models
{
    public class User
    {
        //for server-side security
        private const string SALT = "lv3%";

        //data and properties
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string phoneNum;
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        private string emailAddress;
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private string pw;
        public string Pw
        {
            private get { return pw.Remove(pw.Length - 4).Substring(4); }
            set { pw = SALT + value.Trim() + SALT; }
        }

        //constructors
        public User (): this ("", "", "", "", "newUser") //must have the constructor below made or this produces an error!
        {

        }

        public User (string firstName, string lastName, string phoneNum, string emailAddress, string pw)
        {
            FirstName   = firstName;
            LastName     = lastName;
            PhoneNum     = phoneNum;
            EmailAddress = emailAddress;
            Pw           = pw;
        }
    }
}