using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    class Program
    {
        delegate int numberchager(int n);
        class testdelegate
        {
            static int num = 10;
            public static int addnum(int p)
            {
                num += p;
                return num;
            }
            public static int multnum(int q)
            {
                num *= q;
                return num;
            }
            public static int getnum()
            {
                return num;
            }
            static void Main(string[] args)
            {
                numberchager nc1 = new numberchager(addnum);
                numberchager nc2 = new numberchager(multnum);
                nc1(30);
                Console.WriteLine("value of num:{0}", getnum());
                nc2(20);
                Console.WriteLine("value of num:{0}", getnum());
                Console.ReadKey();
            }
        }
    }
}

