using System;

namespace CodingTest
{
    class Print_a_b_2
    {
        static void Main(string[] args)
        {
            //한번에 입력받은 값을 따로 저장하기 위한 배열 선언
            string[] strArray;

            // 사용자로부터 입력받은 글자가 중간에 공백이 있음으로 split 함수를 사용해서 공백을 기준으로 잘라서 배열에 저장
            strArray = Console.ReadLine().Split(' ');

            // 제한 조건에 따라 유효성 검사를 하기위해 각 배열의 값을 int형으로 변경
            int a = Convert.ToInt32(strArray[0]);
            int b = Convert.ToInt32(strArray[1]);

            // 유효성 검사
            if (-100000 <= a && a <= 100000 && -100000 <= b && b <= 100000)
            {
                // 출력
                Console.WriteLine($"a = {a}\nb = {b}");
            }

        }
    }
}
