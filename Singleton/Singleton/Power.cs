using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public Singleton()
        {
            Age = 10;
            FullName = "CLH";
        }
        public void AddDetails(string name, int agess)

        {

            Console.WriteLine($"my name is {FullName + name} and i am {Age + agess} years old ");
        }
    }
}
