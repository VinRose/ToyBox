using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string meat = "Beef";
            Console.WriteLine(Container.ParseStuff(meat));
            string fish = "Tuna";
            Console.WriteLine(Container.ParseStuff(fish));
            string fruit = "Apple";
            Console.WriteLine(Container.ParseStuff(fruit));
        }
    }
}
