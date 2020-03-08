using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            calc.addItem(11.1);
            calc.addItem(7);

            System.Console.WriteLine(calc.somar());

            System.Console.ReadKey();
        }
    }
}
