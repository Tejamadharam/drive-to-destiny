using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int [3,3];
            int[,] arr2 = new int[3,3];
            int i, j;
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.WriteLine("Enter any value :\t");
                    arr1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    arr2[i,j]=arr1[i,j];
                }
            }
            Console.WriteLine("\t Elements of second array are:");
            for(i=0;i<3;i++)
            {
                Console.WriteLine();
                for(j=0;j<3;j++)
                {
                    Console.WriteLine("\t {0}", arr2[i,j]);
                }
            }
            Console.ReadLine();
       }
    }
}
