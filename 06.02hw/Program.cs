using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website a= new Website("Wishmerry", "wishmerry.com", "U can buy here a beautiful lamp", "127.0.0.1");
            Console.WriteLine(a);
            Console.WriteLine();
            a.Name = "Wishmerry";
            a.Path = "wishmerry.com";
            a.About = "U can buy here a beautiful lamp";
            a.Ip = "127.0.0.1";
            Console.WriteLine("----------------------");
            a.Print();
        }
    }
}
