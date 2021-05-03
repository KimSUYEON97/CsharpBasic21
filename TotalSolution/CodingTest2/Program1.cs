using System;

namespace CodingTest2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요 : ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"원의 넓이는 {Math.PI * input * input}");
        }
    }
}
