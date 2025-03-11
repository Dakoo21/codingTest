using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _17_Common_Multiple
    {
        static void Main(string[] args)
        {
            _17_Common_Multiple p = new _17_Common_Multiple();
            int number = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(number, n, m));

        }

        public int solution (int number, int n, int m)
        {
            // 배수가 맞는지 확인할 변수 초기화
            bool nMultipleResult = false;
            bool mMultipleResult = false;

            // 제약 조건
            if((1 <= number && number <= 100) && 
               (2 <= n && n < 10) && 
               (2 <= m && m < 10))
            {
                // 해당 정수의 배수가 맞는지 확인
                nMultipleResult = (number % n == 0);
                mMultipleResult = (number % m == 0);
            }
            // 삼항 연산자를 사용해서 결과값 리턴
            return (nMultipleResult && mMultipleResult) ? 1 : 0;
        }
    }
}
