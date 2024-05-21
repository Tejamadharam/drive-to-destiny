using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramarray
{
    class paramarray
    {
        public int addelements(params int []arr)
    { 
        int sum=0;
        foreach(int i in arr)
    {
        sum+=i;
    }
        return sum;
}
}
class testprogram
{
        static void Main(string[] args)
        {
            paramarray app=new paramarray();
            int sum=app.addelements(512,720,567,889);
            Console.WriteLine("The sum is :{0}",sum);
            Console.ReadLine();

        }
    }
}
