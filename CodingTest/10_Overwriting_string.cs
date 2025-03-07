using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _10_Overwriting_string
    {
        static void Main(string[] args)
        {
            _10_Overwriting_string p = new _10_Overwriting_string();
            
            // 잘못된 문자열
            string a = Console.ReadLine();
            // 잘못된 문자열에서 들어갈 문자열
            string b = Console.ReadLine();
            // 인덱스
            int c = Convert.ToInt32(Console.ReadLine());

            // 출력
            Console.WriteLine(p.solution(a, b, c));
        }

        // 문자열 교체 메소드
        string solution (string a, string b, int c)
        {
            // 대체되어 들어갈 문자열 길이
            int length = b.Length;

            // 원래 문자열에서 사용할 부분 잘라서 저장
            string result1 = a.Substring(0, c);
            string result2 = a.Substring(c + length);

            // 리턴
            return result1 + b + result2;
        }
    }
}
