using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam01
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double a, b; // 더블형 a,b 
            double result; // 더블형 결과값을 만든다.

            string str; // 숫자 데이터 형식들 문자열로 변경 

            Console.Write("첫번째 계산할 값을 입력하세요 ==> "); 
            str = Console.ReadLine();
            a = Convert.ToDouble(str); // 숫자 데이터 형식을 문자열로 변경

            Console.Write("두번째 계산할 값을 입력하세요 ==> ");
            str = Console.ReadLine();
            b = Convert.ToDouble(str); 

            result = a + b;
            Console.WriteLine(a + " + " + b + " = " + result);
            result = a - b;
            Console.WriteLine(a + " - " + b + " = " + result);
            result = a * b;
            Console.WriteLine(a + " * " + b + " = " + result);
            result = a / b;
            Console.WriteLine(a + " / " + b + " = " + result);
            result = a % b;
            Console.WriteLine(a + " % " + b + " = " + result);

            result = Math.Pow(a, b); // 거듭제곱
            Console.WriteLine(a + " ^ " + b + " = " + result);
        }
    }
}
