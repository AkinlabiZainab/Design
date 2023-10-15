using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class HouseBuilder
    {
        protected House Building;
        public abstract void SetRoof();
        public abstract void SetPaintColour();
        public abstract void SetWindows();
        public abstract void SetDoor();

         public void CreateNewHouse()
        {
            Building = new House();
        }

        public House MakeHouse()
        {
            return Building;
        }


    }
}
