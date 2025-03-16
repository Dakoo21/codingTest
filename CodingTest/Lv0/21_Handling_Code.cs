using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.Lv0
{
    class _21_Handling_Code
    {
        static void Main(string[] args)
        {
            _21_Handling_Code p = new _21_Handling_Code();
            string code = Console.ReadLine();

            Console.WriteLine(p.solution(code));
        }

        public string solution(string code)
        {
            // 결과 값을 담을 변수 선언 및 초기화
            string answer = "";
            // 초기 mode 초기화
            int mode = 0;

            // 파라미터 값을 순회 함
            for (int i = 0; i < code.Length; i++)
            {
                // 0 or 1이 나올 경우 모드를 변경해야됨
                if (code[i] == '1')
                {
                    // mode 토글값 변경 코드 (important)
                    mode = 1 - mode;
                }
                else
                {
                    // 실제 리턴 값의 로직이 작동하는 부분
                    if (mode == 0 && i % 2 == 0)
                    {
                        answer += code[i];
                    }
                    else if (mode == 1 && i % 2 == 1)
                    {
                        answer += code[i];
                    }
                }
            }
            // 빈 문자열이 반환될 경우를 대비한 삼항연사자
            return (answer == "") ? "EMPTY" : answer;
        }
    }
}
