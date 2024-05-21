using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implict
{
    class Program
    {
        static void Main(string[] args)
        {
            int val=0;
            byte val1=15;
            val=val1;
            Console.WriteLine(val.GetType());
            Console.WriteLine(val1.GetType());
            Console.ReadLine();

        }
    }
}
