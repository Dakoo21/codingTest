using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _6_Print_Addition_Formula
    {
        static void Main(string[] args)
        {
            //입력 받은 문자열을 잘라서 담을 배열 선언
            string[] s;
            // 배열 s에 있는 값을 변환하여 담을 변수 선언
            int a, b;

            // 입력 받은 문자를 잘라서 보관
            s = Console.ReadLine().Split(' ');

            // 정수로 변환하여 초기화
            a = Convert.ToInt32(s[0]);
            b = Convert.ToInt32(s[1]);

            // 제약 조건
            if (1 <= a && a <= 100 & 1 <= b && b <= 100)
            {
                // 출력
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
        }
    }
}
