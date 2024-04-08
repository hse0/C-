using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:D}", 123);
            Console.WriteLine("{0,5:D}", 123);
            Console.WriteLine("{0,5:D5}", 123);

            Console.WriteLine("{0:F}", 123.456);
            Console.WriteLine("{0,8:F1}", 123.456);
            Console.WriteLine("{0,9:F6}", 123.456);

            Console.WriteLine("{0:S}", "CSharp");
            Console.WriteLine("{0,8:S}", "CSharp");
        }
    }
}
