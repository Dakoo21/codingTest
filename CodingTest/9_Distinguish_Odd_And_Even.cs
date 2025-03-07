using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _9_Distinguish_Odd_And_Even
    {
        static void Main(string[] args)
        {
            // 자연수를 저장할 변수 선언
            int input;

            // 입력받은 문자를 숫자로 변경해서 변수 초기화
            input = Convert.ToInt32(Console.ReadLine());

            // 제약 조건
            if(1 <= input && input <= 1000)
            {
                // 저장된 값을 2로 나누어 짝수 인지 홀수 인지 판단
                if (input % 2 == 0)
                {
                    // 짝수 출력
                    Console.WriteLine($"{input} is even");
                }
                else
                {
                    // 홀수 출력
                    Console.WriteLine($"{input} is odd");
                }
            }
        }
    }
}
