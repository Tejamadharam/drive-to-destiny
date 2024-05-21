using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class recursion1
    {
        public int factorial(int num)
        {
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1) * num;
                return result;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            recursion1 n = new recursion1();
            Console.WriteLine("factorial  of 6:{0}", n.factorial(5));
            Console.WriteLine("factorial  of 6:{0}", n.factorial(6));
            Console.WriteLine("factorial  of 6:{0}", n.factorial(7));
            Console.ReadLine();
        }
    }
}
