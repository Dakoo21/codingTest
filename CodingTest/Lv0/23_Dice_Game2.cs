using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _23_Dice_Game2
    {
        static void Main(string[] args)
        {
            _23_Dice_Game2 p = new _23_Dice_Game2();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(a, b, c));
        }

        /// <summary>
        /// 세 정수 a, b, c가 매개변수로 주어질 때, 얻는 점수를 return 하는 함수
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>
        ///     1. 세 숫자가 모두 다른 경우
        ///     2. 세 숫자 중 어느 두 숫자가 같고 나머지 다른 숫자는 다른 경우
        ///     3. 세 숫자가 모두 같은 경우
        /// </returns>
        public int solution(int a, int b, int c)
        {
            // 세 숫자가 모두 다른 경우
            int different = a + b + c;

            // 어느 두 숫자가 같고 나머지 다른 숫자가 다른 경우
            int equalTwo = a * a + b * b + c * c;

            if (a == b && a == c)
            {
                // 세 숫자가 모두 같은 경우
                int equalThree = a * a * a + b * b * b + c * c * c;
                return different * equalTwo * equalThree;
            }

            // 삼항연산자를 사용
            return (a != b && a != c && b != c) ? different : different * equalTwo;
        }
    }
}
