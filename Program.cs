using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("IQOO Z6 pro");
            smartphone.Connect();
            smartphone.Charge(120);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop("Hp Pavilion");
            laptop.Connect();
            laptop.Charge(90);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}
