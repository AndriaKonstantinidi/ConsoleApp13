using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Roof built");
        }
    }
}
