using System;

namespace CodingTest
{
    class _4_Upper_letter_to_Lower
    {
        static void Main(string[] args)
        {
            // 입력을 받을 변수 선언
            string str;
            // 결과를 저장할 변수 선언
            // 선언만 하고 초기화 하지 않으면 에러 발생함 (주의)
            string changeResult = string.Empty;

            // 입력 받음
            str = Console.ReadLine();

            if (1 <= str.Length && str.Length <= 20)
            {
                // 문자열을 한번 순회함
                foreach (char c in str)
                {
                    //삼항연산자를 사용해서 문자변경
                    changeResult += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
                }
            }
            
            //출력
            Console.WriteLine(changeResult);

        }
    }
}
