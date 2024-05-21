using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstructclass
{
    abstract class fourwheelar
    {
        public virtual string describe()
        {
            return "NOT MUCH IS  KNOWN ABOUT FOURWHEELAR";
        }
    }
    class car : fourwheelar
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            Console.WriteLine(c.describe());
            Console.ReadLine();
        }
    }
}
