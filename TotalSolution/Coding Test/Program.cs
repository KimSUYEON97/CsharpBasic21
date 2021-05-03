using System;

namespace Coding_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("input value: ");
                float input = float.Parse(Console.ReadLine());//int.parse와 같은 기능 = convert.toint32
                int ival = 10;
                Console.WriteLine($"input value is {input}.");//$ = string format , 숫자도 Tostring format사용시 동일 방법 사용 : C# 4.0
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생: {ex.Message}");
            }

            /*Console.WriteLine("input value: ");
            int input =Convert.ToInt32( Console.ReadLine());//int.parse와 같은 기능
            int ival = 10;
            Console.WriteLine($"input value is {input}.");//$ = string format , 숫자도 Tostring format사용시 동일 방법 사용 : C# 4.0
            */
            

            /*//for + 탭키 2번 클릭시 자동완성기능
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }//주석단축키 ctrl_shift_/ 설정 //해제
           */

        }
    }
}
