using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitschrift
{
    internal class Zeitschrift
    {
        private string name;
        private string year;
        private string about;
        private string number;
        private string email;
        public Zeitschrift() { }
        public Zeitschrift(string n, string y, string a, string nu,string e)
        {
            name = n;
            year = y;
            about = a;
            number = nu;
            email = e;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
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
            System.Console.WriteLine($"\nName: {name}\nYear: {year}\nAbout: {about}\nNumber: {number}\nEmail: {email}\n ");
        }
    }
}
