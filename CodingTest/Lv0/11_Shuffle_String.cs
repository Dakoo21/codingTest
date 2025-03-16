using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _11_Shuffle_String
    {
        static void Main(string[] args)
        {
            _11_Shuffle_String p = new _11_Shuffle_String();
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(p.solution(str1, str2));
        }

        public string solution(string str1, string str2)
        {
            // 입력 받은 첫번째 문자열 배열로 전환
            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray(); ;

            // 최종 결과를 받을 변수
            string answer = "";

            // 제약 조건
            if (a.Length == b.Length)
            {
                // 배열 순환
                for (int i = 0; i < a.Length; i++)
                {
                    // char 형태이기 때문에 문자로 전환하여 변수에 순차적으로 초기화
                    answer += a[i].ToString() + b[i].ToString();
                }
            }
            // 결과 리턴
            return answer;
        }
    }
}
