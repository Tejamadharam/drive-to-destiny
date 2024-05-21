using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbermanipulator
{
    class Numbermanipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            Numbermanipulator n = new Numbermanipulator();
            ret=n.FindMax(a,b);
            Console.WriteLine("max value is:{0}",ret);
           Console.ReadLine();
        }
    }
}
