using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            float weight;
            Console.Write("Enter any number");
            number = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight");
            weight = float.Parse(Console.ReadLine());
            Console.WriteLine("you have entered:" + number);
            Console.WriteLine("your weight is:" + weight);
            Console.ReadLine();
        }
    }
}
