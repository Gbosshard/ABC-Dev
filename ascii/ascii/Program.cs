using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            for (int i = 0; i < 256; i++)
			{
			    Console.WriteLine(i+" => "+(char)i);
			}
            Console.ReadKey();
        }
    }
}
