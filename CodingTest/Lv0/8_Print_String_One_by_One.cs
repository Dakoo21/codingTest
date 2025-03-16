using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _8_Print_String_One_by_One
    {
        static void Main(string[] args)
        {
            // 입력 받은 값을 저정하기 위한 변수 선언
            string s;

            // 문자열을 입력 받아 변수 초기화
            s = Console.ReadLine();

            // 제약 조건
            if(1 <= s.Length && s.Length <= 10)
            {
                // 해당 문자열을 한번 순회
                foreach (char a in s)
                {
                    // 출력
                    Console.WriteLine(a);
                }
            }
        }
    }
}
