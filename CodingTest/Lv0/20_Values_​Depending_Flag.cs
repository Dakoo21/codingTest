using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _20_Values_​Depending_Flag
    {
        static void Main(string[] args)
        {
            _20_Values_Depending_Flag p = new _20_Values_Depending_Flag();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            bool flag = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(p.solution(a, b, flag));
        }

        public int solution(int a, int b, bool flag)
        {
            // 제약 조건
            if (-1000 <= a && a <= 1000)
            {
                if (-1000 <= b && b <= 1000)
                {
                    // 삼항 연산자 사용
                    return flag ? a + b : a - b;
                }
            }

            return 0;
        }
    }
}
