using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_method
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList booklist = new System.Collections.ArrayList();
            booklist.Add(new csharp());
            booklist.Add(new oraclebook());
            foreach (softwarebooks book in booklist)
            {
                Console.WriteLine(book.describe());
                Console.ReadLine();
            }
        }
        abstract class softwarebooks
        {
            public abstract string describe();
        }
        class csharp : softwarebooks
        {
            public override string describe()
            {
                return "i am a csharap book";
            }
        }
        class oraclebook : softwarebooks
        {
            public override string describe()
            {
                return "i am  an oracle book";
            }
        }
    }
}
