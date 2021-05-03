using System;


namespace CodingTest2
{
    class Program3
    {
        static void Main4(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if (i==5)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
