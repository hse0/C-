using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sel; //진수를 받을 값 저장
            string num; 
            int num10 = 0;

            Console.Write("입력진수 결정(16/10/8/2) : ");
            sel = int.Parse(Console.ReadLine());

            Console.Write("값 입력 : ");
            num = Console.ReadLine();

            if (sel == 16)
                num10 = Convert.ToInt32(num, 16);
            if (sel == 10)
                num10 = Convert.ToInt32(num, 10);
            if (sel == 8)
                num10 = Convert.ToInt32(num, 8);
            if (sel == 2)
                num10 = Convert.ToInt32(num, 2);

            Console.WriteLine("16진수 ==> " + Convert.ToString(num10, 16)); //저장 하기
            Console.WriteLine("10진수 ==> " + Convert.ToString(num10, 10));  
            Console.WriteLine("8진수 ==> " + Convert.ToString(num10, 8));
            Console.WriteLine(" 2진수 ==> " + Convert.ToString(num10, 2));

        }
    }
}
