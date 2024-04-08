using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project04_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int c500, c100, c50, c10; 

            Console.Write("교환할 돈은 얼마 ? ");
            money = int.Parse(Console.ReadLine());

            c500 = money / 500;
            money %= 500;

            c100 = money / 100;
            money %= 100;

            c50 = money / 50;
            money %= 50;

            c10 = money / 10;
            money %= 10;

            Console.WriteLine("\n오백원짜리 ==> " + c500 + "개");
            Console.WriteLine("백원짜리 ==> " + c100 + "개");
            Console.WriteLine("오십원짜리 ==> " + c50 + "개");
            Console.WriteLine("십원짜리 ==> " + c10 + "개");
            Console.WriteLine("바꾸지 못한 잔돈 ==> " + money + "원");
        }
    }
}
