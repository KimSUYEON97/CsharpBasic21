using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Dog : Animal//부모 = Animal 상속받음
    {
        //특성 -> 속성
        
        public string Color { get; set; }

        //기본생성자
        public Dog()
        {
            this.Age = 0;//Age만 사용해도 상관 없음
            this.Color = "white";
        }

        //action -> method
        
        public void Bark()
        {
            //Console.Error = TextWriter(); 성립안됨 Error는 읽기 전용으로 값 할당 될 수 없음
            Console.WriteLine("Wang! Wang!");//메소드는 값 할당 가능
        }
    }
}
