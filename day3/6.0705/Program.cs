using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Console;
using System.Collections;


namespace _6._0705
{
    //Singletone Pattern
    class Singletone
    {
        private static Singletone instance = null;
        private Singletone()
        {
            WriteLine("객체 생성");
        }
        public static Singletone getinstance()
        {
            if (instance == null)
            {
                instance = new Singletone();
            }
            return instance;
        }
        int num;
        public int Num { get; set; }
    }

    //다형성
    class Zoo
    {
        //클래스를 작성한 사람과 사용하는 사람이 다르기 때문에 결과를 예측할수 없다
        public void sound(Animal animal)
        {
            animal.Cry();
        }
    }
    class Animal
    {
        public virtual void Cry()
        {
            WriteLine("나는 울지 못한다");
        }
    }
    class Dog : Animal
    {
        public override void Cry()
        {
            //base.Cry();
            WriteLine("멍멍");
        }
    }
    class Cat : Animal
    {
        public override void Cry()
        {
            //base.Cry(); 부모클래스의 메소드 원형을 그대로 사용하겠다
            WriteLine("야옹");
        }
    }
    class Snake : Animal
    {
        
    }

    //Decorator Pattern
    class coffe
    {
        int num = 30;
        public virtual int price()
        {
            WriteLine("커피주문");
            return num;
        }
    }
    class Sugar : coffe
    {
        int num = 20;
        coffe a;

        public Sugar(coffe a)
        {
            WriteLine("생성자");
            this.a = a;
        }
        public override int price()
        {
            WriteLine("설탕주문");
            return num + a.price();
        }

    }
    class Prim : coffe
    {
        int num = 10;
        coffe a;

        public Prim(coffe a)
        {
            WriteLine("생성자");
            this.a = a;
        }
        public override int price()
        {
            WriteLine("프림주문");
            return num + a.price();
        }

    }

    //Strategy Pattern
    class Baduk
    {
        AI ai;
        public Baduk(AI ai) 
        {
            this.ai = ai;
            WriteLine("대국을 시작합니다"); 
        }
        //public void Play(AlphaGo ag) { ag.Play(); }
        //public void Play(BetaGo ag) { ag.Play(); }
        public void Play() { ai.Play(); }
        public void Stop() { ai.Stop(); }
    }
    interface AI
    {
        //public virtual void Play() {}
        //abstract 클래스의 함수를 선언했으면 상속받은 클래스에서 무조건 구현해야한다
        void Play();
        void Stop();
    }
    class AlphaGo : AI
    {
        public void Play() { WriteLine("인공지능은 알파고입니다"); }
        public void Stop() { WriteLine("알파고가 점수를 계산합니다"); }
    }
    class BetaGo : AI
    {
        public void Play() { WriteLine("인공지능은 베타고입니다"); }
        public void Stop() { WriteLine("베타고가 점수를 계산합니다"); }
    }

    //this ex1)
    //chaining
    class Tiger
    {
        //Tiger this;
        //Tiger() {
        // this = tiger;
        //}
        int num = 10;
        public Tiger()
        {
            WriteLine(this.GetHashCode());
        }
        public Tiger(int num)
        {
            this.num = num;

        }
        public Tiger m1(int num)
        {
            this.num = num * 3;
            return this;
        }

        public Tiger m2()
        {
            WriteLine("1");
            return this;
        }
        public Tiger m3()
        {
            WriteLine("2");
            return this;
        }
        public void m4()
        {
            WriteLine("3");
        }
        public int money = 10;
        public int shape = 20;
        public void f1()
        {
            WriteLine("1");
            Lion lion = new Lion();
            lion.f2(this);
        }
    }

    class Lion
    {
        public void f2(Tiger T)
        {
            WriteLine(T.GetHashCode());
            WriteLine(T.money);
            WriteLine(T.shape);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. 객체를 한개 이상 만들지 마라 = 1개만 있어도 프로그램에 지장이없다
            //메모리 낭비가 발생함

            Singletone t1 = Singletone.getinstance();
            Singletone t2 = Singletone.getinstance();
            WriteLine(t1.GetHashCode());
            WriteLine(t2.GetHashCode());
            //해시코드가 동일하다는것을 알 수 있다.
            //객체생성은 한번밖에 되지않는다
            t1.Num = 2000;
            WriteLine(t1.Num);
            WriteLine(t2.Num);
            //다른 이름으로 객체를 만들어도 하나만을 가지고 공유한다
            Clear();

            //upcasting
            Zoo z1 = new Zoo();

            z1.sound(new Dog());
            z1.sound(new Cat());
            z1.sound(new Snake());
            Clear();

            //Decorator
            WriteLine("---------");
            coffe a = new coffe();
            WriteLine(a.price());

            WriteLine("---------");
            a = new Sugar(a);
            WriteLine(a.price());

            WriteLine("---------");
            a = new Prim(a);
            WriteLine(a.price());

            WriteLine("---------");
            a = new Prim(a);
            WriteLine(a.price());
            Clear();

            //Stratege
            Baduk baduk1 = new Baduk(new AlphaGo()); // 객체주입 Entity Injection
            baduk1.Play();
            baduk1.Stop();

            Baduk baduk2 = new Baduk(new BetaGo()); // 객체주입 Entity Injection
            baduk2.Play();
            baduk2.Stop();
            Clear();

            //this
            Tiger T = new Tiger();
            WriteLine(T.GetHashCode());
            WriteLine("-----------");
            Tiger T2 = T.m2();
            T2.m2().m2().m2();
            WriteLine("-----------");
            Tiger T1 = T.m2();
            T1.m2().m3().m4();
            Clear();
            WriteLine("-----------");

            T.f1();
        }
    }
}
