using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling
{
    class Program
    {
        class divisionnumbers
        {
            int result;
            divisionnumbers()
            {
                result = 0;                      
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught:{0}", e);

                }
                finally
                {
                    Console.WriteLine("Result:{0}", result);
                }
            }
            static void Main(string[] args)
            {
                divisionnumbers d = new divisionnumbers();
                d.division(25, 0);
                Console.ReadLine();
            }
        }
    }
}
