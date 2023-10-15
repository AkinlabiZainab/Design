using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Builder
{
    public class KolaHouse : HouseBuilder
    {
        public override void SetDoor()
        {
            Building.Door = "black";
        }

        public override void SetPaintColour()
        {
            Building.PaintColour = "White";
        }

        public override void SetRoof()
        {
            Building.Roof = "Gerald roofing";
        }

        public override void SetWindows()
        {
            Building.Windows = "Sliding Windows";
        }
    }
}
