using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFActory
{
    internal class BigAnimals : IModeOfMovement
    {
        public IAvesInterface Movement()
        {
            return new AvesOstritch();
        }

        public IReptaliaInterface Movement2()
        {
            return new Reptaliacrocodile();
        }
    }
}
