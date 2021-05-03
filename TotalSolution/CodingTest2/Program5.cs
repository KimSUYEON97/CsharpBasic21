using System;

namespace CodingTest2
{
    class Program4
    {
        static void Main(string[] args)
        {
            int count = 1;
            int temp,last;
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!\n");

            for (int i = 0; i < 101; i++,count++)
            {
                temp = i;
                do
                {
                    last = temp % 10;
                    temp = temp / 10;

                    if (i == 0)
                    {
                        Console.Write("짝!\t");
                        break;
                    }
                    else if (temp == 3 || temp == 6 || temp == 9 || last == 3 || last == 6 || last == 9)
                    {
                        Console.Write("짝!\t");
                        break;
                    }
                    else
                    {
                        Console.Write($"{i}\t");
                        break;
                    }
                } while (temp > 0);

                if (count % 15 == 0)
                {
                    Console.WriteLine();
                }

                /*last = i % 10;
                temp = i / 10;
                
                if (i == 0)
                {
                    Console.Write("짝!\t");
                }
                else if (temp == 3 || temp == 6 || temp == 9 || last == 3 || last == 6 || last == 9)
                {
                    Console.Write("짝!\t");
                }
                else
                {
                    Console.Write($"{i}\t");
                }
                
                if (count % 15 == 0)
                {
                    Console.WriteLine();
                }*/
            }
        }
    }
}
