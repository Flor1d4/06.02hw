using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitschrift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zeitschrift a = new Zeitschrift("Vogue", "1892yr", "Ein Modemagazin, das seit 1892 von Condé Nast Publications herausgegeben wird.", "+38006667799", "VogueOf@gmail.com");
            Console.WriteLine(a);
            Console.WriteLine();
            a.Name = "Vogue";
            a.Year = "1892yr";
            a.About = "Ein Modemagazin, das seit 1892 von Condé Nast Publications herausgegeben wird.";
            a.Number = "+38006667799";
            a.Email = "VogueOf@gmail.com";
            Console.WriteLine("----------------------");
            a.Print();
        }
    }
}
