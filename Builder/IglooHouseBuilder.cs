using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderPattern
{
    public class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }

        public void buildBasement()
        {
            house.SetBasement("Ice Bars");
        }

        public void buildStructure()
        {
            house.SetStructure("Ice Blocks");
        }

        public void buildInterior()
        {
            house.SetInterior("Ice Carvings");
        }

        public void bulidRoof()
        {
            house.SetRoof("Ice Dome");
        }

        public House getHouse()
        {
            return this.house;
        }
    }
}
