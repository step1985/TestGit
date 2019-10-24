using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCompositeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contex contex = new Contex();
            Country country = new Country("English");
            country.Interpret(contex);
            country.Operation();
            Console.ReadLine();
        }
    }
}
