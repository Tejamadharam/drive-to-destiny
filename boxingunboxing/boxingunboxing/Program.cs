using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingunboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object o=i;
            int j = (int)o;
            Console.WriteLine("value of object o:" + o);
            Console.WriteLine("value of j:" + j);
            Console.ReadLine();

        }
    }
}
