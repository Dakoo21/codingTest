using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _18_Return_Value_Depending_Odd_Even
    {
        static void Main(string[] args)
        {
            _18_Return_Value_Depending_Odd_Even p = new _18_Return_Value_Depending_Odd_Even();
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(n));

        }

        public int solution(int n)
        {
            // 결과를 담을 변수 초기화
            int answer = 0;

            // 제약 조건
            if (1 <= n && n <= 100)
            
                // 짝수 조건
                if (n % 2 == 0)
                {
                    // 양의 정수의 짝수이기 때문에 2 부터 시작
                    // 2씩 증가
                    for (int i = 2; i <= n; i += 2)
                    {
                        // 짝수는 제곱의 합
                        answer += i * i;
                    }
                }
                // 홀수 조건
                else
                { 
                    // 양의 정수의 홀수이기 때문에 1부터 시작
                    // 2씩 증가
                    for (int i = 1; i <= n; i += 2)
                    {
                        // 홀수의 합
                        answer += i;
                    }
                }
            // 리턴
            return answer;
        }
    }
}
