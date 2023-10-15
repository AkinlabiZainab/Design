using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFActory
{
    internal class SmallAnimala : IModeOfMovement
    {
        public IAvesInterface Movement()
        {
            return new AvesPigeon();
        }

        public IReptaliaInterface Movement2()
        {
            return new ReptaliaLizard();
        }
    }
}
