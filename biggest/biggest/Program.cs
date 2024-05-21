using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter a value");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter b value");
            b = Int32.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine("a={0}   is the biggest number", a);
            }
            else
            {
                Console.WriteLine("b={0}   is the biggest number", b);
            }
            Console.ReadLine();
        }
    }
}