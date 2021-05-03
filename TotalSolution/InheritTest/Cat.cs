using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Cat : Animal
    {
        //특성 -> 속성
        //get, set값을 가져오고 지정

        //기본생성자
        public Cat()
        {
            this.Age = 0;//Age만 사용해도 상관 없음
        }

        //action -> method

        public void Bark()
        {
            //Console.Error = TextWriter(); 성립안됨 Error는 읽기 전용으로 값 할당 될 수 없음
            Console.WriteLine("Nyang! Nyang!");//메소드는 값 할당 가능
        }
    }
}
