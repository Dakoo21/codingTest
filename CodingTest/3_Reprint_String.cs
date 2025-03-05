using System;

namespace CodingTest
{
    class Reprint_String_3
    {
        static void Main(string[] args)
        {
            //문자열고 반복 횟수를 동시에 입력 받기 때문에 배열로 저장하기 위한 배열 선언
            string[] strArray;

            // 입력 받은 문자열을 공백을 기준으로 배열에 저장
            strArray = Console.ReadLine().Split(' ');

            // 저장된 값을 각각 다른 변수에 할당
            string str = strArray[0];
            int retryNum = Convert.ToInt32(strArray[1]);

            // 제약 조건에 맞는 유효성 검사
            if (1 <= str.Length && str.Length <= 10 && 1 <= retryNum && retryNum <= 5)
            {
                // 반복 출력을 위해 for문을 사용
                for (int i = 0; i < retryNum; i++)
                {
                    Console.Write(str);
                }
            }
        }
    }
}
