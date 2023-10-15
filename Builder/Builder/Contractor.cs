using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public  class Contractor 
    {
        public House Contractors( HouseBuilder builds) 
        {
            builds.SetWindows();
            builds.SetDoor();
            builds.SetRoof();
            builds.SetPaintColour();
            builds.CreateNewHouse();

            return builds.MakeHouse();
        }
    }
}
