using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticconstructor
{
    class sample
    {
        public string p1, p2;
        static sample()
        {
            Console.WriteLine("static constructor");
        }
        public sample()
        {
            p1 = "sample";
            p2 = "instance constructor";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample();
            {
                Console.WriteLine(obj.p1 + "" + obj.p2);
                sample obj1 = new sample();
                Console.WriteLine(obj1.p1 + "" + obj.p2);
                Console.ReadLine();
            }
        }
    }
}
