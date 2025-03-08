using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _12_Change_Array_to_String
    {
        static void Main(string[] args)
        {
            _12_Change_Array_to_String p = new _12_Change_Array_to_String();
            string[] a = ["a", "b", "c"];
            Console.WriteLine(p.solution(a));
        }

        public string solution(string[] arr)
        {
            // 결과 변수 선언 및 초기화
            string answer = "";

            // 배열의 길이 만큼 배열을 순회함
            for (int i = 0; i < arr.Length; i++)
            {
                // 배열의 값을 하나씩 결과 변수에 저장
                answer += arr[i];
            }
            // 해당 결과 값 리턴
            return answer;
        }
    }
}
