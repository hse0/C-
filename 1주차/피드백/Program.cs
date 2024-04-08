using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int c50000, c10000, c5000, c1000;

            Console.Write("지폐로 교환할 돈은 얼마 ? ");
            money = int.Parse(Console.ReadLine());

            c50000 = money / 50000; 
            money %= 50000;

            c10000 = money / 10000;
            money %= 10000;

            c5000 = money / 5000;
            money %= 5000;

            c1000 = money / 1000;
            money %= 1000;

            Console.WriteLine("\n오만원짜리 ==> " + c50000 + "장");
            Console.WriteLine("만원짜리 ==> " + c10000 + "장");
            Console.WriteLine("오천원짜리 ==> " + c5000 + "장");
            Console.WriteLine("천원짜리 ==> " + c1000 + "장");
            Console.WriteLine("지폐로 바꾸지 못한 돈 ==> " + money + "원");

        }
    }
}
