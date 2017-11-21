using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Net.Mail;

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
        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}", ErrorMessage = "Please enter a valid ten-digit phone number!")]
        [Required(ErrorMessage = "You must enter in a valid phone number to contunue.")]
        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        private string emailAddress;
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Invalid email address!")]
        [Required(ErrorMessage = "You must enter in a valid email to continue.")]
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private string pw;
        [RegularExpression("^(?=.*[0-9])(?=.*[a-zA-Z])[a-zA-Z0-9]{8,20}", ErrorMessage = "Password must be between 8 and 20 characters long!")]
        [Required(ErrorMessage = "You must enter in a valid password to continue.")]
        public string Pw
        {
            get { return pw.Remove(pw.Length - 4).Substring(4); }
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