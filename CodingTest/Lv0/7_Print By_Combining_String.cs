using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _7_Print_By_Combining_String
    {
        static void Main(string[] args)
        {
            // 두개의 문자열을 한번에 입력 받아 배열에 저장하기 위한 배열 선언
            string[] str;

            // 한번 정리
            Console.Clear();

            //입력 받은 두개의 문자열은 공백으로 구분 되기 때문에 split() 메소드를 사용해서 각 배열에 저장
            str = Console.ReadLine().Split(' ');

            // 제약 조건
            if( 1 <= str[0].Length && str[0].Length <= 10 && 1 <= str[1].Length && str[1].Length <= 10)
            {
                // 출력
                Console.WriteLine($"{str[0]}{str[1]}");
            }
        }
    }
}
