using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using static System.Console;
using System.Collections;

//1.  2021년 1월 1일 금요일 이다 2021년 달력
//윤년 고려 X
//1월
//일 월 화 수 목 금 토
//
//2월
//일 월 화 수 목 금 토

//2. int num = 0x7f3c7b4d;
//2진수로 리턴하는 함수를 만들어라
//string s = m1(num);
//0111 1111 0011 1100

//3.
//가로 5칸 세로 4칸의 행렬을 사용 테두리 있고 특정문자가 랜덤 위치에 4개 나타남

//4.
//모래시계 출력 입력값은 홀수

//5.100분율 히스토그램 생성
namespace _7._0707
{
    class Program
    {
        static int num = 10;
        static void m1()
        {

        }
        static void Main(string[] args)
        {
            int[] num = { 50, 64, 39, 66, 93, 78, 0, 100 };
            int[] count = { 0, 0, 0, 0, 0, 0, 0, 0 };
            char[,] ar = new char[8,10];

            for (int i = 0; i<num.Length ; i++)
            {
                count[i] = 10 - num[i] / 10;
            }

            foreach (int item in count)
            {
                WriteLine(item);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if(count[j] > 0)
                    {
                        Write("X");
                        count[j]--;
                    }
                    else
                    {
                        Write("O");
                    }
                }
                WriteLine();
            }

            Clear();
            int a = 10;
            WriteLine(a.GetType());
            WriteLine(Color.RED);
            WriteLine((int)Color.GREEN);

            Clear();
            //컴파일 할때 타입이 결정됨
            var b = "2000";
            
            //var 타입 + 변경가능
            object c = "3000";
            c = 3000;

            //실행할때 타입이 결정됨
            dynamic d = "5000";
            d = 6000;
            

            string nu = "lion";
            // 예외처리를 해줌
            WriteLine(nu?.Length);

            int? nu2 = null;
            Clear();
            WriteLine(DateTime.Now.DayOfWeek);
            string[] str = new string[] { "일", "월", "화", "수", "목", "금", "토"};
            int dw = (int)DateTime.Now.DayOfWeek;
            WriteLine(str[dw] + "요일");

            string s2 = string.Format("{0} {1}", 10, "호랑이");
            string filename = string.Format("{0:d4}", 10);
            WriteLine(s2);

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;

            _ = n3 % 2 == 0 ? n2++ : n3++;

            _ = 100;

            Clear();
            int n4 = 10;

            //or연산시 앞부분이 참이면 뒷 부분을 수행하지 않기때문에 조심하자
            if(false || ++n4 > 10)
            {

            }
            WriteLine(n4);

            Clear();
            int n5 = 0;
            for (int i = 0; i < 10; i++)
            {
                // 0,1 반전
                WriteLine(n5);
                n5 = 1 - n5;

                //+1,-1 반전
                n5 = -n5;
            }

            Clear();
            Tiger t1 = null;
            if (t1 != null)
            {
                t1.m1();
            }
            //객체가 널일경우 실행이 안됨
            t1?.m1();
            int y1 = 3;
            int y2 = 4;
            swap(ref y1, ref y2);

            Clear();
            //데이터 공유
            Tiger T = new Tiger();
            ref int t21 = ref T.f1();
            t21 = 200;
            WriteLine(T.Com);
        }

        public static void swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
        class Tiger
        {
            //데이터 공유
            public int Com = 20;
            public ref int f1()
            {
                return ref Com;
            }
            public void m1()
            {
                WriteLine("test");
            }
        }
        enum Color
        {
            RED,
            GREEN,
            BLUE
        };
        public static string Convert(int input)
        {
            int num = input;
            char[] ar = new char[] { '0', '0', '0', '0', ' ', '0', '0', '0', '0', ' ', '0', '0', '0', '0', ' ', '0', '0', '0', '0', ' ', '0', '0', '0', '0', ' ', '0', '0', '0', '0', ' ', '0', '0', '0', '0', ' ', '0', '0', '0', '0' };
            WriteLine(num);
            int count = 38;
            //0000 0000 0111 1111
            while (num >= 1)
            {
                //4 , 9 , 14
                if (count == 4 || count == 9 || count == 14 || count == 19 || count == 24 || count == 29 || count == 34) { count--; }

                ar[count] = (num % 2 == 1 ? '1' : '0');

                num = num / 2;
                count--;
            }
            WriteLine(ar);
            string s = new string(ar);
            WriteLine(s);
            return s;
        }
        
    }
}
