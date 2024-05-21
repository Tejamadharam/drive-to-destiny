using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explict
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            float a;
            double b = 13.5;
            a = (float)b;
            c = (int)a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
