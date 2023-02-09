using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02hw
{
    internal class Website
    {
        private string name;
        private string path;
        private string about;
        private string ip;
        public Website() { }
        public Website(string n, string p,string a,string i) 
        {
            name= n;
            path= p;
            about= a;
            ip= i;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Path
        {
            get { return path; } set { path = value; }
        }
        public string About
        {
            get { return about; } set { about= value; } 
        }
        public string Ip
        {
            get { return ip; } set { ip = value; }
        }
       
        public void Print ()
        {
            System.Console.WriteLine($"Name: {name}\nPath: {path}\nAbout: {about}\nIp: {ip}\n ");
        }
    }
}
