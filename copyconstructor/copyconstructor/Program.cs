using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copyconstructor
{
    class sample
    {
        public string p1, p2;
        public sample(string x, string y)
        {
            p1 = x;
            p2 = y;
        }
        public sample(sample obj)
        {
            p1 = obj.p1;
            p2 = obj.p2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sample obj = new sample("WELCOME","ASPDOTNET");
            sample obj1 = new sample(obj);
            Console.WriteLine(obj1.p1+"to"+obj.p2);
            Console.ReadLine();
        }
    }
}
