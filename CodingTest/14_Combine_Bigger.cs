using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _14_Combine_Bigger
    {
        static void Main(string[] args)
        {
            _14_Combine_Bigger p = new _14_Combine_Bigger();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(a, b));
        }

        public int solution(int a, int b)
        {
            // 결과를 저장할 변수 선언 및 초기화
            int answer = 0;

            //제약 조건
            if (1 <= a && a < 10000)
            {
                if (1 <= b && b < 10000)
                {
                    // 두 정수를 문자열로 변경후 합친 후 비교를 위해 다시 정수로 변환
                    int result1 = Convert.ToInt32(a.ToString() + b.ToString());
                    int result2 = Convert.ToInt32(b.ToString() + a.ToString());

                    // 삼항 연산자를 이용하여 비교 후 결과 값 저장
                    answer = (result1 >= result2) ? result1 : result2;
                }
            }
            // 리턴
            return answer;
        }
    }
}
