using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFActory
{
    internal class Reptaliacrocodile : IReptaliaInterface
    {
        public void AnimalDescription()
        {
            Console.WriteLine("they belong to the family of big reptiles");
        }
    }
}
