using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutFormatOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);
            Console.WriteLine("Commas and Decimals : {0:n4}", 2300);

            Console.ReadLine();
        }
    }
}
