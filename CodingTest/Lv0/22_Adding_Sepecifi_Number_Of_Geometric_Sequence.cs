using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _22_Adding_Sepecifi_Number_Of_Geometric_Sequence
    {
        static void Main(string[] args)
        {
            _22_Adding_Sepecifi_Number_Of_Geometric_Sequence p = new _22_Adding_Sepecifi_Number_Of_Geometric_Sequence();

            // 첫째항
            int a = Convert.ToInt32(Console.ReadLine());
            // 공차
            int d = Convert.ToInt32(Console.ReadLine());

            // 배열 길이
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            // boolean 배열 선언
            bool[] included = new bool[arrayLength];
            
            // 배열 길이만큼 순회 및 배열에 값 담아줌
            for (int i = 0; i < arrayLength; i++)
            {
                string boolInput = Console.ReadLine();
                included[i] = bool.Parse(boolInput);
            }

            // 결과 값 출력
            Console.WriteLine(p.solution(a, d, included));
        }

        /// <summary>
        /// 등차수열의 특정 항만 더하는 메소드
        /// </summary>
        /// <param name="a"> 첫째 항 </param>
        /// <param name="d"> 공차 </param>
        /// <param name="included"> boolena 배열 </param>
        /// <returns></returns>
        public int solution(int a, int d, bool[] included)
        {
            // 결과 값을 담을 변수 초기화
            int answer = 0;

            // boolean 배열 길이 만큼 순회
            for (int i = 0; i < included.Length; i++)
            {

                // boolen 배열에서 true 값을 때만 동작
                if (included[i] == true)
                {
                    // 최종 값을 answer에 합침
                    answer += a + (i * d);
                }
            }
            // 결과 값 리턴
            return answer;
        }
    }
}
