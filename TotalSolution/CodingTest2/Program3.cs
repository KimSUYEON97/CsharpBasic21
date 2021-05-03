using System;


namespace CodingTest2
{
    class Program5
    {
        static void Main5(string[] args)
        {
            for (int i = 7; i < 10; i++)
            {
                Console.WriteLine($"{i}단 계산 시작");
                
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {i*j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
