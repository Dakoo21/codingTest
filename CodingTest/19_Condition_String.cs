using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _19_Condition_String
    {
        static void Main(string[] args)
        {
            _19_Condition_String p = new _19_Condition_String();
            string ineq = Console.ReadLine();
            string eq = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(ineq, eq, n, m));
        }

        public int solution(string ineq, string eq, int n, int m)
        {

            if (1 <= n && n <= 100)
            {
                if (1 <= m && m <= 100)
                {
                    // 1. ineq가 > 인지 확인
                    // 1-1. ">" 가 맞는 경우
                    //      삼항 연산자 (eq == "=" ? (n >= m) : (n > m)) 연산 시작 후 true OR false 반환

                    // 1-2. ">" 가 아닌 경우
                    //      삼항 연산자 (eq == "=" ? (n <= m) : (n < m)) 연산 시작 후 true OR false 반환
                    return (ineq == ">" ? (eq == "=" ? (n >= m) : (n > m))
                            : (eq == "=" ? (n <= m) : (n < m))) ? 1 : 0;
                }
            }
            return 0;
        }
    }
}
