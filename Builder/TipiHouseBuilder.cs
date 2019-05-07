using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderPattern
{
    public class TipiHouseBuilder : IHouseBuilder
    {
        private House house;

        public TipiHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            house.SetBasement("Wooden Poles");
        }

        public void buildStructure()
        {
            house.SetStructure("Wood and Ice");
        }

        public void buildInterior()
        {
            house.SetInterior("Fire Wood");
        }

        public void bulidRoof()
        {
            house.SetRoof("Wood, caribou and seal skins");
        }

        public House getHouse()
        {
            return this.house;
        }

    }
}
