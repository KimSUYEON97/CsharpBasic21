using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    //Access Modifier : public protected private
    class Animal//private class Animal이 될 경우 상속불가능 , public은 상관 없음
    {
        public int Age { get; set; }
        //public string Color { get; set; }

        protected Animal() { this.Age = 0; }//protected 상속 허용 단 전체 클래스에서는 안쓰는게 좋다 . action,속성,생성자에 사용할것

        public void Eat() { Console.WriteLine("eat"); }

        public void Sleep() { Console.WriteLine("zzzzz"); }


    }
}
