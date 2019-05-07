using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderPattern
{
    class MainClass
    {
        static void Main(string[] args)
        {
            IHouseBuilder iglooBuilder = new IglooHouseBuilder();
            Manager engineer = new Manager(iglooBuilder);

            engineer.constructHouse();

            House house = engineer.getHouse();

            Console.WriteLine("Builder constructed: " + house.ToString());
            Console.ReadKey();
        }
    }
}
