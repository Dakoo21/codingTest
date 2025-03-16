using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _13_String_Multiplication
    {
        static void Main(string[] args)
        {
            _13_String_Multiplication p = new _13_String_Multiplication();
            string str = Console.ReadLine();
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(p.solution(str, num));

        }

        public string solution(string str, int num)
        {
            //결과를 담을 변수 선언 및 초기화 
            string answer = string.Empty;

            // 제약 조건
            if (1 <= str.Length && str.Length <= 100)
            {
                if (1 <= num && num <= 100)
                {
                    // 입력받은 num 만큼 순회
                    for (int i = 0; i < num; i++)
                    {
                        // 순회 할때다마 str 추가
                        answer += str;
                    }
                }
            }
            //리턴
            return answer;
        }
    }
}
