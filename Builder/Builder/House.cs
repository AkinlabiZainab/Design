using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class House
    {
        public string Roof{ get; set; }
        public string PaintColour{ get; set; }
        public string Windows {get; set; }
        public string Door{ get; set; }


        public void DisplayHouse()
        {
            Console.WriteLine("Colour : " + PaintColour);
            Console.WriteLine( "Roof: " + Roof );
            Console.WriteLine(" Windows: " + Windows);
            Console.WriteLine("Door: " + Door);

        }
    }
}
