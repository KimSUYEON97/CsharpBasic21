using System;


namespace CodingTest2
{
    class Program2
    {
        static void Main21(string[] args)
        {
            Console.Write("이름을 입력하세요 : ");
            String name = Console.ReadLine();
            Console.Write("이름을 입력하세요 : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("이름을 입력하세요 : ");
            String address = Console.ReadLine();
            Console.WriteLine($"반갑습니다. 저는 {address}에 살고 있는 {age}살 {name}입니다.");
        }
    }
}
