using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Shop
    {
        private string name;
        private string adress;
        private string about;
        private string number;
        private string email;
        public Shop() { }
        public Shop(string n, string ad, string a, string i,string em)
        {
            name = n;
            adress = ad;
            about = a;
            number= i;
            email = em;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string About
        {
            get { return about; }
            set { about = value; }
        }    
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void Print()
        {
            System.Console.WriteLine($"Name: {name}\nAdress: {adress}\nAbout: {about}\nNumber: {number}\nEmail: {email}\n ");
        }
    }
}
