using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n, count = 0;
            Console.WriteLine("Enter any positive number:");
            n = Int32.Parse(Console.ReadLine());
            i = n;
            do
            {
                ++count;
                i = i / 10;
            }
            while (i > 0);
            Console.WriteLine("number {0} contents {1} digits.", n, count);
            Console.ReadLine();

        }
    }
}
