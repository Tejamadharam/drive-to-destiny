using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace fileio
{
    class text
    {
        static void Main(string[] args)
        {

            string path = @"D:\\MyText.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s =( " ");
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }
    
        }
    }
}
