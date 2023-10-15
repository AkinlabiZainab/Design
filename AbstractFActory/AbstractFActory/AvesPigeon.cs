using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFActory
{
    internal class AvesPigeon : IAvesInterface
    {
        public void AnimalDescription()
        {
            Console.WriteLine("they belong to the family of small birds");
        }
    }
}
