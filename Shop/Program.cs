using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop a = new Shop("TuRk", "Schkodagasse 23, 1080, Wien", "U can buy here a beautiful lamp", "+436769889645", "TuRK@gmail.com");
            Console.WriteLine(a);
            Console.WriteLine();
            a.Name = "TuRk";
            a.Adress = "Schkodagasse 23, 1080, Wien";
            a.About = "U can buy here a beautiful lamp";         
            a.Number= "+436769889645";
            a.Email = "TuRK@gmail.com";
            Console.WriteLine("----------------------");
            a.Print();
        }
    }
}
