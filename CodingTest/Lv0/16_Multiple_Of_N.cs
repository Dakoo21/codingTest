using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _16_Multiple_Of_N
    {
        static void Main(string[] args)
        {
            _16_Multiple_Of_N p = new _16_Multiple_Of_N();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(a, b));

        }

        public int solution (int num, int n)
        {
            // 제약 조건
            bool numResult = 2 <= num && num <= 100;
            bool nResult = 2 <= n && n <= 9;

            if (numResult && nResult)
            {
                // 삼항연산자를 통해 비교 리턴
                return num % n == 0 ? 1 : 0;
            }
            else
            {
                // 제약 조건에 맞지 않을 경우 0 리턴
                return 0;
            }


        }
    }
}
