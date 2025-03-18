using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class _25_Combine_Number
    {
        static void Main(string[] args)
        {
            _25_Combine_Number p = new _25_Combine_Number();
            Console.WriteLine("배열의 길이를 입력하세요.");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("배열에 들어갈 숫자를 입력하세요.");
            int[] num_list = new int[arrayLength];

            for (int i = 0; i < num_list.Length; i++)
            {
                num_list[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(p.solution(num_list));
        }

        public int solution(int[] num_list)
        {
            // 홀수 결과를 담을 문자열 변수
            string odd = "";
            // 짝수 결과를 담을 문자열 변수
            string even = "";

            // 배열의 길이 만큼 순회
           for (int i = 0; i < num_list.Length; i ++)
            {
                // 홀수일 경우
                if (num_list[i] % 2 != 0)
                {
                    // 문자열로 변경하여 합침
                    odd += string.Concat(num_list[i].ToString());
                }
                // 짝수일 경우
                else
                {
                    even += string.Concat(num_list[i].ToString());
                }
            }

           // 정수형으로 변경 후 더하여 반환
            return Convert.ToInt32(odd) + Convert.ToInt32(even);
        }
    }
}
