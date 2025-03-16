using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _15_Compare_Two_Numbers
    {
        static void Main(string[] args)
        {
            _15_Compare_Two_Numbers p = new _15_Compare_Two_Numbers();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(a, b));
        }

        public int solution(int a, int b)
        {
            // 결과를 담을 변수 초기화
            int answer = 0;

            // 전달받은 숫자를 문자열로 변경 및 합쳐 숫자 표현 후 다시 정수로 변환
            int abString = Convert.ToInt32(a.ToString() + b.ToString());

            // 제약 조건
            if (1 <= a && a < 10000)
            {
                if (1 <= b && b < 1000)
                {
                    // 삼항 연산자를 통해 비교 및 결과 값 answer에 저장
                    answer = abString >= 2 * a * b ? abString : 2 * a * b;
                }
            }
            // 리턴
            return answer;
        }
    }
}
