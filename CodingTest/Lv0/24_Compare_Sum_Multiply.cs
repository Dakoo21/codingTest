using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _24_Compare_Sum_Multiply
    {
        static void Main(string[] args)
        {
            _24_Compare_Sum_Multiply p = new _24_Compare_Sum_Multiply();

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

        /// <summary>
        /// 배열에 저장된 원소들의 합의 제곱과 모든 원소들의 곱을 비교하는 함수
        /// </summary>
        /// <param name="num_list"></param>
        /// <returns> 1 OR 0 </returns>
        public int solution(int[] num_list)
        {
            // 모든 원소들의 합을 저장할 변수 초기화
            int sum = 0;
            // 모든 원소들의 곱을 저장할 변수 초기화
            int multiply = 1;

            // num_list 의 길이 만큼 순회
            for (int i = 0; i < num_list.Length; i++)
            {
                sum += num_list[i];
                multiply *= num_list[i];
            }

            // 모든 원소들의 곱이 모든 원소들의 합의 제곱보다 작으면 1 / 반대의 경우 0을 리턴
            return sum * sum > multiply ? 0 : 1;
        }
    }
}
