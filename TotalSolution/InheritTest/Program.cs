using System;
using System.Collections.Generic;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(),new Dog()
            };
            List<Cat> cats = new List<Cat>()
            {
                new Cat(),new Cat()
            };

            foreach (Dog item in dogs)
            {
                item.Age = 7;//set없으면 오류 발생
                item.Color = "black";//set없으면 오류 발생
                item.Eat();
                item.Sleep();
                item.Bark();
                Console.WriteLine(item.Age + " " + item.Color);//get없으면 오류 발생
            }

            foreach (Cat item in cats)
            {
                item.Age = 5;
                item.Eat();
                item.Sleep();
                item.Bark();
                Console.WriteLine(item.Age);
            }
        }
    }
}
