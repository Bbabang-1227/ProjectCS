using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_1
{
    class Tiger
    {

    }

    class Lion
    {
        Tiger t;
        Lion l;
        void m1()
        {
            
        }
    }
    class Program 
    {
        
        //필드
        public int a;
        public int b;
        static int num;
        //생성자
        public Program()
        {
            a = 10;
            b = 20;
        }
        /*
        ~Program() 소멸자를 잘 사용하지않는다 cs에서는 메모리해제개념이없다.
        {

        }*/
        //메소드
        public int Method()
        {
            a = 20;
            b = 30;
            
            return a + b;
        }

        static void m1()
        {
            
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.a);
            Console.WriteLine(p.b);
            Console.WriteLine(p.Method());
            Console.WriteLine(p.a);
            Console.WriteLine(p.b);
            m1();
        }
    }
}
